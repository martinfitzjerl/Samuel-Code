using System;
using PizzaStore.Library.Models;

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

        public int SalesID
            { 
            get
            {
                return _salesID;
            } 
            private set
            {
                _salesID = value;
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