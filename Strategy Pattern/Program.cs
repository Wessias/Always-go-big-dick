using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main()
        {
            //New client that chooses pattern (Run) for strategy (IActionInterface) through ActionClient
            ActionClient runningClient = new ActionClient(new Run());
            Console.WriteLine(runningClient.Action());

            ActionClient jumpClient = new ActionClient(new Jump());
            Console.WriteLine(jumpClient.Action());
        }
    }
}
