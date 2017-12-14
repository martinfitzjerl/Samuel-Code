using System;

namespace PizzaStore.Library.Models
{
    public class Sales
    {
        public char Sales 
        { 
            get
            {
                return _sales;
            } 
            private set
            {
                _sales = value;
            } 
        }
        
        public int QuantityOrder 
        { 
            get
            {
                return _quantityOrder;
            } 
            private set
            {
                _quantityOrder = value;
            } 
        }
    }
}