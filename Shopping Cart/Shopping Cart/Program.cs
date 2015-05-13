using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
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
