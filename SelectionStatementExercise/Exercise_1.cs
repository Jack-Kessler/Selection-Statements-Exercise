using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementExercise
{
    internal class Exercise_1
    {
        public static void FavoriteNumber()
        {
            var r = new Random();
            var favNumber = r.Next(1, 20);
            

            int i = 0;
            for (i = 0; i < 1; i++)
            {
                Console.WriteLine("What do you think my favorite number is?");
                var userInput = int.Parse(Console.ReadLine());
                if (userInput < favNumber)
                {
                    Console.WriteLine("You're guess was too low. Try again.");
                    i = -1;
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("You're guess was too high. Try again.");
                    i = -1;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                
            }

        }
    }
}
