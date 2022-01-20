using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_ExaminationSystem_Final
{
    class PracticeExam : Exam
    {
        public PracticeExam(DateTime date, Subject subject, QuestionList questions) : base(date, subject, questions)
        {

        }

        public override void printExam()
        {
            if (Questions.Count > 0)
            {
                Console.WriteLine(Subject.getName() + " Exam\t" + Date + "\nNumber of Questions:" + Questions.Count);
                int marks = 0;
                int Totalmarks = 0;
                for (int i = 0; i < Questions.Count; i++)
                {
                    Question q = Questions[i];
                    Console.Write("Q" + (i + 1) + " ");
                    q.printQuestion();
                    q.takeAnswer();
                    marks += q.markQuestion();
                    Totalmarks += q.Mark;
                    q.showCorrectAnswer();
                    Console.WriteLine();
                }
                Console.WriteLine("you scored: " + marks + " out of " + Totalmarks);
            }
            else
            {
                Console.WriteLine("Exam is Empty");
            }

        }
    }
}
