using System;

namespace _07._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Car cr1 = new Car() {
              Brand="Mercedes",
              Model="Amg 1995",
              Millage=280,
              FuelCapacity=66
          };
            cr1.ShowInfo();

          Bicycle byc1 = new Bicycle()
          {
              Brand = "Ancheer",
              Model = "Lectric",
              Millage = 100
          };
            byc1.ShowInfo();

            Console.WriteLine("Tarixi daxil edin:");

            string datee = Console.ReadLine();
            DateTime date=Convert.ToDateTime(datee);

            Console.WriteLine(date.ToString("dd-MM-yyy"));

            string yearadd = Console.ReadLine();
            int adyr = Convert.ToInt32(yearadd);
            date = date.AddYears(adyr);

            Console.WriteLine(date.ToString("dd-MM-yyy"));
        }
    }
}
