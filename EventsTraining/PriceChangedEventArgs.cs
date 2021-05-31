using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTraining
{
    public class PriceChangedEventArgs : EventArgs
    {
        public decimal NewPrice { get; private set; }
        public decimal OldPrice { get; private set; }
        public PriceChangedEventArgs(decimal newPrice, decimal oldPrice)
        {
            NewPrice = newPrice;
            OldPrice = oldPrice;
        }
    }
}
