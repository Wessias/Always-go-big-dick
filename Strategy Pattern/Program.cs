using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main()
        {
            ActionClient runningClient = new ActionClient(new Run());
            Console.WriteLine(runningClient.Action());

            ActionClient jumpClient = new ActionClient(new Jump());
            Console.WriteLine(jumpClient.Action());
        }
    }
}
