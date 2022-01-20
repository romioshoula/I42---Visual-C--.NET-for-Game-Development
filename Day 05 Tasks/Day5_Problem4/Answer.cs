using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem4
{
    class Answer
    {
        public String Body { get;  }

        public Answer(String ans)
        {
            Body = ans;
        }

        public override string ToString()
        {
            return Body;
        }
    }
}
