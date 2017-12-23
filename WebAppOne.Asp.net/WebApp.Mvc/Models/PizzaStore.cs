using System;

namespace PizzaStore.Library.Models
{
    public class PizzaStore
    {
        private int _pizzaStoreID;
        private string _pizzaStoreName;

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

        public string PizzaStoreName
        {
            get
            {
                return _pizzaStoreName;
            }
            private set
            {
                _pizzaStoreName = value;
            }
        }
    }
}




/*
          PizzaStore ps = new PizzaStore();
        ps.Location();
        ps.Name();
        ps.Phone();
        ps.Sales();
        ps.Inventory();
        ps.History();
        ps.Customer();
 * 
 */
