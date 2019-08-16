using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;

namespace LukeOnVacationAssignment
{
    delegate string cityService(string city);

    class ProcessingService
    {
        public static string RandomNum()
        {
            Random randomNum = new Random();
            return randomNum.ToString();
        }

        public static string AllCities(string city)
        {
            string _city = city;
            string today = DateTime.Today.ToString("MM-dd-yy");
            string filename = city+"_"+today+".txt";
            string filepath = @"C:\Temp\";
         
                if (!Directory.Exists(filepath))
                {
                Console.WriteLine("Creating Folder...");
                Directory.CreateDirectory(filepath);
                }

            Console.WriteLine("Writing to file...");
            System.IO.File.WriteAllText(filepath + filename, RandomNum());
            Console.WriteLine(filename + " file has been created.");
            Console.ReadLine();
            return filename;
        }

        public static string Pasco(string city)
        {
            
            string filepath = @"C:\Temp\";
            var filename = AllCities(city);
            Console.WriteLine("Writing to file...");
            System.IO.File.AppendAllText(filepath + filename, RandomNum()+" Pasco");
            Console.WriteLine(filename + " file has been created.");
            return filename;
        }

        public static string Seatac(string city)
        {
            string filepath = @"C:\Temp\";
            string filename = "Random.txt";


            if (!Directory.Exists(filepath))
            {
                Console.WriteLine("Creating Folder...");
                Directory.CreateDirectory(filepath);
            }

            System.IO.File.AppendAllText(filepath + filename, RandomNum());

            return filename;
        }

        
    }
}
