/*
using System;
namespace PizzaStore.Library.Models
{
    public class Calculate
    {

        Pizza p = new Pizza();

        private double _orderTotal;

        public double OrderTotal
        {
            get
            {
                return _orderTotal;
            }
            private set
            {
                _orderTotal = value;
            }
        }
        
        public void CalculateTotal()
        {
            _orderTotal =+ _cheesePrice * p.ToppingCheese();
            _orderTotal =+ _sausagePrice * p.ToppingSausage;
            _orderTotal =+ _pepperoniPrice * p.ToppingPepperoni;
            _orderTotal =+ _hamPrice * p.ToppingHam;
            _orderTotal =+ _bellPepperPrice * p.ToppingBellPepper;
            _orderTotal =+ _chickenPrice * p.ToppingChicken;
            _orderTotal =+ _saucePrice * p.ToppingSauce;
            _orderTotal =+ _crustPanPrice * p.CrustPan;
            _orderTotal =+ _crustDeepDishPrice * p.CrustDeepDish;
            _orderTotal =+ _pizzaSizePrice * p.PizzaSize;
            return _orderTotal;
        }
    }


}
*/