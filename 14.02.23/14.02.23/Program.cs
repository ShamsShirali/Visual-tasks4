using System;

namespace _14._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExtentionMethods.IsOdd(7));

            Console.WriteLine(ExtentionMethods.IsEven(6));

            Console.WriteLine(ExtentionMethods.IsContainsDigit("Elis2afa"));

            Console.WriteLine(ExtentionMethods.ToCapitalize("eliSAFA"));

            var arr=ExtentionMethods.GetValueIndexes("Elisafa",'a');

            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

            Student std = new Student();
            string no;
            do
            {
                Console.WriteLine("GroupNo daxil edin:");
                no = Console.ReadLine();
            }
            while (!std.CheckGroupNo(no));

            string fullname;  
            do
            {
                Console.WriteLine("Fullname-i daxil edin:");
                fullname = Console.ReadLine();
            }
            while(!std.CheckFullname(fullname));

            Console.WriteLine(no);
            Console.WriteLine(fullname);
        }
    }
}
