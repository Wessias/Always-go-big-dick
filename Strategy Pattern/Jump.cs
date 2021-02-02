using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class Jump : IActionInterface
    {
        public string DoAction()
        {
            var action = "Jumping";
            return action;
        }
    }
}
