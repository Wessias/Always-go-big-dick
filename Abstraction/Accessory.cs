using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Accessory
    {
        public string Accessory1 { get; set; }
        public string Accessory2 { get; set; }

        public abstract void PutOnAccessory();

        public abstract void BuyAccessory();
    }
}
