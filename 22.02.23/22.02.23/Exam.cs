using System;
using System.Collections.Generic;
using System.Text;

namespace _22._02._23
{
    internal class Exam
    {
        public string Subject;
        public DateTime StartedAt;
        public DateTime FinishedAt;

        List<Exam> Exams = new List<Exam>();

        public int GetCountExams()
        {
            int count = 0;

            foreach (var item in Exams)
            {
                var total = item.FinishedAt - item.StartedAt;

                if (total.TotalHours < 2)
                {
                    count++;
                }
            }
            return count;
        }

        public void GetSubStar()
        {
            foreach(var item in Exams)
            {
                if (item.StartedAt >= DateTime.Now && item.StartedAt <=DateTime.Now.AddHours(24))
                {
                    Console.WriteLine(item.Subject);
                    Console.WriteLine(item.StartedAt);
                }
            }
        }

        public DateTime GetStartData()
        {
            foreach(var item in Exams)
            {
                if (item.StartedAt >= DateTime.Today && item.StartedAt <=DateTime.Today.AddHours(24) )
                {
                    return item.StartedAt;
                }
            }
            return DateTime.Now;
        }

        public bool LastYearProgram()
        {
            foreach(var item in Exams)
            {
                if (item.Subject == "Programming")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
