using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Poop_Knife : Accessory
    {
        public override void BuyAccessory()
        {
            Console.WriteLine("Bought poop knife");
        }

        public override void PutOnAccessory()
        {
            Console.WriteLine("Equip poop knife...");
        }
    }
}
