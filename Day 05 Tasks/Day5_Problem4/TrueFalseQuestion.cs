using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem4
{
    class TrueFalseQuestion: Question
    {
        public TrueFalseQuestion(String hd, decimal mrks, String ans): base(hd, mrks, ans)
        {
            ;
        }

        public void f()
        {
            Console.WriteLine(answer.Body);
        }

        

    }
}
