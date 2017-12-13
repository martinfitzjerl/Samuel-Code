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


        public void ToppingCheese()
        {


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