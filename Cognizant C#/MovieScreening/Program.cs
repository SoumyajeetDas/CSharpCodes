using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieScreening
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Movie movie = new Movie();
            MovieScreening movieOperations = new MovieScreening();

            string loopInput = string.Empty;
        
           

            do
            {
                Console.Write("Menu\n\n1. Add Movie" +
                "\n2. Display Movies By Highest Viewers Rating" +
                "\n3. Search Movies By Title's First Letter\n\nEnter your choice (1-3) : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Add Movie Details\n\n");
                        Console.Write("Title : ");
                        movie.Title = Console.ReadLine();
                        Console.Write("Duration(In Hrs) : ");
                        movie.Duration = float.Parse(Console.ReadLine());
                        Console.Write("Rating(1-5) : ");
                        movie.Rating = int.Parse(Console.ReadLine());

                        //Fill your code here                       
                        //   MovieScreening ms = new MovieScreening();
                        if (movieOperations.AddMovie(movie))
                        {
                            Console.WriteLine("Movie Details Successfully Added to the Database");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Add Movie Details");
                        }

                        break;

                    case 2:

                        Console.WriteLine("\nDisplay Movies By Highest Viewers' Rating\n");

                        //Fill your code here
                        IList<Movie>il1 = movieOperations.DisplayMoviesByHighestRating();
                        if (il1.Count == 0)
                        {
                            Console.WriteLine("No Records Found");
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-30}{3}", "Movie Id", "Title", "Duration(In Hrs)", "Rating"));
                            foreach (var x in il1)
                            {
                                Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-30}{3}", x.Id, x.Title, x.Duration, x.Rating));
                            }
                        }



                        break;

                    case 3:
                        Console.Write("\nSearch Movies By First Letter : ");

                        string firstLetter = Console.ReadLine();

                        //Fill your code here
                        IList<Movie> il = movieOperations.SearchMoviesByStartLetter(firstLetter);
                        if (il.Count == 0)
                        {
                            Console.WriteLine("No Records Found");
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-30}{3}", "Movie Id", "Title", "Duration(In Hrs)", "Rating"));
                            foreach (var x in il)
                            {
                                Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-30}{3}", x.Id, x.Title, x.Duration, x.Rating));
                            }
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
                Console.Write("\nDo You Want To Continue (Yes|No)? : ");
                loopInput = Console.ReadLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            Console.ReadKey();
        }
    }
}
