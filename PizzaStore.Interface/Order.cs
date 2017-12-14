using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Interface
{
    public class Order 
    {
        public void Order()
        {
            Order p = new Pizza()
            this.ToppingCheese() = p.ToppingCheese; 
            this.ToppingSausage() = p.ToppingSausage;
            this.ToppingPepperoni() = p.ToppingPepperoni;
            this.ToppingHam() = p.ToppingHam;
            this.ToppingBellPepper() = p.ToppingBellPepper;
            this.ToppingChicken() = p.ToppingChicken;
            this.ToppingSauce() = p.ToppingSauce;
            this.CrustPan() = p.CrustPan;
            this.CrustDeepDish() = p.CrustDeepDish;
            this.PizzaSize() = p.PizzaSize;
            
            /*
            if (o.ToppingCheese() == null)
                throw new ArgumentNullException("The order cannot be null.");
            else if (String.IsNullOrWhiteSpace(make))
                throw new ArgumentException("order cannot be an empty string");
          */


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
            if (orderLimit == null && orderTimeLimit == 6)
                throw new ArgumentException("customer orders exceeded");
            else if (String.IsNullOrWhiteSpace(orderLimit))
                throw new ArgumentException("order cannot be an empty string");
        }


        public void SelectToppings()
        {

        }


    }
}