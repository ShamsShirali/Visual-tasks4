using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace _31._01._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmis ededler siyahisindaki musbet ededlerin cemini tapan metod
            int[] numbers = new int[5] { 25, -12, 121, -54, 5 };
            var task1=Sum(numbers);
            Console.WriteLine(task1);

            //verilmis ededi verilmis quvvete yukselden metod
            var task2 = Power(4, 2);
            Console.WriteLine(task2);

            var task3=Power(4.2, 3);
            Console.WriteLine(task3);

            //verilmis yazida a charinin sayini tapan metod
            var task4 = Symbol("azerbaycan");
            Console.WriteLine(task4);

            //verilmis yazida a charinin olub olmadigini tapan metod
            var task5 = Symbol1("azerbaycan");
            Console.WriteLine(task5);

            //verilmis yazida verilmis char-in sayini tapan metod
            var task6 = Num("ekskalator", 'k');
            Console.WriteLine(task6);

            //verilmis ededler siyahisinda verilmis ededin yerlesdiyi ilk indexi axtaran metod
            int[] nums = new int[5] { 123, -34, 89, 47, 34 };
            var task7 = Findnum(nums, 34);
            Console.WriteLine(task7);

            if (task7 == -1)
            {
                Console.WriteLine("Axtarilan deyer yoxdur!");
            }
            else
            {
                Console.WriteLine($"Axtarilan deyer {task7}ci indexde yerlesir");
            }

            //verilmis yazidaki ilk sozu (ilk bosluga qeder olan hisseni) qaytaran metod
            var task8 = Firstword("Calisan her zaman ugur elde eder!");
            Console.WriteLine(task8);

            //verilmis yazinin evvelindeki bosluqlari silib qaytaran metod
            var task9 = Deletespac("   Yalniz guclu olmagi oyrenin!");
            Console.WriteLine(task9);

            //verilmis ededler siyahisindan yalniz musbet ededler qalan yeni bir siyahi duzelden metod
            int[] num = new int[] { 23, -7, 14, 23, -1234 };
            
            var task10 = Schedule(num);

            for(int i = 0; i < task10.Length; i++)
            {
                if (task10[i] != 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
            
        }

        static int Sum(int[] nums)
        {
            int sum = 0;

            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i] > 0)
                {
                    sum += nums[i];
                }
                
            }
            return sum;
        }


        static int Power(int num,int pow) {
            int result = 1;

            for(int i=0;i<pow;i++)
            {
                result *= num;
            }

            return result;
        }

        static double Power(double num, int pow)
        {
            double result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }

        static int Symbol(string text)
        {
            int count = 0;
            for(int i=0;i< text.Length;i++)
            {
                if (text[i] == 'a')
                {
                    count++;
                }
            }
            return count;
        }

        static bool Symbol1(string text)
        {
            

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {

                    return true;
                }

            }
            return false;
        }

        static int Num(string name,char letter)
        {
            int count = 0;

            for(int i=0;i<name.Length;i++)
            {
                if (name[i] == letter)
                {
                    count++;
                }
            }

            return count;
        }

        static int Findnum(int[] number,int num)
        {
            for(int i=0;i<number.Length;i++)
            {
                if (number[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }

        static string Firstword(string text) {
            string neww= "";

            for(int i=0;i<text.Length;i++)
            {
                if (text[i] == ' ')
                {
                  break;
                }

                neww += text[i];
            }

            return neww;
        }

        static string Deletespac(string text)
        {
            string newwithout = "";

            for(int i = 0;i<text.Length; i++)
            {
                if (text[i] == ' ')
                {
                  continue;
                }
                
                while (i < text.Length)
                {
                    newwithout += text[i];
                    i++;
                }
            }

           
           return newwithout;
        }

        static int[] Schedule(int[] numbers)
        {
            
            int[] newnum = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    newnum[i] = numbers[i];
                    
                }
            }

            return newnum;
        }
    }
}
