using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Models
{
    public class Customer 
    {
        private int customerLimit;
        private int customerTimeLimit;
        private string customerFirst;
        private string customerLast;
        private char customerAddress;
        private int phone;

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
