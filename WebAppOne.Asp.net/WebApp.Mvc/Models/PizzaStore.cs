using System;

namespace PizzaStore.Library.Models
{
    public class PizzaStore
    {
        public int PizzaStoreID
        { 
            get
            {
                return _pizzaStoreID;
            } 
            private set
            {
                _pizzaStoreID = value;
            } 
        }

        

        
    }
}



/*
 *         PizzaStore ps = new PizzaStore();
        ps.Location();
        ps.Name();
        ps.Phone();
        ps.Sales();
        ps.Inventory();
        ps.History();
        ps.Customer();
 * 
 * /
