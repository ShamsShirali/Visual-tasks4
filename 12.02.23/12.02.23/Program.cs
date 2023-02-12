using System;

namespace _12._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Group grp1 = new Group()
            //{
            //    No="P138",
            //    AvgPoint=55
            //};

            //Group grp2 = new Group()
            //{
            //    No="E356",
            //    AvgPoint=91
            //};

            //Group grp3 = new Group()
            //{
            //    No="D279",
            //    AvgPoint =34
            //};

            Course course = new Course();

            string secin;

            do
            {
                Console.WriteLine("\n1.Qrup elave etin:");
                Console.WriteLine("2.Butun qruplara baxin:");
                Console.WriteLine("3.Verilmis point araligindaki qruplara baxin:");
                Console.WriteLine("4.Verilmis nomreli qrupa baxin:");
                Console.WriteLine("5.Verilmis qruplar uzre axtaris edin:");
                Console.WriteLine("0.Menudan cixin(");

                Console.WriteLine("\nSeciminizi daxil edin:");

                secin = Console.ReadLine();

                switch (secin)
                {
                    case "1":
                        Console.WriteLine("\nElave edeceyiniz qrupun daxil edilmesi)");

                        string ch;
                        do
                        {
                            Console.WriteLine("\nElave edeceyiniz qrupun nomresini daxil edin:");
                            string no = Console.ReadLine();

                            Console.WriteLine("\nElave edeceyiniz qrupun orta balini daxil edin:");
                            string average =Console.ReadLine();
                            int avgpoint = Convert.ToInt32(average);

                            Group grp=new Group()
                            {
                                No = no,
                                AvgPoint = avgpoint
                            };

                            course.AddGroup(grp);

                            do
                            {
                                Console.WriteLine("\nQrup elave etmek isteyirsinizmi? y/n");

                                ch = Console.ReadLine();
                            }
                            while (ch != "n" && ch != "y");

                            
                        }
                        while(ch=="y");

                        break;
                    case "2":
                        Console.WriteLine("\nGruplar:");
                        for(int i = 0; i < course.Groups.Length; i++)
                        {
                            Console.WriteLine(course.Groups[i].No);
                            Console.WriteLine(course.Groups[i].AvgPoint);
                        }
                        
                        break;
                    case "3":
                        Console.WriteLine("\nVerilmis point araligindaki qruplar:");

                        string min=Console.ReadLine();
                        int minPoint=Convert.ToInt32(min);

                        string max=Console.ReadLine();
                        int maxPoint=Convert.ToInt32(max);

                        course.GetGroupsByPointRange(minPoint,maxPoint);
                        break;
                    case "4":
                        Console.WriteLine("\nYazini daxil edin:");

                        string str=Console.ReadLine();

                        course.Search(str);
                        break;
                    case "5":
                        Console.WriteLine("\nAxtardiginiz qrupu daxil edin:");

                        string noo=Console.ReadLine();

                        course.GetGroupByNo(noo);
                        break;
                    case "0":
                        Console.WriteLine("\nMenudan cixin(");
                        break;
                    default:
                        Console.WriteLine("\nDaxil etdiyiniz secim tapilmamaqdadir!");
                        break;
                }
            }
            while (secin != "0");
        }
    }
}
