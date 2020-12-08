using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Animal
    {
        public int LegAmount { get; set; }
        public string ThiccnessLevel { get; set; }

        public abstract void DoTheSound();

        public abstract void AnimalEatPoop();
    }
}
