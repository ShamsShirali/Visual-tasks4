using System;
using System.Collections.Generic;

namespace _22._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> ExamList = new List<Exam>();
            ExamList.Add(new Exam { Subject="Math",StartedAt=new DateTime(2023,2,23,9,0,0),FinishedAt=new DateTime(2023,2,23,13,0,0)});
            ExamList.Add(new Exam { Subject = "Programming", StartedAt = new DateTime(2023, 2, 24, 10, 0, 0), FinishedAt = new DateTime(2023, 2, 24, 13, 0, 0) });
            ExamList.Add(new Exam { Subject = "Physics", StartedAt = new DateTime(2023, 3, 23, 9, 0, 0), FinishedAt = new DateTime(2023, 3, 23, 13, 0, 0) });
            ExamList.Add(new Exam { Subject = "Chemistry", StartedAt = new DateTime(2023, 4, 23, 9, 0, 0), FinishedAt = new DateTime(2023, 4, 23, 13, 0, 0) });
            ExamList.Add(new Exam { Subject = "Algebra", StartedAt = new DateTime(2023, 5, 23, 9, 0, 0), FinishedAt = new DateTime(2023, 5, 23, 13, 0, 0) });
            ExamList.Add(new Exam { Subject = "History", StartedAt = new DateTime(2023, 6, 23, 9, 0, 0), FinishedAt = new DateTime(2023, 6, 23, 13, 0, 0) });
            ExamList.Add(new Exam { Subject = "English", StartedAt = new DateTime(2023, 7, 23, 9, 0, 0), FinishedAt = new DateTime(2023, 7, 23, 13, 0, 0) });
            ExamList.Add(new Exam { Subject = "Analysis", StartedAt = new DateTime(2023, 8, 23, 9, 0, 0), FinishedAt = new DateTime(2023, 8, 23, 13, 0, 0) });
            ExamList.Add(new Exam { Subject = "Computer architecture", StartedAt = new DateTime(2023, 9, 23, 9, 0, 0), FinishedAt = new DateTime(2023, 9, 23, 13, 0, 0) });
            ExamList.Add(new Exam { Subject = "Philosophy", StartedAt = new DateTime(2023, 10, 23, 9, 0, 0), FinishedAt = new DateTime(2023, 10, 23, 13, 0, 0) });











        }    
    }
}
