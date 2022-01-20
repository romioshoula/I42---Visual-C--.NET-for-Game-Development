using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_ExaminationSystem_Final
{
    class ChooseAll : Question
    {
        string[] choices = new string[2];
        int[] correctAnswerIndex;
        int[] studentanswerIndex;

        public string[] Choices { get => choices; set => choices = value; }
        public int[] CorrectAnswerIndex { get => correctAnswerIndex; set => correctAnswerIndex = value; }
        public int[] StudentanswerIndex { get => studentanswerIndex; set => studentanswerIndex = value; }

        public ChooseAll(string body, string[] choices, int mark, int[] correctAnswerIndex) : base(body, mark)
        {
            Header = "Choose all the correct answers:";
            this.choices = choices;
            this.correctAnswerIndex = correctAnswerIndex;
        }

        public override void printQuestion()
        {
            Console.WriteLine(Body + "\t" + "Marks:" + Mark + "\n" + Header);
            for (int i = 0; i < choices.Length; i++)
            {
                printChoice(i, choices[i]);
            }
        }

        public override string choicesToString()
        {
            string choicesString = "";
            for (int i = 0; i < Choices.Length; i++)
            {
                choicesString += "\n" + i + "." + Choices[i];
            }
            return choicesString;
        }

        public override string ToString()
        {
            return Body + "\t" + "Marks: " + Mark + "\n" + Header + choicesToString() + "\n";
        }

        public override int markQuestion()
        {
            bool isCorrect = true;
            int wrongCount = 0;
            Array.Sort(correctAnswerIndex);
            Array.Sort(studentanswerIndex);
            for (int i = 0; i < correctAnswerIndex.Length; i++)
            {
                if (correctAnswerIndex[i] != studentanswerIndex[i])
                {
                    isCorrect = false;
                    wrongCount++;
                }
            }

            if (isCorrect)
            {
                return Mark;
            }
            else
            {
                int finalMark = Mark - wrongCount;
                finalMark = finalMark < 0 ? 0 : finalMark;
                return finalMark;
            }
        }

        public override void takeAnswer()
        {
            Console.Write("Answer Index: ");
            int[] ans = new int[correctAnswerIndex.Length];
            for (int i = 0; i < ans.Length; i++)
            {
                Console.WriteLine("enter answer index");
                ans[i] = int.Parse(Console.ReadLine());
            }
            StudentanswerIndex = ans;
        }

        public override void showCorrectAnswer()
        {
            Console.Write("Correct Answer Index: ");
            for (int i = 0; i < correctAnswerIndex.Length; i++)
            {
                Console.Write(correctAnswerIndex[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
