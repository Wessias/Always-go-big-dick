using System;
using System.ComponentModel.Design;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Custommer niklas = new Custommer
            {
                sc_name = "Niklas Hjelm",
                sc_mail = "soonToBeSickCunt@gmail.com"
            };

            bool shoping = true;

            niklas.Buy();
            while (shoping) {
                switch (niklas.Menu())
                {
                
                    
                    case 1:
                        Console.WriteLine("\nFUCKING CASUAL STOP BEING A SHIT CUNT AND DO IT YOURSELF LIKE A REAL HARDCORE PLAYER. \n You can still get it in ur cart tho");
                        var mythicCarry = new MythicCarry();
                        niklas.sc_cart.Add(mythicCarry);
                        break;

                    case 2:
                        Console.WriteLine("\nYOU WANT 3K RATING HUH??? FAWKIN SHIT CUNT DO IT YOURSELF IF U WANNA BE A SICK CUNT. \n Pay me and I'LL STILL DO IT THOUGH.");
                        var ratingBoost = new BoostTo3k();
                        niklas.sc_cart.Add(ratingBoost);
                        break;

                    case 3:
                        Console.WriteLine("\nYOU INTO THAT SICK CUNT SHIT AYYOOOOOO I SEE U HOLMES. I'LL GIVE U A DISCOUNT FOR THIS BIATCH.");
                        var goldshireERP = new ERPinGoldshire();
                        niklas.sc_cart.Add(goldshireERP);
                        break;

                    case 4:
                        Console.WriteLine("\nThis is the stuff you've put in ur cart sad cunt:");
                        foreach (var product in niklas.sc_cart)
                        {
                            product.ProductName();
                        }
                        break;

                    case 5:
                       Console.WriteLine("\nHope I'll se ya again sick cunt");
                       shoping = false;
                       break;

                    default:
                       Console.WriteLine("\nSTOP BEING A SHIT CUNT AND BECOME A SICK CUNT!");
                       break;

                }
            }

            Console.WriteLine("\nYou wanted this shit right?");
            foreach(var product in niklas.sc_cart)
            {
                product.ProductName();
            }


        }



        
    }
}
