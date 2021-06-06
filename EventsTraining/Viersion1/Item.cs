using System;
using System.Runtime.CompilerServices;

namespace EventsTraining
{
    public class Item
    {
        public static event EventHandler<PriceChangedEventArgs> PriceChanged;
        public event EventHandler<decimal> PriceEvent;
        public string Name { get; set; }
        private decimal _price;
        public decimal price
        {
            get
            {
                OnPriceEvent(_price);
                return _price;
            }
            set
            {
                if (_price == value) return;
                PriceChangedEventArgs price = new PriceChangedEventArgs(value, _price);
                OnPriceChanged(price);
                _price = value;
            }
        }
        protected void OnPriceEvent(decimal e)
        {
            PriceEvent?.Invoke(this, e);
        }
        protected void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }
}
