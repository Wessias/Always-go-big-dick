using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class Run : IActionInterface
    {
        public string DoAction()
        {
            var action = "Running";
            return action;
        }
    }
}
