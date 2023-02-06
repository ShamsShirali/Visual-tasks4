using System;

namespace _30._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veirlmiş iki ədədi toplayıb console-a yazdıran metod
            Plus(5, 10);

            // Verilmiş ədədlər siyahısındaki ədədlərin cəmini console-a yazdıran metod
            int[] numbers = { 22,12, 21 };
            Sumofnum(numbers);
        }

        static void Plus(int num1,int num2)
        {
            int result=num1+ num2;
            Console.WriteLine(result);
        }

        static void Sumofnum(int[] numbers)
        {
            int sum = 0;

            for(int i=0;i<numbers.Length;i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
