namespace PizzaStore.Library.Models
{
    public class Address
    {
        private char _street;
        private char _city;
        private char _state;
        private int _zipcode;
        public char Street 
        { 
            get
            {
                return _street;
            } 
            set
            {
                _street = value;
            } 
        }
        public char City { get; set; }
        public char State { get; set; }
        public int Zipcode { get; set; }
    }
}