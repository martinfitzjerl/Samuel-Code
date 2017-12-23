/*
using System;
using System.Collections.Generic;
using Lib = PizzaStore.Library;
using System.Linq;
using System.Web;

namespace WebApp.Mvc.Models
{
    public class SuperModel
    {
        private static List<Pizza> _Pizzas = new List<Pizza>();
        private Lib.LibHelper _LH = Lib.LibHelper.Instance();
    }

    public List<Pizza> GetPizza()
    {
        return PizzaToClient(_LH.GetPizza());
    }

    private List<Pizza> PizzaToClient(List<Lib.Pizza> ps)
    {
        var ls = new List<Pizza>();

        foreach (var item in ps)
        {
            ls.Add(new Pizza()
            {
                Name = item.Name
            });
        }
    }

    public void AddPizza(Pizza p)
    {
        var pl = new Lib.Pizza() 
    }

    private List<Pizza> PizzaToLibrary(List<Pizza> ps)
    {

    }
}
*/