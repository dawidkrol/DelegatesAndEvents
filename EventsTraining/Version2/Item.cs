using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventsTraining.Version2
{   
    /// <summary>
    /// Item to sale
    /// </summary>
    public class Item : INotifyPropertyChanged,IEquatable<Item>
    {
        //public Item(decimal price)
        //{
        //    this.price = price;
        //}
        /// <summary>
        /// Constructor which has dwo arguments 
        /// </summary>
        /// <param name="price">Item`s price</param>
        /// <param name="name">Name of item</param>
        public Item(decimal price,string name) //: this(price)
        {
            this.price = price;
            _name = name;
        }
        /// <summary>
        /// Zmiana własności obiektu
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;
        /// <summary>
        /// Item`s name
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                OnPropertyChanged();
                _name = value;
            }
        }
        private decimal _price;
        /// <summary>
        /// Item`s price in decimal
        /// </summary>
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
        /// <summary>
        /// Wywołanie zdarzenia
        /// </summary>
        /// <param name="propertyName">Name of caller (defaulty knowny by CallerMemberName arttribute)</param>
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    /// <summary>
    /// overwriting Equals method
    /// </summary>
    /// <param name="other"></param>
    /// <returns>bool</returns>
        public bool Equals(Item other)
        {
            if(_name == other._name)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return _name.GetHashCode() * 37;
        }
    }
}
