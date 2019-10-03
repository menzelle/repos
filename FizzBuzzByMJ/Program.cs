using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FizzBuzzByMJ
{
    class Program
    {
        static void Main(string[] args)
        {
            var runTheMath = new MathMethods();
           
            for (int i = 1; i < 101; i++)
            {
                
                switch (runTheMath.MathMethod(i))
                {
                    case "3":
                        Console.WriteLine("Fizz");
                        break;
                    case "5":
                        Console.WriteLine("Buzz");
                        break;
                    case "3 & 5":
                        Console.WriteLine("FizzBuzz");
                        break;
                    case "false":
                        Console.WriteLine(i);
                        break;
                }
            }
               
            Console.ReadLine();
        }

    }
}
