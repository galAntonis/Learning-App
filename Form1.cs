using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ekpLog
{
    public partial class Form1 : KryptonForm
    {
        private static string connectionString = "Data Source = AntonisGaleos\\SQLEXPRESS;Initial Catalog=ekpLogDB;Integrated Security=true";
        private SqlConnection con = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Όνομα χρήστη")
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "Όνομα χρήστη";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Κωδικός")
            {
                textBox2.Text = string.Empty;
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == string.Empty)
            {
                textBox2.Text = "Κωδικός";
                textBox2.ForeColor = Color.Silver;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        // Ελέγχω αν δεν έχουν περαστεί στοιχεία στα πεδία
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();

            if (username == string.Empty || password == string.Empty || username == "Όνομα χρήστη" || password == "Κωδικός")
            {
                emptyFieldsLabel.Visible = true;
            }
            else
            {
                emptyFieldsLabel.Visible = false;
                userCheck(username, password);
            }
        }


        //DATA ACCESS LAYER
        //
        
        private void userCheck(string username, string password)
        {
            string salt = "";
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                // Ψάχνω στη βάση για το αν υπάρχει χρηστης με αυτό το Username
                string query = "Select salt from Users where username='" + username + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Αν υπάρχει χρήστης ξεκίνάει ο έλεγχος του κωδικού
                    // Κρατάμε το salt για τον ελεγχο του κωδικού
                    salt = reader.GetValue(0).ToString();
                    reader.Close();
                    con.Close();
                    password = password + salt;
                    //Ελεγχος κωδικού
                    passwordCheck(username, password);
                }
                else
                {
                    MessageBox.Show("Λάθος όνομα χρήστη");
                }
                reader.Close();
                con.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            

            
            

        }

        private void passwordCheck(string username, string password)
        {
            //Κωδικός σε μορφή hash
            string hashedPassword = getSHA256Hash(password);
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //Ελέγχουμε αν ο χρήστης υπάρχει στη βαση 
                string query = "Select * from Users where username='" + username + "'and hashedPassword='" + hashedPassword + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int userID = Convert.ToInt32(reader.GetValue(0).ToString());
                    string firstname = reader.GetValue(2).ToString();
                    string surname = reader.GetValue(3).ToString();
                    Student student = new Student(userID, username, firstname, surname);
                    MainForm mainForm = new MainForm(student);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Λάθος κωδικός");
                }
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //Μέθοδος hash
        private static string getSHA256Hash(string inputString)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(inputString));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            Form2 signUpForm = new Form2();
            signUpForm.Show();
        }

        private void emptyFieldsLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form3 yourForm = new Form3();
            yourForm.ShowDialog();
        }
    }
}
