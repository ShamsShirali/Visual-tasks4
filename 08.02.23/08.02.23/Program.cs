using System;

namespace _08._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                FullName = "Shirali Shams",
                Salary=10000
            };

            Console.WriteLine(emp1.Salary);

            Engineer eng1 = new Engineer()
            {
                FullName = "Hacizade Elisafa",
                Salary = 2000
            };

            Console.WriteLine(eng1.Salary);

            Engineer eng2 = new Engineer()
            {
                FullName = "Shirali Shams",
                Salary = 10000
            };

            Engineer eng3 = new Engineer()
            {
                FullName = "Eliyeva Ayten",
                Salary = 1200
            };

            Console.WriteLine("Maas ortalamasi:");

            double[] engineer = { eng1.Salary, eng2.Salary, eng3.Salary};

            double sum = 0;
            double result;

            for(int i=0;i<engineer.Length;i++)
            {
                sum+= engineer[i];

            }
            result= sum/engineer.Length;

            Console.WriteLine(result);
        }
    }
}
