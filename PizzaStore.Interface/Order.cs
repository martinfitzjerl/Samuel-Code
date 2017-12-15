using System;
using PizzaStore.Library.Models;
using System.Linq;

namespace PizzaStore.Library.Interface
{
    public class Order 
    {
        public void GetPizza()
        {
            Pizza topping  = new Pizza();
            Order pizza = new Pizza();

            List<Pizza> toppings = new List<Pizza>
            toppings.Add(topping.ToppingCheese());
            pizza.Add(topping.ToppingSausage());
            MyList.Add(topping.ToppingPepperoni());
            MyList.Add(topping.ToppingHam());
            MyList.Add(topping.ToppingBellPepper());
            MyList.Add(topping.ToppingChicken());
            MyList.Add(topping.ToppingSauce());
            MyList.Add(topping.CrustPan());
            MyList.Add(topping.CrustDeepDish());
            MyList.Add(topping.PizzaSize());
    }
}
{
    public Class2()
    {
        Class1 ord = new Class1();
        Pizza a = ord.MyList;
    }
}
    

        
                /*
                Pizza topping  = new Pizza();

                List<Pizza> toppings = new List<Pizza>
               {
                new Order(){ ToppingCheese = ToppingCheese},
                new Pizza(){ ToppingSausage = ToppingSausage },
                new Pizza(){ ToppingHam = ToppingHam },
                new Pizza(){ ToppingBellPepper = ToppingBellPepper },
                new Pizza(){ ToppingChicken = ToppingChicken },
                new Pizza(){ ToppingSauce = ToppingSauce },
                new Pizza(){ CrustPan = CrustPan },
                new Pizza(){ CrustDeepDish = CrustDeepDish },
                new Pizza(){ PizzaSize = PizzaSize }

                
                new Pizza(){ ToppingCheese = null},
                new Pizza(){ ToppingSausage = null },
                new Pizza(){ ToppingHam = null },
                new Pizza(){ ToppingBellPepper = null },
                new Pizza(){ ToppingChicken = null },
                new Pizza(){ ToppingSauce = null },
                new Pizza(){ CrustPan = null },
                new Pizza(){ CrustDeepDish = null },
                new Pizza(){ PizzaSize = null }
                */
                
            };
            foreach (Pizza topn in Pizza)
            System.Console.WriteLine(topn.Name);

            foreach (Pizza topn in Pizza)
            if (topn != null)
                
                System.Console.WriteLine(topn.Name);
            else
                if (topn == null)
                topn = 0;
                System.Console.WriteLine("List element is null.");
                Pizza = Order.Select(x => new Order { Pizza=x.Pizza})
        }

        public int OrderID
        { 
            get
            {
                return _orderID;
            } 
            private set
            {
                _orderID = value;
            } 
        }
        public int CustomerOrderLimit
        { 
            get
            {
                return _customerOrderLimit;
            } 
            private set
            {
                _customerOrderLimit = value;
            } 
        }
        public int CustomerTimeLimit
        { 
            get
            {
                return _customerTimeLimit;
            } 
            private set
            {
                _customerTimeLimit = value;
            } 
        }

        public void CustomerOrderLimit()
        {
            if _customerOrderLimit == 3

        }

        public void CustomerTimeLimit()
        {
            return customerTimeNumber;
        }
        public OrderLimit()
        {
            if (orderLimit == null && orderTimeLimit == 2)
                throw new ArgumentException("customer orders exceeded");
            else if (String.IsNullOrWhiteSpace(orderLimit))
                throw new ArgumentException("order cannot be an empty string");
        }
    }
}


/*
        public void SelectToppings()
        {
                new Pizza(){ ToppingCheese = null},
                new Pizza(){ ToppingSausage = null },
                new Pizza(){ ToppingHam = null },
                new Pizza(){ ToppingBellPepper = null },
                new Pizza(){ ToppingChicken = null },
                new Pizza(){ ToppingSauce = null },
                new Pizza(){ CrustPan = null },
                new Pizza(){ CrustDeepDish = null },
                new Pizza(){ PizzaSize = null }
        }
*/





        /*
        public Pizza()
        {
            p.ToppingCheese;
            p.ToppingSausage;
            p.ToppingPepperoni;
            p.ToppingHam;
            p.ToppingBellPepper;
            p.ToppingChicken;
            p.ToppingSauce;
            p.CrustPan;
            p.CrustDeepDish;
            p.PizzaSize;
        }

            
            Order p = new Pizza()
            this.ToppingCheese() = p.ToppingCheese; 
            this.ToppingSausage() = p.ToppingSausage;
            this.ToppingPepperoni() = p.ToppingPepperoni;
            this.ToppingHam() = p.ToppingHam;
            this.ToppingBellPepper() = p.ToppingBellPepper;
            this.ToppingChicken() = p.ToppingChicken;
            this.ToppingSauce() = p.ToppingSauce;
            this.CrustPan() = p.CrustPan;
            this.CrustDeepDish() = p.CrustDeepDish;
            this.PizzaSize() = p.PizzaSize;
            
            
            if (o.ToppingCheese() == null)
                throw new ArgumentNullException("The order cannot be null.");
            else if (String.IsNullOrWhiteSpace(make))
                throw new ArgumentException("order cannot be an empty string");

                public override string ToString()
                {
                 return $"{fname} {lname}".Trim();
                }
          */


