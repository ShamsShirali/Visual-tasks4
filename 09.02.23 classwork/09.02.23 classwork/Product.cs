using System;
using System.Collections.Generic;
using System.Text;

namespace _09._02._23_classwork
{
    internal class Product
    {
        private string _name;
        private double _price;
        public double DiscountPercent;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value>=0)
                {
                    _price = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(CheckName(value))
                {
                    _name= value;
                }
            }
        }

        public bool CheckName(string name)
        {
            if(!string.IsNullOrWhiteSpace(name) && name != null && name.Length > 1 && char.IsUpper(name[0]))
            {
                return true;
            }
            return false;
        }
    }
}
