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
        //public Item(decimal price)
        //{
        //    this.price = price;
        //}
        public Item(decimal price,[CallerMemberName]string name = null) //: this(price)
        {
            this.price = price;
            this.name = name;
        }
        public event PropertyChangedEventHandler PropertyChanged;
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
                OnPropertyChanged();
                _price = value;
            }
        }
        //Important [CallerMemberName]
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
