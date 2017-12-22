using System;

namespace PizzaStore.Library.Models
{
    abstract class Pizza
    {
        private string _toppingCheese;
        private string _toppingSausage;
        private string _toppingPepperoni;
        private string _toppingHam;
        private string _toppingPepperoni;
        private string _toppingBellPepper;
        private string _crustPan;
        private double _pizzaPrice;
        

        public string ToppingCheese 
        { 
            get
            {
                return _toppingCheese;
            } 
            private set
            {
                _toppingCheese = value;
            } 
        }
        public string ToppingSausage 
        { 
            get
            {
                return _toppingSausage;
            } 
            private set
            {
                _toppingSausage = value;
            } 
        }
        public string ToppingPepperoni 
        { 
            get
            {
                return _toppingPepperoni;
            } 
            private set
            {
                _toppingPepperoni = value;
            } 
        }
                        
        public string ToppingHam 
        { 
            get
            {
                return _toppingHam;
            } 
            private set
            {
                _toppingHam = value;
            } 
        }
        public int ToppingBellPepper 
        { 
            get
            {
                return _toppingBellPepper;
            } 
            private set
            {
                _toppingBellPepper = value;
            } 
        }
        public string ToppingChicken 
        { 
            get
            {
                return _toppingChicken;
            } 
            private set
            {
                _toppingChicken = value;
            } 
        }
        public string ToppingSauce 
        { 
            get
            {
                return _toppingSauce;
            } 
            private set
            {
                _toppingSauce = value;
            } 
        }
        public int CrustPan 
        { 
            get
            {
                return _crustPan;
            } 
            private set
            {
                _crustPan = 1;
            } 
        }
        public int CrustDeepDish 
        { 
            get
            {
                return _crustDeepDish;
            } 
            private set
            {
                _crustDeepDish = value;
            } 
        }
        public double PizzaPrice
        {
            get
            {
                return _pizzaPrice;
            }
        }
        public int PizzaSize 
        { 
            get
            {
                return _pizzaSize;
            } 
            private set
            {
                _pizzaSize = 1;
            } 
        }
    }
}