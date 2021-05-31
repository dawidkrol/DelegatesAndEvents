using System;

namespace EventsTraining
{
    public class Item
    {
        public static event EventHandler<PriceChangedEventArgs> PriceChanged;
        public string Name { get; set; }
        private decimal _price;
        public decimal price
        {
            get
            {
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
        protected void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }
}
