using System;
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
            userCity = (userCity == "Renton") ? "AllCities" : userCity;
            dynamic method;

            try
            {
                method = typeof(ProcessingService)
                         .GetMethod(userCity);
                      method.Invoke(null, new object[] {userCity});

                cityService _cityService = new cityService(method);
                Console.WriteLine(_cityService + "has been updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }


    }
}
