using System;

namespace PizzaStore.Library.Models
{
    public class Customer 
    {
        private int _customerID;
        private string _customerFirst;
        private string _customerLast;
        public int CustomerID
        { 
            get
            {
                return _customerID;
            }
            private set
            {
                _customerID = value;
            } 
        }

        public string CustomerFirst
        {
            get
            {
                return _customerFirst;
            }
            private set
            {
                _customerFirst = value;
            }
        }

        public string CustomerLast
        {
            get
            {
                return _customerLast;
            }
            private set
            {
                _customerLast = value;
            }
        }
    }
}

/*
                public void WriteToFile()
        {
            var c = new Contact();

            c.Name = new Name(){First = "dot", Last = "net"};

            File.WriteAllText(@"C:\\Revature\\contact.txt", c.Name.ToString());
        }
*/
