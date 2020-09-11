using System;
using System.Linq;

namespace Metoder1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfList(new int[]{1,4,5,10,122}));
            SwapOrderOfList(new string[] { "Nugget", "Cunt", "Bing", "Bang" });
            Console.WriteLine(" ");
            Console.WriteLine(MaxAndMinItemInList(new long[] { 2000, 9, 100, 165423, 69, 800017424 }));
        }




        static int SumOfList(int[] numList)
        {
            var sum = 0;
            for(int i = 0; i < numList.Length; i++)
            {
                sum = sum + numList[i];
            }

            return sum;
        }



        static void SwapOrderOfList(string[] list)
        {

            for (int i = list.Length; i-- > 0;)
            {
                Console.Write(list[i] + ", " );
            }

        }



        static (long, long) MaxAndMinItemInList(long[] numList)
        {
            var max = numList.Max();

            var min = numList.Min();

            return (min, max);
        }
        




    }
}
