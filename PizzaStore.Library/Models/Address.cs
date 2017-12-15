namespace PizzaStore.Library.Models
{
    public class Address
    {
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
        public char Street 
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
        public char City 
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

        public char State 
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