using System;

namespace PizzaStore.Library.Models
{
    public class Pizza
    {
        Pizza p = new Pizza();
        public Pizza()
        {
            p.ToppingCheese;
            p.ToppingSausage;
            p.ToppingPepperoni;
            p.ToppingHam;
            p.ToppingBellPepper;
            p.ToppingChicken;
            p.ToppingSauce;
            p.CrustPan;
            p.CrustDeepDish;
            p.PizzaSize;
        }
        private int toppingCheese;
        private int toppingSausage;
        private int toppingPepperoni;
        private int toppingHam;
        private int toppingBellPepper;
        private int toppingChicken;
        private int toppingSauce;
        private int crustPan;
        private int crustDeepDish;
        private int pizzaSize;

        public int ToppingCheese {get{ _toppingCheese} private set return;}
        public int ToppingSausage { get; set; }
        public int ToppingPepperoni { get; set;}
        public int ToppingHam { get; set;}
        public int ToppingBellPepper { get; set;}
        public int ToppingChicken { get; set; }
        public int ToppingSauce { get; set; }
        public int CrustPan { get; set; }
        public int CrustDeepDish { get; set; }
        public int PizzaSize { get; set; }
        

    }
}