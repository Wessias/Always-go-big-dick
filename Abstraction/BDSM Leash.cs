using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class BDSM_Leash : Accessory
    {
        public override void BuyAccessory()
        {
            Console.WriteLine("Bought leash");
        }

        public override void PutOnAccessory()
        {
            Console.WriteLine("Put on leash, maybe you shouldnt do that in the store");
        }
    }
}
