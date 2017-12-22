using System;

namespace PizzaStore.Library.Models
{
    public class Name
    {
        public string FirstName 
        { 
            get
            {
                return _firstName;
            }
            private set
            {
                _firstName = value;
            } 
        }
        public char LastName 
        { 
            get
            {
                return _lastName;
            }
            private set
            {
                _lastName = value;
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
    }
}