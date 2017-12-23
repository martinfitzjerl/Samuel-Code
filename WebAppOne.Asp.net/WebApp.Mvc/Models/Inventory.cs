using System;
using WebApp.Mvc.Models.Property;

namespace PizzaStore.Library.Models
{
    public class Inventory : PizzaProperty
    {
        private string _toppingCheese;
        private string _toppingSausage;
        private string _toppingPepperoni;
        private string _toppingHam;
        private string _toppingBellPepper;
        private string _toppingChicken;
        private string _toppingSauce;
        private string _crustPan;
        private string _crustDeepDish;



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
        public string ToppingBellPepper 
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
        public string CrustPan 
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
        public string CrustDeepDish 
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