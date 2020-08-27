using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name hemmis");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your age ");
            var age = Console.ReadLine();

            Console.WriteLine("Are you alive or dead? But really though.");
            var aliveOrDead = Console.ReadLine();

            Console.WriteLine("What's your favorite nummer?");
            int favoriteNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + name + ", you're " + age + " years old, and you're " + aliveOrDead + ". And my favorite number is " + Math.Pow(favoriteNum, 2) + " which happens " +
                "to be your favorite number raised to the power of 2.");
            
        }
    }
}
