using System;

namespace classtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmis yazidaki ilk boslugun indexini tapan metod
            var task1 = Firstspace("Salam necesen");
            Console.WriteLine(task1);

            //verilmis yazinin evvelindeki bosluqlari silib qaytaran metod
            //verilmis yazinin ilk bosluq olmayan indexini tapan metod
            //verilmis ededler siyahisindan yalniz musbet ededlerden ibaret yeni bir array duzeldib qaytaran metod
            //verilmis eded menfidirse musbet musbetdirse menfi eden metod
            //verilmis yazinin icindeki butun bosluqlari silen metod
            
            Console.WriteLine("Hello World!");
        }

        static int Firstspace(string text)
        {
            for(int i=0;i<text.Length;i++)
            {
                if (text[i]==' ')
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
