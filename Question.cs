using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekpLog
{
    public class Question
    {
        public string question;
        public string answer1;
        public string answer2;
        public string answer3;
        public string answer4;
        public int correctAns;



        public Question() { }

        public Question(string question, string answer1, string answer2, string answer3, string answer4, int correctAns)
        {
            this.question = question;
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
            this.answer4 = answer4;
            this.correctAns = correctAns;
        }
    }
}
