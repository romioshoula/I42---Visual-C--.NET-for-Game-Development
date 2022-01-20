using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_ExaminationSystem_Final
{
    abstract class Exam
    {
        DateTime date;
        Subject subject;
        QuestionList questions;
        Mode mode;

        public DateTime Date { get => date; set => date = value; }
        public Subject Subject { get => subject; set => subject = value; }
        public QuestionList Questions { get => questions; set => questions = value; }
        internal Mode Mode { get => mode; set => mode = value; }

        public Exam(DateTime date, Subject subject, QuestionList questions)
        {
            this.date = date;
            this.subject = subject;
            this.questions = questions;
        }

        abstract public void printExam();
    }
}
