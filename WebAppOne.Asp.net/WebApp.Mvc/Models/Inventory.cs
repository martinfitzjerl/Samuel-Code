using System;

namespace PizzaStore.Library.Models
{
    public class Inventory
    {       
        public char ToppingCheese 
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
        public char ToppingSausage 
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
        public char ToppingPepperoni 
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
                        
        public char ToppingHam 
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
        public char ToppingBellPepper 
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
        public char ToppingChicken 
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
        public char ToppingSauce 
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
        public char CrustPan 
        { 
            get
            {
                return _crustPan;
            } 
            private set
            {
                _crustPan = value;
            } 
        }
        public char CrustDeepDish 
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
    }   
}