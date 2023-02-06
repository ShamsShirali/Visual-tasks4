using System;

namespace _06._02._23_classwork
{
    class Human{
        public string Name;
        public string Surname;
        public byte Age;

        public void GetFullname()
        {
            Console.WriteLine($"Name: {Name} - Surname: {Surname} - Age: {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Human hmn1= new Human() {
               Name="Shams",
               Surname="Shirali",
               Age=19
           };
            hmn1.GetFullname();

            Student std1 = new Student(44)
            {
              Fullname="Sems Sireli",
              GroupNo="P138",
              
            };
            Console.WriteLine(std1.IsPassed()); 
        }
    }
}
