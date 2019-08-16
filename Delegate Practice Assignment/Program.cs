using System;
using System.Collections.Generic;

namespace Delegate_Practice_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which animal would you like to make noise?");

       var AnimalDictionary = new AnimalDictionary();
            var _animalList = AnimalDictionary.AnimalList;

foreach (var item in _animalList)
	{
                Console.WriteLine("{0}");
	}            
                Console.ReadLine();
     
        }
    }
}
