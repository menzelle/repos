using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = { "Name: Felica Walker", "Title: Mz.",
                   "Age: 47", "Location: Paris", "Gender: F"};
            int pointer = 0;

            Console.WriteLine("The initial values in the array are:");
            foreach (string s in info)
                Console.WriteLine(s);

            Console.WriteLine("\nWe want to retrieve only the key information. That is:");
            foreach (string s in info)
            {
                pointer = s.IndexOf(": ");
                Console.WriteLine( s.Substring(pointer + 2));
            }
            Console.ReadLine();


        }
    }
    
}
