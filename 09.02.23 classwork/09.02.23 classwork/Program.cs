using System;

namespace _09._02._23_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store str = new Store();

            Product prd= new Product();
            prd.Name = "Sokolad";
            prd.Price= 100;
            prd.DiscountPercent = 30;

            Console.WriteLine(prd.Price);
            Console.WriteLine(prd.Name);


            str.AddProduct(prd);
            str.AddProduct(new Product { Name="Dondurma",Price=30});

            var products = str.GetDiscountProducts();

            products = str.GetProductsByPriceRange(40,220);

            for(int i=0;i<products.Length;i++)
            {
                Console.WriteLine(products[i].Name +" - " + products[i].Price);
            }
        }
    }
}
