using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Movie> MoviesList = MovieIO.MovieCatalog;
            bool continueOn;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter a Category:/n");
                Console.WriteLine("animated\ndrama\nhorror\nmusical\nscifi");

                string category = Console.ReadLine();
                MoviesList = MoviesList.OrderBy(m => m.Name).ToList();
                foreach (Movie m in MoviesList)
                {
                    if (m.Category == category)
                    {
                        Console.WriteLine($"Title: {m.name}, Category: {m.category}");
                    }
                }

                Console.WriteLine("Continue (Y/N)?");
                string answer = Console.ReadLine().ToLower();
                continueOn = answer == "y" ? true : false;
            } while (continueOn);

        }
    }
}
