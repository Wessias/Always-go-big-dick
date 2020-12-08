using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Used_Coconut : Accessory
    {
        public override void BuyAccessory()
        {
            Console.WriteLine("Bought a used coconut");
        }

        public override void PutOnAccessory()
        {
            Console.WriteLine("Put on the used coconut");
        }
    }
}
