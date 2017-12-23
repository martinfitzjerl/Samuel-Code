using System;


namespace PizzaStore.Library.Models
{
    public class Sales
    {
        private double _sale;
        private double _saleID;
        private int _quantityOrder;
        private int _saleTax;


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

        public int SaleTax
        {
            get
            {
                return _saleTax;
            }
            private set
            {
                _saleTax = value;
            }
        }
    }
}