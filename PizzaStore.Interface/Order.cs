using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Interface
{
    public class Order
    {
        Pizza p = new Pizza();
        p.ToppingCheese = ToppingCheese;
        p.ToppingSausage = ToppingSausage;
        p.ToppingPepperoni = ToppingPepperoni;
        p.ToppingHam = ToppingHam;
        p.ToppingBellPepper = ToppingBellPepper;
        p.ToppingChicken = ToppingChicken;
        p.ToppingSauce = ToppingSauce;
        p.CrustPan = CrustPan;
        p.CrustDeepDish = CrustDeepDish;
        p.PizzaSize = PizzaSize;


        public Order(string order, )
        {
            if (order == null)
                throw new ArgumentNullException("The order cannot be null.");
            else if (String.IsNullOrWhiteSpace(make))
                throw new ArgumentException("order cannot be an empty string");
            


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