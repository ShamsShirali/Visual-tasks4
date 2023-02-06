using System;

namespace _06._02._2023
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook ntb1 = new Notebook("Honor","Macbook")
            {
               
                Price = 2900,
            };

            ntb1.ShowInfo();

            Notebook ntb2 = new Notebook("Hp", "Laptop")
            {

                Price =3400,
            };

            ntb2.ShowInfo();

            Notebook ntb3 = new Notebook("Apple", "Macbook")
            {

                Price = 6500,
            };

            ntb3.ShowInfo();

            int[] notebook = {ntb1.Price,ntb2.Price,ntb3.Price};
            int sum = 0;
            int count = 0;
            int result = 0;

            for(int i=0;i<notebook.Length;i++)
            {
                sum += notebook[i];
                count++;
            }

            result=sum/count;

            Console.WriteLine("\nQiymet ortalamasi:");
            Console.WriteLine(result);
        }
    }
}
