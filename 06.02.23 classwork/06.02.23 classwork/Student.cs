using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _06._02._23_classwork
{
    internal class Student
    {
        public Student(byte point)
        {
            Console.WriteLine("Student was created:");
            Point = point;
        }
        public string Fullname;
        public string GroupNo;
        public byte Point;

        public bool IsPassed() 
        { 
            if(Point>=65)
            {
                return true;
            }
            return false;
        }  

    }

   
}
