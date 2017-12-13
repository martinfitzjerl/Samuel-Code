using System;

namespace PizzaStore.Library.Models
{
    public class Pizza
    {
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

        public int ToppingCheese {get; set;}
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