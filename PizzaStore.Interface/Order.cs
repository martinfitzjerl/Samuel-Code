using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Interface
{
    public class Order 
    {
        Order o = Order();
        



        public Order()
        {
            
            this.ToppingCheese() = toppingCheese; 
            this.ToppingSausage() = toppingSausage;
            this.ToppingPepperoni() = toppingPepperoni;
            this.ToppingHam() = toppingHam;
            this.ToppingBellPepper() = toppingBellPepper;
            this.ToppingChicken() = toppingChicken;
            this.ToppingSauce() = toppingSauce;
            this.CrustPan() = crustPan;
            this.CrustDeepDish() = crustDeepDish;
            this.PizzaSize() = pizzaSize;
            
            /*
            if (order == null)
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