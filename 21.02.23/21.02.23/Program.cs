using System;
using System.Collections.Generic;

namespace _21._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fromdate = new DateTime(2023, 2, 12, 12, 30, 0);
            DateTime todate = new DateTime(2023, 24, 12, 12, 30, 0);

            var differen = todate - fromdate;

            Console.WriteLine(differen);
            Console.WriteLine(differen.Days);
            Console.WriteLine(differen.Hours);
            Console.WriteLine(differen.Minutes);

            Console.WriteLine(differen.TotalDays);
            Console.WriteLine(differen.TotalMinutes);
            Console.WriteLine(differen.TotalHours);

            Student std=new Student();

            std.Exams.Add(new Exam { Point=55,StartAt=new DateTime(23,12,12,12,0,0),FinishAt=new DateTime(23,23,12,12,0,0)});
            std.Exams.Add(new Exam { Point = 55, StartAt = new DateTime(23,13,9,12, 0, 0), FinishAt = new DateTime(23,12, 10, 12, 0, 0) });

            Console.WriteLine(std.GetTotalExamMinutes());

            Dictionary<string,double> products= new Dictionary<string,double>();

            string secin;
            do
            {
                Console.WriteLine("1.Mehsul elave edin: ");
                Console.WriteLine("2.Butun mehsullara baxin:");
                Console.WriteLine("3.Secilmis mehsula baxin:");
                Console.WriteLine("0.Cixin!");

                Console.WriteLine("Seciminizi yazin:");
                secin = Console.ReadLine();

                switch (secin)
                {
                    case "1":
                        Console.WriteLine("Product name: ");
                        string name= Console.ReadLine();

                        if (products.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} adli metod elave edilib");
                        }
                        break;
                    case "2":
                        foreach (var item in products)
                        {
                            Console.WriteLine(item.Key+"-"+item.Value);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Product name:");
                        name=Console.ReadLine();

                        if (!products.ContainsKey(name))
                        {
                            Console.WriteLine("Mehsul adi yoxdur.Yeni mehsul elave etmek isteyirsiniz? y/n");
                            string choose= Console.ReadLine();

                            if (choose =="y")
                            {
                                goto case "1";
                            }
                        }
                        Console.WriteLine(name + "-" + products[name]);
                        break;
                    case "0":
                        Console.WriteLine("Menudan cixin!");
                        break;
                    default:
                        Console.WriteLine("Secim yoxdur!");
                        break;

                }
            }
            while (secin != "0");
        }
    }
}
