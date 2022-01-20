using System;
using System.Collections.Generic;

namespace Day5_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {

            TrueFalseQuestion TF = new TrueFalseQuestion("Q1: Head", 1, "Q1: Body");
            ChooseOneQuestion CO = new ChooseOneQuestion("Q2: Head", 2, "Q2: Body");

            PracticeExam PE = new PracticeExam(1.5f, 2, new Question[] { TF, CO }, new Subject("C#", 1));
            FinalExam FE = new FinalExam(1.5f, 2, new Question[] { TF, CO }, new Subject("C#", 1));

            int choice;
            bool parsed;
            do
            {
                parsed = int.TryParse(Console.ReadLine(), out choice);
            } while (!parsed && (choice <= 0 || choice >2));
            if (choice == 1)
                PE.showExam();
            else if (choice == 2)
                FE.showExam();
        }
    }
}
