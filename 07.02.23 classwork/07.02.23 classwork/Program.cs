using System;

namespace _07._02._23_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1= new Student()
            {
                Fullname="Shams Shirali",
                Age=19,
                Point=85
            };

            std1.ShowInfo();

            Employee emp1 = new Employee()
            {
                Fullname = "Shams Shirali",
                Age = 19,
                Position = "Programmer"
            };

            emp1.ShowInfo();
        }
    }
}
