using System;
using PizzaStore.Library.Models;

namespace PizzaStore.Library.Models
{
    public class History
    {
        History h = new History();
        h.Customer();
        public HistoryID
        { 
            get
            {
                return _historyID;
            } 
            private set
            {
                _historyID = value;
            } 
        }        

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