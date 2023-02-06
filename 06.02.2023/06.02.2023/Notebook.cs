using System;
using System.Collections.Generic;
using System.Text;

namespace _06._02._2023
{
    internal class Notebook
    {
       
            public Notebook(string brand, string model)
            {
                Console.WriteLine("Notebook yaradildi:");
                Brand = brand;
                Model = model;
            }


            public string Brand;
            public string Model;
            public int Price;

            public void ShowInfo()
            {
                Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price}");



            }
        
    }
}
