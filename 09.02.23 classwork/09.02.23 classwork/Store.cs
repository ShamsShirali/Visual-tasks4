using System;
using System.Collections.Generic;
using System.Text;

namespace _09._02._23_classwork
{
    internal class Store
    {
        public Product[] Products=new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public Product[] GetDiscountProducts()
        {
            Product[] newProducts = new Product[0];

            for (int i=0;i<Products.Length;i++) 
            {

                if (Products[i].DiscountPercent> 0)
                {
                   Array.Resize(ref newProducts,newProducts.Length+1);
                    newProducts[newProducts.Length - 1] = Products[i];
                }
            }
            return newProducts;
        }

        public Product[] GetProductsByPriceRange(int min,int max)
        {
            Product[] newProductss = new Product[0];

            for(int i=0;i<Products.Length;i++)
            {
                if (Products[i].Price>=min && Products[i].Price<=max)
                {
                    Array.Resize(ref newProductss,newProductss.Length+1);
                    newProductss[newProductss.Length-1]= Products[i];
                }
            }

            return newProductss;
        }
    }
}
