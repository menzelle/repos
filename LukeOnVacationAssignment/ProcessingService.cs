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
        public static int RandomNum()
        {
            Random randomNum = new Random();
            return randomNum.Next();

            //return randomNum.ToString();
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
            System.IO.File.AppendAllText(filepath + filename, RandomNum().ToString() + Environment.NewLine);
            if (_city.ToUpper()=="PASCO")
            {
                return filename;
            }
            else
            {
                Console.WriteLine(filename + " file has been created.");
                return filename;

            }
        }

        public static string Pasco(string city)
        {
            
            string filepath = @"C:\Temp\";
            var filename = AllCities(city);
            string content = RandomNum().ToString() + "Pasco";
            Console.WriteLine("Reopening file.");
            System.IO.File.AppendAllText(filepath + filename, content);
            Console.WriteLine(filename + " file has been updated.");
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

            System.IO.File.AppendAllText(filepath + filename, RandomNum().ToString());

            return filename;
        }

        
    }
}
