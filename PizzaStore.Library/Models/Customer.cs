namespace PizzaStore.Library.Models
{
    public class Customer : Address
    {
        Customer c = Address
        Address = c.Address();
        private int customerLimit;

        public int CustomerLimit { get; set; }

        public void CustomerLimit()
        {

            c.Address = Address();
            c.
        }


        

        

/*
                public void WriteToFile()
        {
            var c = new Contact();

            c.Name = new Name(){First = "dot", Last = "net"};

            File.WriteAllText(@"C:\\Revature\\contact.txt", c.Name.ToString());
        }
*/

        public void CustomerLast()
        {
            return customerLast;
        }

        public void CustomerAddress()
        {
            return customerAddress;
        }

        public void OrderTotal()
        {
            return orderTotal;
        }

        public void CustomerPizza()
        {
            return customerPizza;
        }



    }
}