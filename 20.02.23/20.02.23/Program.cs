using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace _20._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arlis=new ArrayList();

            arlis.Add("Shams");
            arlis.Add(19);
            arlis.Add('A');
            arlis.Add("P138");
            arlis.Add(25);

            arlis.Remove("P138");
            arlis.RemoveAt(1);
            arlis.Clear();

            arlis.Add(252);
            arlis.Add("Code");
            arlis.Add('L');

            arlis.RemoveRange(1, 2);
            arlis.Insert(1,"Code");
            arlis.Contains("Code");

            foreach (var item in arlis)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------QUEUE-------");

           Queue qen= new Queue();

            qen.Enqueue(15);
            qen.Enqueue("Elisafa");
            qen.Enqueue('I');
            qen.Enqueue(124);

            qen.Dequeue();
            qen.Peek();

            foreach (var item in qen)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------Stack------");

            Stack stc= new Stack();

            stc.Push("Hacizade");
            stc.Push(605.21);
            stc.Push('S');
            stc.Push(21);

            stc.Pop();
            stc.Peek();

            foreach (var item in stc)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");

            arlis.AddRange(stc);

            foreach (var item in arlis)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------");

            SortedList srtlist= new SortedList();

            srtlist.Add("Shams",88);
            srtlist.Add("Zehra", 77);
            srtlist.Add("Safa", 99);

            Console.WriteLine(srtlist["Zehra"]);

            Console.WriteLine("---------------");

            List<int> lst=new List<int>();

            lst.Add(35);
            lst.Add(22);

            var num=lst[1];
            lst.RemoveRange(0, 1);

            Console.WriteLine(num);

            Console.WriteLine("------------------");

            SortedList<string,double> srtlistt=new SortedList<string,double>();

            srtlistt.Add("Sokoladli sud", 2.50);
            srtlistt.Add("Tort", 50);

           foreach(var item in srtlistt)
            {
                Console.WriteLine(item.Key+"-"+item.Value);
            }

            Console.WriteLine("---------------");

            Dictionary<int,string> dct=new Dictionary<int,string>();

            dct.Add(12, "Shams");
            dct.Add(14, "Zehra");

            Console.WriteLine(dct[14]);

            Console.WriteLine(dct.ContainsKey(12));

            int no;
            do {
                Console.WriteLine("Student no: ");
                no = Convert.ToInt32(Console.ReadLine());
            }
            while (dct.ContainsKey(no));

            Console.WriteLine("Student name: ");
            string name=Console.ReadLine();

            dct.Add(no,name);

            foreach(var item in dct)
            {
                Console.WriteLine(item.Key+"-"+item.Value);
            }

            dct.TryAdd(no,name);
        }
    }
}
