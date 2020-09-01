using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your name hemmis");
            var name = Console.ReadLine();
            int lengthOfName = name.Length;

            if (lengthOfName >= 69)
            {
                Console.WriteLine("Thats a long fucking name");
            }
            else if (lengthOfName >= 6)
            {
                Console.WriteLine("That's a pretty long name bet it's as long as ur lil toe, haha owned");
            }
            else
            {
                Console.WriteLine("Dayum  thats a short name bet its as short as your DIIIIIIICCCCCCKKKKK HAHAHAHAHAA GOOOOOTEEEEM");
            }

            Console.WriteLine("Enter your age ");
            var age = Convert.ToInt32(Console.ReadLine());
                if(age >= 18)
                {
                    Console.WriteLine("Dayum you lookin real cute today, wanna netflix n chill????");
                }
                else
                {
                    Console.WriteLine("Wtf this shit aint kids friendly grow teh fuk up and come back later");
                }

            Console.WriteLine("Are you alive or dead? Write 1 for alive, 7 for being dead and 69 for being awesome.");
            var aliveOrDead = Convert.ToInt32(Console.ReadLine());

            switch (aliveOrDead)
            {
                case 1:
                    Console.WriteLine("Thats cool, thats cool.");
                    break;

                case 7:
                    Console.WriteLine("Aight fam I feel ya.");
                    break;

                case 69:
                    Console.WriteLine("hehe 69 lmao 420 glaze it broooooo.");
                    break;

                default:
                    Console.WriteLine("Stop being such a rebel puss boi");
                    break;
            }

            int favoriteNum = 0;
            while (favoriteNum != 7) {
            Console.WriteLine("What's your favorite nummer?");
                favoriteNum = Convert.ToInt32(Console.ReadLine());
                if (favoriteNum == 7)
                {
                    Console.WriteLine("Nice number hombre");
                    break;
                }
                else { Console.WriteLine("Is that really your favorite number though? I think it's seven hombre."); }
            }

            Console.WriteLine("Woop woop lets have some more fun and count to your number together!!!!! :DDDDDDD");
            for(int i = 1; i <= favoriteNum; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Your name is " + name + ", you're " + age + " years old, and you're " + aliveOrDead + ". And my favorite number is " + Math.Pow(favoriteNum, 2) + " which happens " +
                "to be your favorite number raised to the power of 2.");
            

        }
    }
}
