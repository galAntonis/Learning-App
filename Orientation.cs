using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ekpLog
{
    public partial class Orientation : KryptonForm
    {
        private static string connectionString = "Data Source = AntonisGaleos\\SQLEXPRESS;Initial Catalog=ekpLogDB;Integrated Security=true";
        private SqlConnection con = new SqlConnection(connectionString);

        // Βαθμολογίες κατευθύνσεων
        private double softwareDeveloper = 100;
        private double softwareEngineer = 100;
        private double aiEmpoweredSoftwareEngineer = 100;
        private double machineLearningEngineer = 100;
        private double aiSpecialist = 100;
        private double uxDesigner = 100;

        // Λιστες radiobuttons
        RadioButton[] radioButtonsSoftwareDeveloper;
        RadioButton[] radioButtonsSoftwareEngineer;
        RadioButton[] radioButtonsAiEmpoweredSoftwareEngineer;
        RadioButton[] radioButtonsMachineLearningEngineer;
        RadioButton[] radioButtonsAiSpecialist;
        RadioButton[] radioButtonsUxDesigner;
        Student student;
        
        private int studentID, subjectID, chapter, score, timesTakenExam;
        public Orientation()
        {
            InitializeComponent();
        }

        public Orientation(Student user)
        {
            InitializeComponent();
            student = user;
        }

        private void Orientation_Load(object sender, EventArgs e)
        {
            //Κρατάω σε λίστα τους βαθμούς του μαθητή για να επηρεάσουν τις βαθμολογίες των κατευθύνσεων
            List<Grades> gradesList = new List<Grades>();
            try
            {
                con.Open();
                string query = "Select * from Scores where studentID='" + student.Id + "' and chapter=0";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read()) 
                {
                    studentID = Convert.ToInt32(reader.GetValue(0).ToString());
                    subjectID = Convert.ToInt32(reader.GetValue(1).ToString());
                    chapter = Convert.ToInt32(reader.GetValue(2).ToString());
                    score = Convert.ToInt32(reader.GetValue(3).ToString());
                    timesTakenExam = Convert.ToInt32(reader.GetValue(4).ToString());
                    Grades grades = new Grades(studentID, subjectID, chapter, score, timesTakenExam);
                    gradesList.Add(grades);
                }
                reader.Close();
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            // Αυξηση βαθμών κατευθύνσεων για αποτελεσματα μαθηματων
            for(int i = 0; i<gradesList.Count(); i++)
            {
                if (gradesList[i].SubjectID == 1)
                {
                    softwareDeveloper = softwareDeveloper + (gradesList[i].Score * 2);
                    softwareEngineer = softwareEngineer + (gradesList[i].Score * 2);
                    aiEmpoweredSoftwareEngineer = aiEmpoweredSoftwareEngineer + (gradesList[i].Score * 2);
                    machineLearningEngineer = machineLearningEngineer + (gradesList[i].Score * 2);
                    aiSpecialist = aiSpecialist + (gradesList[i].Score * 2);
                }
                else if (gradesList[i].SubjectID == 2)
                {
                    softwareDeveloper = softwareDeveloper + (gradesList[i].Score * 2);
                    softwareEngineer = softwareEngineer + (gradesList[i].Score * 2);
                    machineLearningEngineer = machineLearningEngineer + (gradesList[i].Score * 2);
                }
                else if (gradesList[i].SubjectID == 3)
                {
                    softwareDeveloper = softwareDeveloper + (gradesList[i].Score * 2);
                    softwareEngineer = softwareEngineer + (gradesList[i].Score * 2);
                    aiEmpoweredSoftwareEngineer = aiEmpoweredSoftwareEngineer + (gradesList[i].Score * 2);
                    uxDesigner = uxDesigner + (gradesList[i].Score * 2);
                }
                else if (gradesList[i].SubjectID == 4)
                {
                    aiEmpoweredSoftwareEngineer = aiEmpoweredSoftwareEngineer + (gradesList[i].Score * 2);
                    machineLearningEngineer = machineLearningEngineer + (gradesList[i].Score * 2);
                    aiSpecialist = aiSpecialist + (gradesList[i].Score * 2);
                }
                else if (gradesList[i].SubjectID == 5)
                {
                    softwareDeveloper = softwareDeveloper + (gradesList[i].Score * 2);
                    softwareEngineer = softwareEngineer + (gradesList[i].Score * 2);
                    aiEmpoweredSoftwareEngineer = aiEmpoweredSoftwareEngineer + (gradesList[i].Score * 2);
                    machineLearningEngineer = machineLearningEngineer + (gradesList[i].Score * 2);
                    aiSpecialist = aiSpecialist + (gradesList[i].Score * 2);
                }
                else if (gradesList[i].SubjectID == 6)
                {
                    softwareDeveloper = softwareDeveloper + (gradesList[i].Score * 2);
                    softwareEngineer = softwareEngineer + (gradesList[i].Score * 2);
                    aiEmpoweredSoftwareEngineer = aiEmpoweredSoftwareEngineer + (gradesList[i].Score * 2);
                    machineLearningEngineer = machineLearningEngineer + (gradesList[i].Score * 2);
                    aiSpecialist = aiSpecialist + (gradesList[i].Score * 2);
                }

                // Μείωση βαθμών για επαναληψη του τεστ
                softwareDeveloper = softwareDeveloper - gradesList[i].TimesTakeExam;
                softwareEngineer = softwareEngineer - gradesList[i].TimesTakeExam;
                aiEmpoweredSoftwareEngineer = aiEmpoweredSoftwareEngineer - gradesList[i].TimesTakeExam;
                machineLearningEngineer = machineLearningEngineer - gradesList[i].TimesTakeExam;
                aiSpecialist = aiSpecialist - gradesList[i].TimesTakeExam;

            }


            // Γκρουπάρισμα των radioButton ανάλογα με το ποια κατεύθυνση επηρεάζουν
            radioButtonsSoftwareDeveloper = new RadioButton[]
            {
                radioButton1,radioButton2,radioButton3, radioButton4, radioButton5, radioButton6, radioButton7, radioButton8, radioButton9, radioButton10,
                radioButton11,radioButton12,radioButton13,radioButton14,radioButton15,radioButton16,radioButton17,radioButton18,radioButton19,radioButton20,
                radioButton21,radioButton22,radioButton23,radioButton24,radioButton25,radioButton26,radioButton27,radioButton28,radioButton29,radioButton30,
                radioButton31,radioButton32,radioButton33,radioButton34,radioButton35,radioButton36,radioButton37,radioButton38,radioButton39,radioButton40,
                radioButton41,radioButton42,radioButton43,radioButton44,radioButton45,radioButton46,radioButton47,radioButton48,radioButton49,radioButton50,
                radioButton51,radioButton52,radioButton53,radioButton54,radioButton55,radioButton56,radioButton57,radioButton58,radioButton59,radioButton60,
                radioButton61,radioButton62,radioButton63,radioButton64,radioButton65,radioButton66,radioButton67,radioButton68,radioButton69,radioButton70,
                radioButton71,radioButton72,radioButton73,radioButton74,radioButton75,radioButton81,radioButton82,radioButton83,radioButton84,radioButton85,
                radioButton111,radioButton112,radioButton113,radioButton114,radioButton115,radioButton116,radioButton117,radioButton118,radioButton119,radioButton120
            };
            radioButtonsSoftwareEngineer = new RadioButton[]
            {
                radioButton1,radioButton2,radioButton3,radioButton4,radioButton5,radioButton6,radioButton7,radioButton8,radioButton9,radioButton10,
                radioButton11,radioButton12,radioButton13,radioButton14,radioButton15,radioButton16,radioButton17,radioButton18,radioButton19,radioButton20,
                radioButton21,radioButton22,radioButton23,radioButton24,radioButton25,radioButton26,radioButton27,radioButton28,radioButton29,radioButton30,
                radioButton31,radioButton32,radioButton33,radioButton34,radioButton35,radioButton36,radioButton37,radioButton38,radioButton39,radioButton40,
                radioButton66,radioButton67,radioButton68,radioButton69,radioButton70,radioButton71,radioButton72,radioButton73,radioButton74,radioButton75,
                radioButton86,radioButton87,radioButton88,radioButton89,radioButton90,radioButton111,radioButton112,radioButton113,radioButton114,radioButton115,
                radioButton116,radioButton117,radioButton118,radioButton119,radioButton120
            };
            radioButtonsAiEmpoweredSoftwareEngineer = new RadioButton[]
            {
                radioButton1,radioButton2,radioButton3,radioButton4, radioButton5,radioButton11,radioButton12,radioButton13,radioButton14,radioButton15,
                radioButton16,radioButton17,radioButton18,radioButton19,radioButton20,radioButton21,radioButton22,radioButton23,radioButton24,radioButton25,
                radioButton31, radioButton32,radioButton33,radioButton34,radioButton35,radioButton36,radioButton37,radioButton38,radioButton39,radioButton40,
                radioButton76,radioButton77,radioButton78,radioButton79,radioButton80,radioButton91,radioButton92,radioButton93,radioButton94,radioButton95,
                radioButton111,radioButton112,radioButton113,radioButton114,radioButton115,radioButton116,radioButton117,radioButton118,radioButton119,radioButton120,
                radioButton121,radioButton122,radioButton123,radioButton124,radioButton125,radioButton126,radioButton127,radioButton128,radioButton129,radioButton130,
                radioButton131,radioButton132,radioButton133,radioButton134,radioButton135,radioButton141,radioButton142,radioButton143,radioButton144,radioButton145
            };
            radioButtonsMachineLearningEngineer = new RadioButton[]
            {
                radioButton1,radioButton2,radioButton3,radioButton4,radioButton5,radioButton11,radioButton12,radioButton13,radioButton14,radioButton15,
                radioButton16,radioButton17,radioButton18,radioButton19,radioButton20,radioButton21,radioButton22,radioButton23,radioButton24,radioButton25,
                radioButton31,radioButton32,radioButton33,radioButton34,radioButton35,radioButton36,radioButton37,radioButton38,radioButton39,radioButton40,
                radioButton76,radioButton77,radioButton78,radioButton79,radioButton80,radioButton96,radioButton97,radioButton98,radioButton99,radioButton100,
                radioButton121,radioButton122,radioButton123,radioButton124,radioButton125,radioButton126,radioButton127,radioButton128,radioButton129,radioButton130,
                radioButton131,radioButton132,radioButton133, radioButton134,radioButton135, radioButton136,radioButton137,radioButton138,radioButton139,radioButton140
            };
            radioButtonsAiSpecialist = new RadioButton[]
            {
                radioButton1,radioButton2,radioButton3,radioButton4,radioButton5,radioButton11,radioButton12,radioButton13,radioButton14,radioButton15,
                radioButton16,radioButton17,radioButton18,radioButton19,radioButton20,radioButton21,radioButton22,radioButton23,radioButton24,radioButton25,
                radioButton31,radioButton32,radioButton33,radioButton34,radioButton35,radioButton36,radioButton37,radioButton38,radioButton39,radioButton40,
                radioButton101,radioButton102,radioButton103,radioButton104,radioButton105,radioButton121,radioButton122,radioButton123,radioButton124,radioButton125,
                radioButton126,radioButton127, radioButton128,radioButton129, radioButton130,radioButton131,radioButton132,radioButton133,radioButton134,radioButton135,
                radioButton136,radioButton137, radioButton138,radioButton139, radioButton140,radioButton141,radioButton142,radioButton143,radioButton144,radioButton145,
                radioButton146,radioButton147, radioButton148,radioButton149, radioButton150,radioButton151,radioButton152,radioButton153,radioButton154,radioButton155,
                radioButton156,radioButton157, radioButton158,radioButton159, radioButton160,radioButton176,radioButton177,radioButton178,radioButton179,radioButton180
            };
            radioButtonsUxDesigner = new RadioButton[]
            {
                radioButton106,radioButton107, radioButton108,radioButton109, radioButton110,radioButton161,radioButton162,radioButton163,radioButton164,radioButton165,
                radioButton166,radioButton167, radioButton168,radioButton169, radioButton170,radioButton171,radioButton172,radioButton173,radioButton174,radioButton175,
                radioButton176,radioButton177, radioButton178,radioButton179, radioButton180,radioButton181,radioButton182,radioButton183,radioButton184,radioButton185,
            };
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Έλεγχος απαντήσεων με for loop στις λίστες των κατευθύσεων και αυξηση ή μείωση των βαθμών
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < radioButtonsSoftwareDeveloper.Length; i++)
            {
                if (radioButtonsSoftwareDeveloper[i].Checked)
                {
                    if (radioButtonsSoftwareDeveloper[i].Text == "1")
                        softwareDeveloper -= 5.56;
                    else if (radioButtonsSoftwareDeveloper[i].Text == "2")
                        softwareDeveloper -= 2.78;
                    else if (radioButtonsSoftwareDeveloper[i].Text == "4")
                        softwareDeveloper += 2.78;
                    else if (radioButtonsSoftwareDeveloper[i].Text == "5")
                        softwareDeveloper += 5.56;
                }
            }
            for (int i = 0; i < radioButtonsSoftwareEngineer.Length; i++)
            {
                if (radioButtonsSoftwareEngineer[i].Checked)
                {
                    if (radioButtonsSoftwareEngineer[i].Text == "1")
                        softwareEngineer -= 7.69;
                    else if (radioButtonsSoftwareEngineer[i].Text == "2")
                        softwareEngineer -= 3.85;
                    else if (radioButtonsSoftwareEngineer[i].Text == "4")
                        softwareEngineer += 3.85;
                    else if (radioButtonsSoftwareEngineer[i].Text == "5")
                        softwareEngineer += 7.69;
                }
            }
            for (int i = 0; i < radioButtonsAiEmpoweredSoftwareEngineer.Length; i++)
            {
                if (radioButtonsAiEmpoweredSoftwareEngineer[i].Checked)
                {
                    if (radioButtonsAiEmpoweredSoftwareEngineer[i].Text == "1")
                        aiEmpoweredSoftwareEngineer -= 7.14;
                    else if (radioButtonsAiEmpoweredSoftwareEngineer[i].Text == "2")
                        aiEmpoweredSoftwareEngineer -= 3.57;
                    else if (radioButtonsAiEmpoweredSoftwareEngineer[i].Text == "4")
                        aiEmpoweredSoftwareEngineer += 3.57;
                    else if (radioButtonsAiEmpoweredSoftwareEngineer[i].Text == "5")
                        aiEmpoweredSoftwareEngineer += 7.14;
                }
            }
            for (int i = 0; i < radioButtonsMachineLearningEngineer.Length; i++)
            {
                if (radioButtonsMachineLearningEngineer[i].Checked)
                {
                    if (radioButtonsMachineLearningEngineer[i].Text == "1")
                        machineLearningEngineer -= 8.34;
                    else if (radioButtonsMachineLearningEngineer[i].Text == "2")
                        machineLearningEngineer -= 4.17;
                    else if (radioButtonsMachineLearningEngineer[i].Text == "4")
                        machineLearningEngineer += 4.17;
                    else if (radioButtonsMachineLearningEngineer[i].Text == "5")
                        machineLearningEngineer += 8.34;
                }
            }
            for (int i = 0; i < radioButtonsAiSpecialist.Length; i++)
            {
                if (radioButtonsAiSpecialist[i].Checked)
                {
                    if (radioButtonsAiSpecialist[i].Text == "1")
                        aiSpecialist -= 6.25;
                    else if (radioButtonsAiSpecialist[i].Text == "2")
                        aiSpecialist -= 3.125;
                    else if (radioButtonsAiSpecialist[i].Text == "4")
                        aiSpecialist += 3.125;
                    else if (radioButtonsAiSpecialist[i].Text == "5")
                        aiSpecialist += 6.25;
                }
            }
            for (int i = 0; i < radioButtonsUxDesigner.Length; i++)
            {
                if (radioButtonsUxDesigner[i].Checked)
                {
                    if (radioButtonsUxDesigner[i].Text == "1")
                        uxDesigner -= 16.67;
                    else if (radioButtonsUxDesigner[i].Text == "2")
                        uxDesigner -= 8.335;
                    else if (radioButtonsUxDesigner[i].Text == "4")
                        uxDesigner += 8.335;
                    else if (radioButtonsUxDesigner[i].Text == "5")
                        uxDesigner += 16.67;
                }
            }

            //Βρίσκω την κατευθυνση με την μεγαλύτερη βαθμολογία
            double maxValue = Math.Max(uxDesigner,Math.Max(softwareDeveloper, Math.Max(softwareEngineer, Math.Max(aiEmpoweredSoftwareEngineer, Math.Max(machineLearningEngineer, aiSpecialist)))));


            //Εμφάνιση μηνυμάτων
            if (maxValue == softwareDeveloper)
                MessageBox.Show("Θα ήσασταν ένας ικανός Software Developer");
            else if(maxValue == softwareEngineer)
                MessageBox.Show("Θα ήσασταν ένας ικανός Software Engineer");
            else if(maxValue == aiEmpoweredSoftwareEngineer)
                MessageBox.Show("Θα ήσασταν ένας ικανός AI Empowered Software Engineer");
            else if (maxValue == machineLearningEngineer) 
                MessageBox.Show("Θα ήσασταν ένας ικανός Machine Learning Engineer");
            else if(maxValue == aiSpecialist)
                MessageBox.Show("Θα ήσασταν ένας ικανός AI Specialist");
            else if (maxValue == uxDesigner) 
                MessageBox.Show("Θα ήσασταν ένας ικανός UX Designer");
            
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }
    }
}
