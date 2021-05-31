using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTraining
{
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal NewPrice;
        public readonly decimal OldPrice;
        public PriceChangedEventArgs(decimal newPrice, decimal oldPrice)
        {
            NewPrice = newPrice;
            OldPrice = oldPrice;
        }
    }
}
