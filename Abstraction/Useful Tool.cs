using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Useful_Tool : Accessory
    {
        public override void BuyAccessory()
        {
            Console.WriteLine("Bought a useful tool");
        }

        public override void PutOnAccessory()
        {
            Console.WriteLine("Put the very useful tool on your head");
        }
    }
}
