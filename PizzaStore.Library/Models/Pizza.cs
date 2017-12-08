using System;

namespace Library.Models

public class Pizza : Order
{
    public void Toppings() {get; set;}

    public void getToppings()
    {
        return Toppings;
    }

    

}