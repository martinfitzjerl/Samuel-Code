using System;

namespace PizzaStore.Library.Models;
{
    public class History
    {
        History h = new History();
        h.Customer();
        
    
        public History
        { 
            get
            {
                return _history;
            } 
            private set
            {
                _history = value;
            } 
        }

    }
}