using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekpLog
{
    public class Grades
    {
        private int studentID;
        private int subjectID;
        private int chapter;
        private int score;
        private int timesTakeExam;

        public Grades(int studentID, int subjectID, int chapter, int score, int timesTakeExam)
        {
            this.studentID = studentID;
            this.subjectID = subjectID;
            this.chapter = chapter;
            this.score = score;
            this.timesTakeExam = timesTakeExam;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public int SubjectID { get => subjectID; set => subjectID = value; }
        public int Chapter { get => chapter; set => chapter = value; }
        public int Score { get => score; set => score = value; }
        public int TimesTakeExam { get => timesTakeExam; set => timesTakeExam = value; }
    }
}
