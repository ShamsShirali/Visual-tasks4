using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _15._02._23
{
    internal class Product
    {
       
       public static int Count;
        public Product()
        {
            Count++;
            No = Count;
        }

        public int No;
        public string Name;
        public double Price;

        
    }
}
