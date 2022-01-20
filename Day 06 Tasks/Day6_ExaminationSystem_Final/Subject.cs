using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_ExaminationSystem_Final
{
    class Subject
    {
        string Name;

        public Subject(string Name)
        {
            this.Name = Name;
        }

        public string getName() { return Name; }
        public void SetNames(string Name) { this.Name = Name; }

        ~Subject()
        {
            Console.WriteLine("Subject " + Name + " Exam Finished");
        }
    }
    enum Mode
    {
        Starting,
        Queued,
        Finished
    }
}
