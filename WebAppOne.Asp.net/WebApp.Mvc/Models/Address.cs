using System;

namespace PizzaStore.Library.Models
{
    public class Address
    {
        private int _addressID;
        private string _street;
        private string _city;
        private string _state;
        private int _zipcode;

        public int AddressID
        { 
            get
            {
                return _addressID;
            } 
            private set
            {
                _addressID = value;
            } 
        }
        public string Street 
        { 
            get
            {
                return _street;
            } 
            private set
            {
                _street = value;
            } 
        }
        public string City 
        { 
            get
            {
                return _city;
            }
            private set
            {
                _city = value;
            } 
        }

        public string State 
        { 
            get
            {
                return _state;
            }
            private set
            {
                _state = value;
            } 
        }

        public int ZipCode 
        { 
            get
            {
                return _zipcode;
            }
            private set
            {
                _zipcode = value;
            } 
        }        
    }
}