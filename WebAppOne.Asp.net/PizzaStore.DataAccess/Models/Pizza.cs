using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.DataAccess.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }//boxing object primitive to boolean object, bool?/ Nullable<bool> Active, boxing/casting to type boolean
        public DateTime DateModified { get; set; }
    }
}
