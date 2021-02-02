using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    //Pattern Run
    class Run : IActionInterface
    {
        public string DoAction()
        {
            return "Running";
        }
    }
}
