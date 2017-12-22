using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Models
{
    public class Phone
    {
        private int _phoneID;
        private int _phoneNumber;
        public int PhoneID
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
        public int PhoneNumber
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
