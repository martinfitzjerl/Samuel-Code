using System;


namespace PizzaStore.Library.Models
{
    public class Sales
    {
        private double _sale;
        private double _saleID;
        private int _quantityOrder;
        public double Sale 
        { 
            get
            {
                return _sale;
            } 
            private set
            {
                _sale = value;
            } 
        }

        public double SaleID
            { 
            get
            {
                return _saleID;
            } 
            private set
            {
                _saleID = value;
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