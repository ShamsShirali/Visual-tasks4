using System;
using System.Globalization;
using System.Threading;

namespace _01._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm,
            //arrayim dəyişilməli və arrayin  içində əvəlki elementləri, əlavə olaraq son indexində isə 5 elementi olmalıdır və arrayin uzunluğu 1 vahid artmış olmalıdır.
            //(metod geriye dəyər qaytarmır)
            int[] nums = { 4, 5, 6, 7};
            Addnum(ref nums,10);

            for (int i = 0; i < nums.Length; i++)
            {

                Console.WriteLine(nums[i]);
            }

            //Verilmiş yazıda rəqəm olub olmadığını tapan metod.Göndərilən yazıda rəqəm varsa true yoxdursa false qaytarır.
            string words = "4 cu bolgeye gedilmelidir";
            var task=Digits(words);
            Console.WriteLine(task);

            // Verilmiş yazıdaki sözlərin sayanı tapan metod.Boşluqla bir birindən ayrılmış bütün ifadələri söz kimi qəbul edin.
            // Və hər söz arasında bir boşluq varmış kimi hesab edin.
            string wordd = "Salam Necesen dostum";
            int count = 0;
            var words1=wordd.Split(' ');
            for(int i=0;i<words1.Length;i++)
            {
                count++;
                Console.WriteLine(words1[i]);
            }
            Console.WriteLine(count);
        }

        static void Addnum(ref int[] numbers,int num) {
           int[] newnum =new int[numbers.Length+1];    
                for(int i=0;i<numbers.Length;i++) {
                newnum[i] = numbers[i];

                }
            newnum[newnum.Length-1] = num;

            numbers=newnum;
        }

        static bool Digits(string word)
        {
            for (int i = 0; i <word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    return true;
                }

               
            }
            return false;
        }

        
    }
}
