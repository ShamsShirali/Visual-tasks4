using System;
using System.Collections.Generic;
using System.Text;

namespace _07._02._23_classwork
{
    internal class Human
    {
        public string Fullname;
        public int Age;

        public void ShowInfo() {
            Console.WriteLine($"Fullname: {Fullname} - Age: {Age}");
        }
    }
}
