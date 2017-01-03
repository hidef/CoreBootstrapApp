using System;
using CoreBootstrapLibrary;

namespace CoreBootstrapApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ICapitaliser capitaliser = new Capitaliser();

            Console.Write("Input: ");

            string input = Console.ReadLine();

            string output = capitaliser.Captialise(input);

            Console.WriteLine($"Capitalised Output: {output}");
        }
    }
}
