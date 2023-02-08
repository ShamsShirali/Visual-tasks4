using System;
using System.Collections.Generic;
using System.Text;

namespace _08._02._23
{
    internal class Employee
    {
        public string FullName;
        protected double _salary;

        public virtual double Salary
        {
           
              get {

                return _salary;
              }
              set
              {
                if (value>=300) {
                    _salary = value;

                }
              }
     }
    }
}
