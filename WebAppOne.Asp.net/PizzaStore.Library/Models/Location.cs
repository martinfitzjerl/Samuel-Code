using System;


namespace PizzaStore.Library.Models
{
    public class Location
    {

        private string _locationName;
        private string _locationDescription;

        public String LocationName
        { 
            get
            {
                return _locationName;
            }
            private set
            {
                _locationName = value;
            }
        }

        public String LocationDescription
        { 
            get
            {
                return _locationDescription;
            }
            private set
            {
                _locationDescription = value;
            } 
        }
        
    }
    
}