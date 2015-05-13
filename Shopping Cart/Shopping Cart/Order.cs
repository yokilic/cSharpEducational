using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping_Cart
{
    /// <summary>
    /// Initializes a new Order Class 
    /// </summary>
    public class Order
    {

        public bool add;
        public bool delete;
        public bool quit = false;
        public string item;

      
        public void getInput()
        {
            Console.WriteLine("[command] [item] (command is a to add, d to delete, q to quit)");
            string line = Console.ReadLine();
            char command = line.ToCharArray()[0];
            item = line.Substring(1);

            switch (command)
            {
                case 'q':
                    quit = true;
                    break;
                case 'a':
                    add = true;
                    break;
                case 'd':
                    delete = true;
                    break;
                default:
                    break;
            }

        }

       
    }
}
