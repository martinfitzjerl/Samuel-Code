using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Models
{
    public class Phone
    {

        private int _phone;
        public int PhoneID { get; set; }
        { 
            get
            {
                return _phoneID;
            } 
            private set
            {
                _phoneID = value;
            } 
        }
    }
}
