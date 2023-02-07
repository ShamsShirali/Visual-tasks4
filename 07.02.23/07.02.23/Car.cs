using System;
using System.Collections.Generic;
using System.Text;

namespace _07._02._23
{
    internal class Car:Vehicle
    {

        public double FuelCapacity;

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("FuelCapacity: "+FuelCapacity);
        }
    }
}
