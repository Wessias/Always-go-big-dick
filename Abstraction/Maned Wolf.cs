using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Maned_Wolf : Animal
    {
        public override void AnimalEatPoop()
        {
            Console.WriteLine("These bitches are holy, holy bitches dont eat shit");
        }

        public override void DoTheSound()
        {
            Console.WriteLine("Ahooooo?");
        }
    }
}
