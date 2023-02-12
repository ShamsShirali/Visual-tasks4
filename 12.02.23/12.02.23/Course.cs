using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace _12._02._23
{
    internal class Course
    {
        public Group[] Groups = new Group[0];
      
        public void AddGroup(Group group)
        {
            Array.Resize(ref Groups,Groups.Length+1);
            Groups[Groups.Length - 1] = group;
        }

        public void GetGroupByNo(string no)
        {
            for(int i=0;i<Groups.Length;i++)
            {
                if (Groups[i].No==no)
                {
                    Console.WriteLine($"\n{i+1}-ci qrup:");
                    Console.WriteLine(Groups[i].No);
                    Console.WriteLine(Groups[i].AvgPoint);
                }
            }
        }


        public void GetGroupsByPointRange(int minPoint,int maxPoint)
        {
            for(int i=0;i<Groups.Length;i++)
            {
                if (Groups[i].AvgPoint >=minPoint && Groups[i].AvgPoint<=maxPoint)
                {
                    Console.WriteLine($"\n{i+1}-ci qrup:");
                    Console.WriteLine(Groups[i].No);
                    Console.WriteLine(Groups[i].AvgPoint);
                }
            }
        }


        public void Search(string str)
        {
            for(int i=0;i< Groups.Length;i++)
            {
                if (Groups[i].No.Contains(str))
                {
                    Console.WriteLine(Groups[i].No);
                }
            }
        }

    }
}
