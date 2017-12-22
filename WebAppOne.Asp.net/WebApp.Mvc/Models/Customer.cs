using System;

namespace PizzaStore.Library.Models
{
    public class Customer 
    {
        Customer a = new Address()
        a.Address();
        private int _customerID;
        private int _customerLimit;
        private int _customerTimeLimit;
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

/*
                public void WriteToFile()
        {
            var c = new Contact();

            c.Name = new Name(){First = "dot", Last = "net"};

            File.WriteAllText(@"C:\\Revature\\contact.txt", c.Name.ToString());
        }
*/
