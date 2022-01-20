using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day5_Problem4
{
    abstract class Question
    {
        public String Head { get; set; }

        public decimal Marks { get; set; } 

        public bool Answered { get; set; } = false;

        //protected AnswerList Choices { get; }

        public Answer answer { get; }


        public Question(String h, decimal m, String ans){
            Head = h;
            Marks = m;
            answer = new Answer(ans);
        }

        public override string ToString()
        {
            return $"{Head} ({Marks} marks)";
        }
    }
}
