using System;
using System.Collections.Generic;
using System.Text;

namespace _12._02._23
{
    internal class Group
    {
        private string _no;
        public int AvgPoint;

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (char.IsUpper(value[0]) && char.IsLetter(value[0]) && char.IsDigit(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]))
                {
                    _no = value;
                }
            }
        }

       public void ShowInfo()
       {
          Console.WriteLine($"No: {No} - AvgPoint: {AvgPoint}");
       }
    }
}
