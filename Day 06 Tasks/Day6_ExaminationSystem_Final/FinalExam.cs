using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_ExaminationSystem_Final
{
    class FinalExam : Exam
    {
        public FinalExam(DateTime date, Subject subject, QuestionList questions) : base(date, subject, questions)
        {

        }

        public override void printExam()
        {
            if (Questions.Count > 0)
            {
                Console.WriteLine(Subject.getName() + " Exam\t" + Date + "\nNumber of Questions:" + Questions.Count);
                for (int i = 0; i < Questions.Count; i++)
                {
                    Console.Write("Q" + (i + 1) + " ");
                    Questions[i].printQuestion();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Exam is Empty");
            }

        }
    }
}
