using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    //Which pattern to use in strategy
    class ActionClient
    {
        private IActionInterface actionInterface;

        public ActionClient(IActionInterface strategy)
        {
            actionInterface = strategy;
        }


        public string Action()
        {
            return actionInterface.DoAction();
        }
    }
}
