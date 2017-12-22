using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Models
{
    public class Phone
    {

        private int _phoneNumber;
        public int PhoneID { get; set; }
        { 
            get
            {
                return _phoneNumber;
            } 
            private set
            {
                _phoneNumber = value;
            } 
        }
    }
}
