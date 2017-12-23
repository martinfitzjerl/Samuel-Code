using System;

namespace PizzaStore.Library.Models
{
    public class Name
    {
        private string _firstName;
        private string _lastName;
        private string _companyName;
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
        public string LastName 
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
        public string CompanyName
        {
            get
            {
                return _companyName;
            }
            private set
            {
                _companyName = value;
            }
        }
    }
}