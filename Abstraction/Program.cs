using System;
using System.Collections.Generic;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal> { };
            var accessoryList = new List<Accessory> { };

            var blabla = true;
            while (blabla) { 
            Console.WriteLine("Wtf kinda animal u want \n Maned Wolf \n Serval \n Black sicklebill \n Quit");

                switch (Console.ReadLine())
                {
                    case "Maned Wolf":
                        animalList.Add(new Maned_Wolf { });
                        break;
                    case "Serval":
                        animalList.Add(new Serval { });
                        break;
                    case "Black sicklebill":
                        animalList.Add(new Black_sicklebill { });
                        break;
                    case "Quit":
                        blabla = false;
                        break;
                    default:
                        break;
                }
            }

            var yaya = true;
            while (yaya)
            {
                Console.WriteLine("Wtf kinda animal u want \n BDSM leash \n Hoodie with a huge peepee on the front \n Poop knife \n Shoes \n Used coconut \n Useful tool \n Quit");

                switch (Console.ReadLine())
                {
                    case "BDSM leash":
                        accessoryList.Add(new BDSM_Leash { });
                        break;
                    case "Hoodie with a huge peepee on the front":
                        accessoryList.Add(new Hoodie_With_A_Huge_Peepee_On_The_Front { });
                        break;
                    case "Poop knife":
                        accessoryList.Add(new Poop_Knife { });
                        break;
                    case "Shoes":
                        accessoryList.Add(new Shoes { });
                        break;
                    case "Used coconut":
                        accessoryList.Add(new Used_Coconut { });
                        break;
                    case "Useful tool":
                        accessoryList.Add(new Useful_Tool { });
                        break;
                    case "Quit":
                        yaya = false;
                        break;
                    default:
                        break;
                }
                
            }


            foreach (var animal in animalList)
            {
                animal.AnimalEatPoop();
                animal.DoTheSound();
            }

            foreach (var accessory in accessoryList)
            {
                accessory.BuyAccessory();
                accessory.PutOnAccessory();
            }

        }

    }
}
