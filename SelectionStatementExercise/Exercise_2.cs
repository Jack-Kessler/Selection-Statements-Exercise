using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementExercise
{
    internal class Exercise_2
    {
        public static void FavoriteSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSub = Console.ReadLine();
            favoriteSub = favoriteSub.ToLower();
            switch (favoriteSub)
            {
                case ("math"):
                    Console.WriteLine("Your favorite subject is math?! You're crazy.");
                    break;
                case ("science"):
                    Console.WriteLine("Science??? Yuck, gross.");
                    break;
                case ("social studies"):
                    Console.WriteLine("Social Studies is fun!");
                    break;
                case ("english"):
                    Console.WriteLine("English is so hard!");
                    break;
                case ("art"):
                    Console.WriteLine("I was so bad at art!");
                    break;
                default:
                    Console.WriteLine("Did not recognize your response.");
                    break;
            }
        }
    }
}
