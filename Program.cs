using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
         //Emily L
            Console.WriteLine("EEEEE");
            Console.WriteLine("E");
            Console.WriteLine("E");
            Console.WriteLine("EEE");
            Console.WriteLine("E");
            Console.WriteLine("E");
            Console.WriteLine("EEEEE");
            Console.WriteLine();
            Console.WriteLine("L");
            Console.WriteLine("L");
            Console.WriteLine("L");
            Console.WriteLine("L");
            Console.WriteLine("L");
            Console.WriteLine("L");
            Console.WriteLine("LLLLL");
            Console.WriteLine();

            string firstName = "Emily";
            string favMovie = "The Matrix";
            Console.WriteLine($"Hello, my name is {firstName} and my favourite movie is {favMovie}");
            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine(favMovie.Contains("THE"));
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);
        }
    }
}
