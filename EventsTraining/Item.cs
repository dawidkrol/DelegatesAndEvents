using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTraining
{
    public class Item
    {
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        public string name { get; set; }
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
                OnPriceChanged(new PriceChangedEventArgs(_price, value));
                _price = value;
            }
        }
        protected void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }
}
