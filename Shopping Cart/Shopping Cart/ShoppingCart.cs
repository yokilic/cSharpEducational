using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping_Cart
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
           _content =  new Dictionary<string, int>();
        }



        Dictionary<string, int> _content;


        public void processOrder(Order order)
        {
            
        }
    }
}
