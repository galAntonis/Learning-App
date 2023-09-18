using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ekpLog
{
    public partial class MainForm : KryptonForm
    {
        private Panel _dropDownPanel;
        private int selectedSubject, selectedChapter,userID;
        Student logedStudent;


        private static string connectionString = "Data Source = AntonisGaleos\\SQLEXPRESS;Initial Catalog=ekpLogDB;Integrated Security=true";
        private SqlConnection con = new SqlConnection(connectionString);
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Student student)
        {
            InitializeComponent();
            logedStudent = student;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Καλως ήρθες, " + logedStudent.Firstname;
        }



        // Timer Ticks /****************************/
        //
        //
        private void downTimer_Tick(object sender, EventArgs e)
        {
            _dropDownPanel.Height += 10;
            if (_dropDownPanel.Height == _dropDownPanel.MaximumSize.Height)
            {
                downTimer.Stop();
            }
        }
        //
        //
        // End of Timer Ticks /****************************/



        // Start of Subject One /****************************/
        //  ** Control all the functions of the first subject ** //
        //
        //
        // Mouse Enter functions 
        // ** On Mouse Enter change the color ** //
        private void subjectOneInsidePanel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectOneInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectOneInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectOneLabel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectOneInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectOneInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectOnePictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (subjectOneInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectOneInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        //
        //
        // Mouse Leave functions
        // ** On Mouse Leave change the color ** //
        private void subjectOneLabel_MouseLeave(object sender, EventArgs e)
        {
            if (subjectOneInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectOneInsidePanel.BackColor = Color.White;
        }
        private void subjectOnePictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (subjectOneInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectOneInsidePanel.BackColor = Color.White;
        }
        private void subjectOneInsidePanel_MouseLeave(object sender, EventArgs e)
        {
            if (subjectOneInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectOneInsidePanel.BackColor = Color.White;
        }
        //
        //
        // Mouse Click functions
        // ** On Mouse Click change the color ** //
        private void subjectOneInsidePanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectOneDropDown, subjectOneInsidePanel, subjectOneLabel);
        }
        private void subjectOneLabel_Click(object sender, EventArgs e)
        {
           HideAllPanels();
            ShowPanel(subjectOneDropDown, subjectOneInsidePanel,  subjectOneLabel);
        }
        private void subjectOnePictureBox_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectOneDropDown, subjectOneInsidePanel, subjectOneLabel);
        }
        //
        //
        // Chapter Button Clicks
        // ** Opens each chapter on click ** //
        private void s1c1Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_1.pdf");
            selectedSubject = 1;
            selectedChapter = 1;

        }
        private void s1c12Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_2.pdf");
            selectedSubject = 1;
            selectedChapter = 2;
        }
        private void s1c3Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_3.pdf");
            selectedSubject = 1;
            selectedChapter = 3;
        }
        private void s1c4Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_4.pdf");
            selectedSubject = 1;
            selectedChapter = 4;
        }
        private void s1c5Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_5.pdf");
            selectedSubject = 1;
            selectedChapter = 5;
        }
        private void s1c6Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_6.pdf");
            selectedSubject = 1;
            selectedChapter = 6;
        }
        private void s1c7Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_7.pdf");
            selectedSubject = 1;
            selectedChapter = 7;
        }
        private void s1c8Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_8.pdf");
            selectedSubject = 1;
            selectedChapter = 8;
        }
        private void s1c9Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_9.pdf");
            selectedSubject = 1;
            selectedChapter = 9;
        }
        private void s1c10Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Java\\Java_10.pdf");
            selectedSubject = 1;
            selectedChapter = 10;
        }
        //
        //
        // End of Subject One /****************************/






        // Start of Subject Two /****************************/
        //  ** Control all the functions of the second subject ** //
        //
        //
        // Mouse Enter functions 
        // ** On Mouse Enter change the color ** //
        private void subjectTwoInsidePanel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectTwoInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectTwoInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectTwoLabel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectTwoInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectTwoInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectTwoPictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (subjectTwoInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectTwoInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
       
        //
        //
        // Mouse Leave functions
        // ** On Mouse Leave change the color ** //
        private void subjectTwoInsidePanel_MouseLeave(object sender, EventArgs e)
        {
            if (subjectTwoInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectTwoInsidePanel.BackColor = Color.White;
        }
        //
        //
        // Mouse Click functions 
        // ** On Mouse Enter change the color ** //
        private void subjectTwoInsidePanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectTwoDropDown, subjectTwoInsidePanel, subjectTwoLabel);
        }
        private void subjectTwoLabel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectTwoDropDown, subjectTwoInsidePanel, subjectTwoLabel);
        }
        private void subjectTwoPictureBox_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectTwoDropDown, subjectTwoInsidePanel, subjectTwoLabel);
        }
        //
        //
        // Chapter Button Clicks
        // ** Opens each chapter on click ** //
        private void s2c1Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\DB\\DB_01.pdf");
            selectedSubject = 2;
            selectedChapter = 1;
        }
        private void s2c2Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\DB\\DB_02.pdf");
            selectedSubject = 2;
            selectedChapter = 2;
        }
        private void s2c3aButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\DB\\DB_03a.pdf");
            selectedSubject = 2;
            selectedChapter = 3;
        }
        private void s2c3bButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\DB\\DB_03b.pdf");
            selectedSubject = 2;
            selectedChapter = 4;
        }
        private void s2c3cButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\DB\\DB_03c.pdf");
            selectedSubject = 2;
            selectedChapter = 5;
        }
        private void s2c3dButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\DB\\DB_03d.pdf");
            selectedSubject = 2;
            selectedChapter = 6;
        }
        private void s2c4Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\DB\\DB_04.pdf");
            selectedSubject = 2;
            selectedChapter = 7;
        }
        //
        //
        // End of Subject Two /****************************/


        // Start of Subject Three /****************************/
        //  ** Control all the functions of the second subject ** //
        //
        //
        // Mouse Enter functions 
        // ** On Mouse Enter change the color ** //
        private void subjectThreeInsidePanel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectThreeInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectThreeInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectThreeLabel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectThreeInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectThreeInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectThreePictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (subjectThreeInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectThreeInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        //
        //
        // Mouse Leave functions
        // ** On Mouse Leave change the color ** //
        private void subjectThreeInsidePanel_MouseLeave(object sender, EventArgs e)
        {
            if (subjectThreeInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectThreeInsidePanel.BackColor = Color.White;
        }
        //
        //
        // Mouse Click functions 
        // ** On Mouse Enter change the color ** //
        private void subjectThreeInsidePanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectThreeDropDown, subjectThreeInsidePanel, subjectThreeLabel);
        }
        private void subjectThreeLabel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectThreeDropDown, subjectThreeInsidePanel, subjectThreeLabel);
        }
        private void subjectThreePictureBox_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectThreeDropDown, subjectThreeInsidePanel, subjectThreeLabel);
        }
        //
        //
        // Chapter Button Clicks
        // ** Opens each chapter on click ** //
        private void s3c1Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\TL\\TL_01.pdf");
            selectedSubject = 3;
            selectedChapter = 1;
        }
        private void s3c2Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\TL\\TL_02.pdf");
            selectedSubject = 3;
            selectedChapter = 2;
        }
        private void s3c3Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\TL\\TL_03.pdf");
            selectedSubject = 3;
            selectedChapter = 3;
        }
        private void s3c4Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\TL\\TL_04.pdf");
            selectedSubject = 3;
            selectedChapter = 4;
        }
        private void s3c5Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\TL\\TL_05.pdf");
            selectedSubject = 3;
            selectedChapter = 5;
        }
        private void s3c6Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\TL\\TL_06.pdf");
            selectedSubject = 3;
            selectedChapter = 6;
        }
        //
        //
        // End of Subject Three /****************************/



        // Start of Subject Four /****************************/
        //  ** Control all the functions of the second subject ** //
        //
        //
        // Mouse Enter functions 
        // ** On Mouse Enter change the color ** //
        private void subjectFourInsidePanel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectFourInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectFourInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectFourLabel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectFourInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectFourInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectFourPictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (subjectFourInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectFourInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        //
        //
        // Mouse Leave functions
        // ** On Mouse Leave change the color ** //
        private void subjectFourInsidePanel_MouseLeave(object sender, EventArgs e)
        {
            if (subjectFourInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectFourInsidePanel.BackColor = Color.White;
        }
        //
        //
        // Mouse Click functions 
        // ** On Mouse Enter change the color ** //
        private void subjectFourInsidePanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectFourDropDown, subjectFourInsidePanel, subjectFourLabel);
        }
        private void subjectFourLabel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectFourDropDown, subjectFourInsidePanel, subjectFourLabel);
        }
        private void subjectFourPictureBox_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectFourDropDown, subjectFourInsidePanel, subjectFourLabel);
        }
        //
        //
        // Chapter Button Clicks
        // ** Opens each chapter on click ** //
        private void s4c1Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\AP\\AP_01.pdf");
            selectedSubject = 4;
            selectedChapter = 1;
        }
        private void s4c2Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\AP\\AP_02.pdf");
            selectedSubject = 4;
            selectedChapter = 2;
        }
        private void s4c3Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\AP\\AP_03.pdf");
            selectedSubject = 4;
            selectedChapter = 3;
        }
        private void s4c4Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\AP\\AP_04.pdf");
            selectedSubject = 4;
            selectedChapter = 4;
        }
        //
        //
        // End of Subject Four /****************************/


        // Start of Subject Five /****************************/
        //  ** Control all the functions of the second subject ** //
        //
        //
        // Mouse Enter functions 
        // ** On Mouse Enter change the color ** //
        private void subjectFiveInsidePanel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectFiveInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectFiveInsidePanel.BackColor = Color.FromArgb(233, 245, 245);

        }
        private void subjectFiveLabel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectFiveInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectFiveInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectFivePictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (subjectFiveInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectFiveInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        //
        //
        // Mouse Leave functions
        // ** On Mouse Leave change the color ** //
        private void subjectFiveInsidePanel_MouseLeave(object sender, EventArgs e)
        {
            if (subjectFiveInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectFiveInsidePanel.BackColor = Color.White;
        }
        //
        //
        // Mouse Click functions 
        // ** On Mouse Enter change the color ** //
        private void subjectFiveInsidePanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectFiveDropDown, subjectFiveInsidePanel, subjectFiveLabel);
        }
        private void subjectFiveLabel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectFiveDropDown, subjectFiveInsidePanel, subjectFiveLabel);
        }
        private void subjectFivePictureBox_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectFiveDropDown, subjectFiveInsidePanel, subjectFiveLabel);
        }
        //
        //
        // Chapter Button Clicks
        // ** Opens each chapter on click ** //
        private void s5c1Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\CPP\\CPP_01.pdf");
            selectedSubject = 5;
            selectedChapter = 1;
        }
        private void s5c2Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\CPP\\CPP_02.pdf");
            selectedSubject = 5;
            selectedChapter = 2;
        }
        private void s5c3Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\CPP\\CPP_03.pdf");
            selectedSubject = 5;
            selectedChapter = 3;
        }
        private void s5c4Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\CPP\\CPP_04.pdf");
            selectedSubject = 5;
            selectedChapter = 4;
        }
        //
        //
        // End of Subject Five /****************************/


        // Start of Subject Five /****************************/
        //  ** Control all the functions of the second subject ** //
        //
        //
        // Mouse Enter functions 
        // ** On Mouse Enter change the color ** //
        private void subjectSixInsidePanel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectSixInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectSixInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectSixLabel_MouseEnter(object sender, EventArgs e)
        {
            if (subjectSixInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectSixInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        private void subjectSixPictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (subjectSixInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectSixInsidePanel.BackColor = Color.FromArgb(233, 245, 245);
        }
        //
        //
        // Mouse Leave functions
        // ** On Mouse Leave change the color ** //
        private void subjectSixInsidePanel_MouseLeave(object sender, EventArgs e)
        {
            if (subjectSixInsidePanel.BackColor != Color.FromArgb(224, 255, 255)) subjectSixInsidePanel.BackColor = Color.White;
        }
        //
        //
        // Mouse Click functions 
        // ** On Mouse Enter change the color ** //
        private void subjectSixInsidePanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectSixDropDown, subjectSixInsidePanel, subjectSixLabel);
        }
        private void subjectSixLabel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectSixDropDown, subjectSixInsidePanel, subjectSixLabel);
        }
        private void subjectSixPictureBox_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ShowPanel(subjectSixDropDown, subjectSixInsidePanel, subjectSixLabel);
        }
        //
        //
        // Chapter Button Clicks
        // ** Opens each chapter on click ** //
        private void s6c1Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Python\\Python_01.pdf");
            selectedSubject = 6;
            selectedChapter = 1;
        }
        private void s6c2Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Python\\Python_02.pdf");
            selectedSubject = 6;
            selectedChapter = 2;
        }
        private void s6c3Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Python\\Python_03.pdf");
            selectedSubject = 6;
            selectedChapter = 3;
        }
        private void s6c4Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Python\\Python_04.pdf");
            selectedSubject = 6;
            selectedChapter = 4;
        }
        private void s6c5Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Python\\Python_05.pdf");
            selectedSubject = 6;
            selectedChapter = 5;
        }
        private void s6c6Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Python\\Python_06.pdf");
            selectedSubject = 6;
            selectedChapter = 6;
        }
        private void s6c7Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Python\\Python_07.pdf");
            selectedSubject = 6;
            selectedChapter = 7;
        }
        private void s6c8Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Python\\Python_08.pdf");
            selectedSubject = 6;
            selectedChapter = 8;
        }
        private void s6c9Button_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            pdfViewer1.LoadFromFile("Subjects\\Python\\Python_09.pdf");
            selectedSubject = 6;
            selectedChapter = 9;
        }
        //
        //
        // End of Subject Five /****************************/

        // Επιλογή των ερωτήσεων και ανοιγμα φορμας Τεστ
        private void chapterTest_Click(object sender, EventArgs e)
        {
            if (selectedSubject != null && selectedChapter != null)
            {
                List<Question> questionList = getQuestionList(selectedSubject, selectedChapter);
                List<Question> shuffledList = randomizedList(questionList,5);
                Form test = new Test(shuffledList,selectedSubject,selectedChapter,logedStudent);
                test.Show();               
            }
            else
                MessageBox.Show("Δεν εχει επιλεγεί κανένα μάθημα");
        }



        // Start of Other Functions /****************************/
        //
        //
        private void resetPanel(Panel dropdown, Panel panel, Label label)
        {
            dropdown.Height = dropdown.MinimumSize.Height;
            panel.BackColor = Color.White;
            label.ForeColor = Color.FromArgb(112, 128, 144);
        }
        private void HideAllPanels()
        {
            resetPanel(subjectOneDropDown, subjectOneInsidePanel, subjectOneLabel);
            resetPanel(subjectTwoDropDown, subjectTwoInsidePanel, subjectTwoLabel);
            resetPanel(subjectThreeDropDown, subjectThreeInsidePanel, subjectThreeLabel);
            resetPanel(subjectFourDropDown, subjectFourInsidePanel, subjectFourLabel);
            resetPanel(subjectFiveDropDown, subjectFiveInsidePanel, subjectFiveLabel);
            resetPanel(subjectSixDropDown, subjectSixInsidePanel, subjectSixLabel);
        }

        // Παίρνει τις ερωτήσεις για τα κεφάλαια απο τη βάση
        private List<Question> getQuestionList(int selectedSubject, int selectedChapter)
        {
            string question = "";
            string answer1 = "";
            string answer2 = "";
            string answer3 = "";
            string answer4 = "";
            int correctAns;

            List<Question> questionList = new List<Question>();
            Question questionObj;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "Select * from Questions where subjectID='" + selectedSubject + "' and chapter='" + selectedChapter + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    question = reader.GetValue(3).ToString();
                    answer1 = reader.GetValue(4).ToString();
                    answer2 = reader.GetValue(5).ToString();
                    answer3 = reader.GetValue(6).ToString();
                    answer4 = reader.GetValue(7).ToString();
                    correctAns = Convert.ToInt32(reader.GetValue(8));
                    questionObj = new Question(question, answer1, answer2, answer3, answer4, correctAns);
                    questionList.Add(questionObj);
                }
                reader.Close();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
            

            return questionList;
        }

        // Παίρνει τις επαναλληπτικές ερωτήσεις από τη βάση
        private List<Question> getSubjectQuestionList(int selectedSubject)
        {
            string question = "";
            string answer1 = "";
            string answer2 = "";
            string answer3 = "";
            string answer4 = "";
            int correctAns;

            List<Question> questionList = new List<Question>();
            Question questionObj;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "Select * from Questions where subjectID='" + selectedSubject + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    question = reader.GetValue(3).ToString();
                    answer1 = reader.GetValue(4).ToString();
                    answer2 = reader.GetValue(5).ToString();
                    answer3 = reader.GetValue(6).ToString();
                    answer4 = reader.GetValue(7).ToString();
                    correctAns = Convert.ToInt32(reader.GetValue(8));
                    questionObj = new Question(question, answer1, answer2, answer3, answer4, correctAns);
                    questionList.Add(questionObj);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }



            return questionList;
        }

        //Βαθμολογίες
        private void button1_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores(logedStudent);
            scores.Show();
        }


        // Κουμπί για επαναληπτικό τεστ
        private void subjectTestButton_Click(object sender, EventArgs e)
        {
            if (selectedSubject != null)
            {
                List<Question> questionList = getSubjectQuestionList(selectedSubject);
                List<Question> shuffledList = randomizedList(questionList, 10);
                Form test = new Test(shuffledList, selectedSubject, 0, logedStudent);
                test.Show();
            }
            else
                MessageBox.Show("Δεν εχει επιλεγεί κανένα μάθημα");
        }

        //Κουμπί για τεστ κεφαλαίου
        private void testButton_Click(object sender, EventArgs e)
        {
            Orientation orientation = new Orientation(logedStudent);
            orientation.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }


        //Ανακάτεμα ερωτήσεων
        private List<Question> randomizedList(List<Question> questionList, int numOfQuestions)
        {
            List<Question> randomizedList = new List<Question>();
            Random rng = new Random();
            List<Question> shuffledList = questionList.OrderBy(x => rng.Next()).ToList();
            randomizedList = shuffledList.Take(numOfQuestions).ToList();
            return randomizedList;
        }

        private void ShowPanel(Panel dropDownPanel, Panel insidePanel, Label label)
        {
            _dropDownPanel = dropDownPanel;
            downTimer.Start();
            insidePanel.BackColor = Color.FromArgb(224, 255, 255);
            label.ForeColor = Color.FromArgb(0, 191, 255);
        }

        /*
private void loadForm(object Form)
{
   //Load forms without opening a new window each time. Just changes panel's Controls
   if (this.homepanel.Controls.Count > 0)
       this.homepanel.Controls.RemoveAt(0);
   Form form = Form as Form;
   form.TopLevel = false;
   form.Dock = DockStyle.Fill;
   this.homepanel.Controls.Add(form);
   this.homepanel.Tag = form;
   form.Show();
}*/
        //
        //
        // End of Other Functions /****************************/


    }
}
