using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_ExaminationSystem_Final
{
    class TrueFalse : Question
    {
        string[] choices = new string[2];
        int correctAnswerIndex;
        int studentanswerIndex = -1;

        public string[] Choices { get => choices; set => choices = value; }
        public int CorrectAnswerIndex { get => correctAnswerIndex; set => correctAnswerIndex = value; }
        public int StudentanswerIndex { get => studentanswerIndex; set => studentanswerIndex = value; }

        public TrueFalse(string body, int mark, int correctAnswerIndex) : base(body, mark)
        {
            Header = "Choose True or False:";
            choices[0] = "true";
            choices[1] = "false";
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
            if (correctAnswerIndex == studentanswerIndex)
            {
                return Mark;
            }
            else
            {
                return 0;
            }
        }

        public override void takeAnswer()
        {
            Console.Write("Answer Index: ");
            int ans = int.Parse(Console.ReadLine());
            StudentanswerIndex = ans;
        }
        public override void showCorrectAnswer()
        {
            Console.WriteLine("Correct Answer Index: " + correctAnswerIndex);
        }
    }
}
