using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_ExaminationSystem_Final
{
    class QuestionList : List<Question>
    {
        string fileName;

        public string FileName { get => fileName; set => fileName = value; }

        public QuestionList(string fileName) : base()
        {
            this.fileName = fileName;
        }

        public new void Add(Question question)
        {
            base.Add(question);
            StreamWriter file = new StreamWriter(FileName, append: true);
            file.WriteLine(question.ToString());
            file.Close();
        }
    }
}
