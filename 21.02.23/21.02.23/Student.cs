using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _21._02._23
{
    internal class Student
    {
        public string FullName;
        public string Group;
        public List<Exam> Exams=new List<Exam>();

        public List<Exam> GetExamsByPointRange(double minPoint,double maxPoint)
        {
            List<Exam> newExam= new List<Exam>();

            foreach(var item in Exams)
            {
                if(item.Point>=minPoint && item.Point<=maxPoint)
                {
                    newExam.Add(item);
                }
            }
            return newExam;
        }

        public List<Exam> GetExamsByDateRange(DateTime fromdate,DateTime todate)
        {
            List<Exam> newExam= new List<Exam>();

            foreach(var item in Exams)
            {
                if(item.StartAt>=fromdate && item.StartAt <= todate)
                {
                    newExam.Add(item) ;
                }
            }
            return newExam;
        }

        public double GetAvgPoint()
        {
            double sum = 0;

            foreach(var item in Exams)
            {
                sum += item.Point;
            }
            return sum/Exams.Count;
        }

        public double GetTotalExamMinutes()
        {
            double summinutes = 0;

            foreach(var item in Exams)
            {
                var differen = item.FinishAt - item.StartAt;
                summinutes += differen.TotalMinutes;
            }
            return summinutes;
        }
    }
}
