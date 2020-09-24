using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Custommer
    {
        public string sc_name;
        public string sc_mail;
        public List<Product> sc_cart = new List<Product>();

        

         public void buy()
        {
            Console.WriteLine("\n Buy something shitface.");
            
        }


         public int Menu()
        {
            Console.WriteLine("What do you want to buy my dude?????" +
                "\n (1) Mythic Carry \n (2) 3k rating carry \n (3) ERP in Goldshire \n (4) I'M DONE WITH THIS SHIT GET ME OUT OF THIS STOREEEEEEEE!!!!!");
            int product = Convert.ToInt32(Console.ReadLine());
            return product;
        }


    }
}
