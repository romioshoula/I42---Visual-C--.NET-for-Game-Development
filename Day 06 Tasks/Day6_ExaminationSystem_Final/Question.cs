using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_ExaminationSystem_Final
{
    abstract class Question
    {
        string header;
        string body;
        int mark;

        public string Header { get => header; set => header = value; }
        public string Body { get => body; set => body = value; }
        public int Mark { get => mark; set => mark = value; }

        public Question(string body, int mark)
        {
            this.body = body;
            this.mark = mark;
        }

        public abstract void printQuestion();
        public abstract void takeAnswer();
        public abstract int markQuestion();
        public abstract void showCorrectAnswer();

        public void printChoice(int number, string choice)
        {
            Console.WriteLine(number + "." + choice);
        }

        public abstract override string ToString();

        public abstract string choicesToString();
    }
}
