using System;

namespace PizzaStore.Library.Models;
{
    public class History
    {
        public char History
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

        public void GetHistory()
        {
            
        }
    }
}