/*using System;
using PizzaStore.DataAccess;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    class LibHelper
    {
        private static LibHelper _LH;
        private static List<Pizza> _Pizzas = new List<Pizza>();
        private static PizzaStoreDBContext _DB = new PizzaStoreDBContext();

        private LibHelper()
        {

        }

        public static LibHelper Instance()
        {
            if (_LH == null)
            {
                _LH = new LibHelper();
            }

            return _LH;
        }

        public List<PizzaStore> AddPizza(Pizza p)
        {
            try
            {
                if (p == null)
                {
                    return false;
                }

                _DB.Add(ps);
                //_DB.Add(PizzaToDataAccess(new List<Pizza>() { p }).FirstOrDefault());
                _DB.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<PizzaStore> GetPizza(Pizza p = null)
        {
            if (p==null)
            {
                return _Pizzas;
            }
            return _Pizzas.FindAll(i => i.Name == p.Name);

        }

        private List<Dac.Pizza> PizzaToDataAccess(List<Pizza> ps)
        {
            var ls = 
        }


        
    }
}
*/