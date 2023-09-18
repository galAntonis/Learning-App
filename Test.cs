using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekpLog
{
    public partial class Test : KryptonForm
    {
        List<Question> questionList;
        int questionNum;
        bool answeredCorrectly = false;
        int correctAnswers,numOfQuestions;
        int subjectID, chapter;
        Student logedStudent;
        private static string connectionString = "Data Source = AntonisGaleos\\SQLEXPRESS;Initial Catalog=ekpLogDB;Integrated Security=true";
        private SqlConnection con = new SqlConnection(connectionString);
        public Test()
        {
            InitializeComponent();
        }

        public Test(List<Question> qlist, int subj, int chapt, Student student)
        {
            InitializeComponent();
            questionList = qlist;
            subjectID = subj;
            chapter = chapt;
            logedStudent = student;
            correctAnswers = 0;
            numOfQuestions = qlist.Count;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            questionNum = 0;
            scoreTxt.Text = "Βαθμολογία: 0/"+questionList.Count.ToString();
            countTxt.Text = "0/" + questionList.Count.ToString();
            correctTxt.Visible = false;
            wrongTxt.Visible = false;
            nextButton.Enabled = false;
            nextButton.Text = "Επόμενο";
            answer1Radio.Checked = true;
            nextButton.BackColor =Color.DarkGray; nextButton.ForeColor = Color.Gray;
            questionContentTxt.Text = questionList[0].question.ToString();
            answer1Radio.Text = questionList[0].answer1.ToString();
            answer2Radio.Text = questionList[0].answer2.ToString();
            answer3Radio.Text = questionList[0].answer3.ToString();
            answer4Radio.Text = questionList[0].answer4.ToString();
            checkForEmptyRadioButton();
        }

        private void questionContentTxt_Click(object sender, EventArgs e)
        {

        }

        private void checkForEmptyRadioButton()
        {
            if (answer1Radio.Text == "-") answer1Radio.Visible = false; 
            else 
                answer1Radio.Visible = true;
            if (answer2Radio.Text == "-") answer2Radio.Visible = false; 
            else 
                answer2Radio.Visible = true;
            if (answer3Radio.Text == "-") answer3Radio.Visible = false;
            else
                answer3Radio.Visible = true;
            if (answer4Radio.Text == "-") answer4Radio.Visible = false;
            else
                answer4Radio.Visible = true;
        }
        private void checkAnswer()
        {
            switch (questionList[questionNum].correctAns)
            {
                case 1:
                    if (answer1Radio.Checked) answeredCorrectly = true; else answeredCorrectly = false; break;
                case 2:
                    if (answer2Radio.Checked) answeredCorrectly = true; else answeredCorrectly = false; break;
                case 3:
                    if (answer3Radio.Checked) answeredCorrectly = true; else answeredCorrectly = false; break;
                case 4:
                    if (answer4Radio.Checked) answeredCorrectly = true; else answeredCorrectly = false; break;
                default:
                    break;
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            checkAnswer();
            if (answeredCorrectly)
            {
                correctAnswers += 1;
                scoreTxt.Text = "Βαθμολογία: " + correctAnswers + "/"+numOfQuestions;
                correctTxt.Visible = true;
                wrongTxt.Visible = false;
            }
            else
            {
                correctTxt.Visible = false;
                wrongTxt.Visible = true;
            }
            questionNum += 1;
            if (questionNum >= questionList.Count())
            {
                nextButton.Text = "Τέλος";
            }
            else
            {
                nextButton.Text = "Επόμενο";
            }

            nextButton.Enabled = true;
            nextButton.BackColor = Color.Maroon;
            nextButton.ForeColor = Color.White;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
            if (questionNum >= questionList.Count())
            {
                nextButton.Text = "Τέλος";
                int timesTakenExams = 1;
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    if (numOfQuestions == 5)
                    {
                        correctAnswers = correctAnswers * 2;
                    }
                    string query = "Select * from Scores where studentID=" + logedStudent.Id + " and chapter=" + chapter + " and subjectID=" + subjectID;
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    string query2 = "";
                    if (reader.Read())
                    {
                        timesTakenExams = Convert.ToInt32(reader.GetValue(4).ToString()) + 1;
                        query2 = "Update Scores set score=" + correctAnswers + ",timesTakenExams=" + timesTakenExams + "where studentID=" + logedStudent.Id + " and subjectID=" + subjectID + " and chapter=" + chapter;
                    }
                    else
                    {
                        
                        query2 = "Insert into Scores (studentID,subjectID,chapter,score,timesTakenExams) values (" + logedStudent.Id + "," + subjectID + "," + chapter + "," + correctAnswers + "," + timesTakenExams + ")";
                    }
                    reader.Close();
                    cmd = new SqlCommand(query2, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                if(questionList.Count() == 5)
                    MessageBox.Show("Το τεστ ολοκληρώθηκε με βαθμό: " + correctAnswers + "/" + questionList.Count * 2);
                else
                    MessageBox.Show("Το τεστ ολοκληρώθηκε με βαθμό: " + correctAnswers + "/" + questionList.Count);
                if(correctAnswers<5)
                    MessageBox.Show("Χρειάζεστε τουλάχιστον 5/10 για να περάσετε το μάθημα. Παρακαλώ προσπαθείστε ξανά");
                this.Close();
            }
            else
            {
                loadNextQuestion();
            }
        }

        private void loadNextQuestion()
        {
            correctTxt.Visible = false;
            wrongTxt.Visible = false;
            nextButton.Enabled = false;
            nextButton.BackColor = Color.DarkGray; nextButton.ForeColor = Color.Gray;
            answer1Radio.Checked = true;
            questionContentTxt.Text = questionList[questionNum].question.ToString();
            answer1Radio.Text = questionList[questionNum].answer1.ToString();
            answer2Radio.Text = questionList[questionNum].answer2.ToString();
            answer3Radio.Text = questionList[questionNum].answer3.ToString();
            answer4Radio.Text = questionList[questionNum].answer4.ToString();
            checkForEmptyRadioButton();
            int questionNumText = questionNum + 1;
            countTxt.Text = questionNumText + "/"+numOfQuestions;
        }
    }
}
