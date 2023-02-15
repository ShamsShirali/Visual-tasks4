using System;

namespace _15._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store meal = new Store();

            meal.AddProduct(new Drink());
            meal.AddProduct(new Dairy());
            meal.AddProduct(new Drink());
            meal.AddProduct(new Drink());

            Console.WriteLine(meal.HasProductByNo(1));
            Console.WriteLine(meal.GetDairyProducts());
            Console.WriteLine(meal.GetDrinkProducts());
            
        }
    }
}
