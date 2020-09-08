using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 5));
            
        }


        private static int Add(int num1, int num2)
        {
            
            var sum = num1 + num2;

            return sum;
        }
        

        }
    }    
