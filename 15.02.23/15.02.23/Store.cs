using System;
using System.Collections.Generic;
using System.Text;

namespace _15._02._23
{
    internal class Store
    {
        public Product[] Products=new Product[0];

        public int DairyProductCountLimit()
        {
            int count = 0;

            for(int i=0;i<Products.Length;i++)
            {
                if (Products[i] is Dairy)
                {
                    count++;
                }
            }
            return count;
        }
        public double AlcoholPercentLimit()
        {
            int max;

            if (Products[0] is Drink)
            {
                max = Products[0].AlcoholPercent;

                for (int i = 1; i < Products.Length; i++)
                {
                    if (Products[i] is Drink)
                    {
                        if (Products[i].AlcoholPercent > max)
                        {
                            max = Products[i].AlcoholPercent;
                        }
                    }
                }
            }
            return max;
        }

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products,Products.Length+1);
            Products[Products.Length-1] = product;
        }

        public bool HasProductByNo(int no)
        {
            for(int i=0;i<Products.Length;i++)
            {
                if (Products[i].No== no)
                {
                    return true;
                }
            }
            return false;
        }

        public Drink[] GetDrinkProducts()
        {
            Drink[] drink = new Drink[0];

            for(int i=0;i<Products.Length;i++) 
            {
                if (Products[i] is Drink)
                {
                    Array.Resize(ref drink, drink.Length + 1);
                    drink[drink.Length - 1] =(Products[i] as Drink);
                }
            }
            return drink;
        }

        public Dairy[] GetDairyProducts()
        {
            Dairy[] dairy = new Dairy[0];

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Dairy)
                {
                    Array.Resize(ref dairy, dairy.Length + 1);
                    dairy[dairy.Length - 1] = (Products[i] as Dairy);
                }
            }

            return dairy;
        }
    }
}
