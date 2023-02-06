using System;

namespace _01._02._23_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmis yazidaki ilk boslugun indexini tapan metod
            var task1 = Firstspace("Salam necesen");
            Console.WriteLine(task1);

            //verilmis yazinin evvelindeki bosluqlari silib qaytaran metod
            var task2 = Deletespace("   Salam necesen");
            Console.WriteLine(task2);

            //verilmis yazinin ilk bosluq olmayan indexini tapan metod
            var task3 = Deletefirst("   Salam necesen");
            Console.WriteLine(task3);

            //verilmis ededler siyahisindan yalniz musbet ededlerden ibaret yeni bir array duzeldib qaytaran metod
            int[] numbers = { -25, 126, 42, -5678, 45, 2 };
            var task4 = Positivearr(numbers);

            //verilmis eded menfidirse musbet musbetdirse menfi eden metod
            int num = 20;
            Change(ref num);
            Console.WriteLine(num);

            //verilmis yazinin icindeki butun bosluqlari silen metod
            string text = "  Salam necesen  ";
            Delete(ref text);
            Console.WriteLine(text);
        }

        static int Firstspace(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    return i;
                }
            }
            return -1;
        }

        static string Deletespace(string text)
        {
            string newtext = "";

            var firstindex=Deletefirst(text);

            if(firstindex == -1)
            {
                return newtext;
            }

            for (int i = firstindex; i < text.Length; i++)
            {
               newtext+= text[i];
            }
            return newtext;
        }

        static int Deletefirst(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]!=' ')
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] Positivearr(int[] numbers)
        {
            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    count++;
                }
            }

            int[] newnumbers=new int[count];

            int j = 0;

            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i] > 0)
                {
                    newnumbers[j] = numbers[i];
                    j++;
                }
            }
            return newnumbers;

        }


        static void Change(ref int num)
        {
            num *= -1;
        }


        static void Delete(ref string text)
        {
            string newtext = "";

            for(int i=0;i<text.Length;i++)
            {
                if (text[i] != ' ')
                {
                    newtext+= text[i];
                }
            }

            text = newtext;
        }
    }
}
