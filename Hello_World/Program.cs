using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define all variables
            string favMovie = "Star Wars Episode III Revenge of the Sith".ToUpper();
            string firstName = "Brady Fodor";
            string greetings;
            

            Console.WriteLine("BBBB   FFFFF" );
            Console.WriteLine("B   B  F"     );
            Console.WriteLine("B   B  F"     );
            Console.WriteLine("BBBB   FFF"   );
            Console.WriteLine("B   B  F"     );
            Console.WriteLine("B   B  F"     );
            Console.WriteLine("BBBB   F"     );

            //Greetings
            greetings = ($"Greetings {firstName}, I hope you are having a great day".ToLower());
            Console.WriteLine(greetings);
            Console.WriteLine($"Your favourite movie is {favMovie}.");
            //Space
            Console.WriteLine();

            //Movie Contains 'the', add space after
            favMovie.Contains("the");
            Console.WriteLine();

            //Convert characters and reprint
            greetings = greetings.Replace("a", "@");
            greetings = greetings.Replace("e", "3");
            Console.WriteLine(greetings);

            //There so the user can read it
            Console.ReadLine();
           
        }
    }
}
