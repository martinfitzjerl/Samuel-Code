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
        
        public void CalculateTotal()
        {
            return orderTotal;
        }
    }


}
