using System;


namespace PizzaStore.Library.Models
{
    public class Location
    {


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

        public String LocationNote
            get
            {
                return _locationNote;
            }
            private set
            {
                _locationNote = value;
            } 
        }
        
    }
    
}