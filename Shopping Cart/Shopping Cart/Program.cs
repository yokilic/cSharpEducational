using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping_Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            Order order = new Order();
            order.getInput();

            while (!order.quit)
            {
                cart.processOrder(order);
                order = new Order();
                order.getInput();
                
            }



        }
    }
}
