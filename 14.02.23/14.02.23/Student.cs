using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _14._02._23
{
    internal class Student
    {
        private string _fullname;
        private string _groupNo;
        public int Age;

        public string GroupNo
        {
            get 
            {
                return _groupNo; 
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo != null && char.IsLetter(groupNo[0]) && char.IsUpper(groupNo[0]) && char.IsDigit(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]))
            {
                return true;
            }
          return false;
        }

        
        public string Fullname
        {
            get 
            { 
                return _fullname; 
            }
            set
            {
                if(CheckFullname(value))
                {
                    _fullname = value;
                }
            }
        }

        public bool CheckFullname(string fullname)
        {
            if (fullname == null)
            {
                return false;
            }

            if(fullname.StartsWith(' ') || fullname.EndsWith(' ')) 
            {
                return false;
            }
            string name=Console.ReadLine();
            string surname=Console.ReadLine();

            if (char.IsUpper(name[0]) && char.IsUpper(surname[0]) && fullname==name+" "+surname)
            {
                fullname=name+" "+surname;
                return true;
            }
            return false;
        }

    }
}
