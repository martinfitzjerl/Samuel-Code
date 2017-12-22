using System;
namespace PizzaStore.Library.Models
{
    public class Calculate
    {
        private double cheesePrice = 1.00;
        private double sausagePrice = 1.50;
        private double pepperoniPrice = 1.00;
        private double hamPrice = 1.50;
        private double bellPepperPrice = 1.00;
        private double chickenPrice = 2.00;
        private double saucePrice = 1.00;
        private double crustPanPrice = 1.00;
        private double crustDeepDishPrice = 2.00;
        private double pizzaSizePrice = 1.00;
        private double orderTotal = 0;

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
