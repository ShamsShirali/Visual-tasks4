using System;

namespace _30._01._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş iki ədədi toplayıb qaytaran metod
            var task1 = Plus(5,10);
            Console.WriteLine(task1);

            //Verilmiş ədədlər siyahısındaki ədədlərini cəmini qaytaran metod
            int[] numbers = { 21, 12, 22, 2 };
            var task2 = Plus1(numbers);
            Console.WriteLine(task2);

            //Verilmiş ədədlər siyahısındaki ən böyük ədədi qaytaran metod
            int[] nums = { 47, 98, 102, 20, 30 };
            var task3 = Bignum(nums);
            Console.WriteLine(task3);

            //Verilmiş 3 ədəddən ən böyüyünü tapan proqram
            var task4 = Bignum1(43,2456,12);
            Console.WriteLine(task4);

            //Verilmiş yazını əks şəkildə qaytaran metod
            var task5 = Opposite("Code");
            Console.WriteLine(task5);

            //Verilmiş ədədin rəqəmləri cəmini qaytaran metod
            var task6 = Sum(526);
            Console.WriteLine(task6);
        }

        static int Plus(int num1,int num2)
        {
            int result=num1+ num2; 
            return result;
        }

        static int Plus1(int[] numbers)
        {
            int sum = 0;

            for(int i=0;i<numbers.Length;i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static int Bignum(int[] nums) {
            int max = nums[0];

            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        static int Bignum1(int num1,int num2,int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }
        }

        static string Opposite(string names)
        {
            string newname = "";

            for(int i = names.Length - 1; i >= 0; i--)
            {
                newname += names[i];
            }
            return newname;
        }

        static int Sum(int num)
        {
            int sum = 0;
      
            while(num > 0)
            {
                sum+=(num % 10);
                num=num/ 10;

                
            }
            return sum;
        }
    }
}
