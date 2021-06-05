using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventsTraining.Version2
{
    public class Item : INotifyPropertyChanged
    {
        public Item(decimal price)
        {
            this.price = price;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private decimal _price;
        public decimal price
        {
            get
            {
                return _price;
            }
            set
            {
                OnPropertyChanged();
                _price = value;
            }
        }
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
