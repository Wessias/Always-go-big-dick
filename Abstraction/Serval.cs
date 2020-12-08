using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Serval : Animal
    {
        public override void AnimalEatPoop()
        {
            Console.WriteLine("Servals dont eat shit wtf");
        }

        public override void DoTheSound()
        {
            Console.WriteLine("Meow?");
        }
    }
}
