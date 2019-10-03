using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace LukeOnVacationAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            
            CityRetrievalService cityRetrievalService = new CityRetrievalService();

            Console.WriteLine("Which city from this list are you from?");
            var allCities = cityRetrievalService.GetCities();

            foreach (var city in allCities)
            {
                Console.WriteLine(city);
            }


            string userCity = Console.ReadLine();
            //TextInfo textCase = CultureInfo.CurrentCulture.TextInfo;
            //textCase.ToTitleCase(userCity);


            //get all static method names to list and ignore the text case
            var methodInfoArray = typeof(ProcessingService).GetMethods(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Static);
            List<string> methodList = new List<string>();

            foreach (var methodInfo in methodInfoArray)
            {
                methodList.Add(methodInfo.Name.ToUpper());
            }


            //change cities with special cases
            userCity = cityRetrievalService.ProcessSpecialCases(userCity);

            //check if the city name is valid and loop if not.
            while (!methodList.Contains(userCity.ToUpper()))
            {
                Console.WriteLine("Please type a valid city");
                userCity = Console.ReadLine();
                userCity = cityRetrievalService.ProcessSpecialCases(userCity);


            }

            //if the city name is valid get the method. 

            if (methodList.Contains(userCity.ToUpper()))
            {
                dynamic method;

                try
                {
                    method = typeof(ProcessingService)
                             .GetMethod(userCity, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Static);
                    method.Invoke(null, new object[] { userCity });

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }


        }


    }
}
