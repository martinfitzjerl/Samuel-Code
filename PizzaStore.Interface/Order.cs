using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Interface
{
    public class Order
    {
        Order o = new Order();
        o.ToppingCheese();
        o.ToppingSausage() = ToppingSausage;
        o.ToppingPepperoni() = ToppingPepperoni;
        o.ToppingHam() = ToppingHam;
        o.ToppingBellPepper() = ToppingBellPepper;
        o.ToppingChicken() = ToppingChicken;
        o.ToppingSauce() = ToppingSauce;
        o.CrustPan() = CrustPan;
        o.CrustDeepDish() = CrustDeepDish;
        o.PizzaSize() = PizzaSize;


        public Order(string order, )
        {
            if (order == null)
                throw new ArgumentNullException("The order cannot be null.");
            else if (String.IsNullOrWhiteSpace(make))
                throw new ArgumentException("order cannot be an empty string");
            


        }

        public void CustomerOrderLimit()
        {
            return customerOrderNumber;
        }

        public void CustomerTimeLimit()
        {
            return customerTimeNumber;
        }
        public OrderLimit()
        {
            if (orderLimit == null)
                throw new Arg
        }

        public void GetCustomerLast()
        {

        }

        public void GetCustomerAddress()
        {

        }

        public void SelectToppings()
        {

        }


    }
}