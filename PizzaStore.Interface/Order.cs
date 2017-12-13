using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Interface
{
    public class Order
    {
        Order o = new Order();
        o.ToppingCheese();
        o.ToppingSausage();
        o.ToppingPepperoni();
        o.ToppingHam();
        o.ToppingBellPepper();
        o.ToppingChicken();
        o.ToppingSauce();
        o.CrustPan();
        o.CrustDeepDish();
        o.PizzaSize();


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


        public void SelectToppings()
        {

        }


    }
}