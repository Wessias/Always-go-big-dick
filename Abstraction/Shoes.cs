using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Shoes : Accessory
    {
        public override void BuyAccessory()
        {
            Console.WriteLine("Bought shoes");
        }

        public override void PutOnAccessory()
        {
            Console.WriteLine("Put on shoes");
        }
    }
}
