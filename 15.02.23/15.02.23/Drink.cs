using System;
using System.Collections.Generic;
using System.Text;

namespace _15._02._23
{
    internal class Drink:Product
    {
        private double _alcoholPercent;

        public double AlcoholPercent
        {
            get
            {
                return _alcoholPercent;
            }
            set
            {
                if (value <= 40)
                {
                    _alcoholPercent = value;
                }
            }
        }

    }
}
