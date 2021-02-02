using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    //Pattern Jump
    class Jump : IActionInterface
    {
        public string DoAction()
        {
            return "Jumping";
        }
    }
}
