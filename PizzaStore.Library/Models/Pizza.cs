using System;

namespace PizzaStore.Library.Models
{
    public class Pizza
    {
        public int ToppingCheese 
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
        public int ToppingSausage 
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
        public int ToppingPepperoni 
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
                        
        public int ToppingHam 
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
        public int ToppingChicken 
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
        public int ToppingSauce 
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
         
        public int CrustDeepDish { get; set; }
    }

        

    }
}