using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ekpLog
{
    public partial class Form2 : KryptonForm
    {
        private static string connectionString = "Data Source = AntonisGaleos\\SQLEXPRESS;Initial Catalog=ekpLogDB;Integrated Security=true";
        private Random random = new Random();
        private SqlConnection con = new SqlConnection(connectionString);

        public Form2()
        {
            InitializeComponent();
            emptyFieldsLabel.Visible = false;
            this.ActiveControl = emptyFieldsLabel;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = emptyFieldsLabel;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



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
        private string generateSalt()
        {
            int saltValue = random.Next(100, 1000); // Generate a random number between 100 and 999 (inclusive)
            string salt = saltValue.ToString("D3"); // Convert the number to a three-digit string with leading zeros if necessary
            return salt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            signUp();
        }

        // Εγγραφή χρήστη στη βάση
        private void signUp()
        {
            if(usernameTxt.Text!=null && passwordTxt.Text!=null && password2Txt.Text != null && nameTxt.Text!=null && surnameTxt.Text!=null)
            {
                if(passwordTxt.Text == password2Txt.Text)
                {
                    string salt = generateSalt();
                    string password = passwordTxt.Text + salt;
                    MessageBox.Show(salt);
                    MessageBox.Show(password);
                    string hashedPassword = getSHA256Hash(password);
                    MessageBox.Show(hashedPassword);
                    try
                    {
                        if(con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        
                        string query = "Insert into Users (username,firstname,lastname,hashedPassword,salt) values ('" + 
                            usernameTxt.Text + "','" + nameTxt.Text + "','" + surnameTxt.Text + "','" + hashedPassword + "','" + salt + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd = new SqlCommand(query, con);
                        int a = cmd.ExecuteNonQuery();
                        con.Close();
                        if (a == 0)
                        {
                            MessageBox.Show("Σφάλμα!");
                        }
                        else
                        {
                            MessageBox.Show("Εχετε γραφτεί με επιτυχία");
                            this.Close();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Ο κωδικός και η επανάληψη του κωδικού δεν είναι ίδια");
                }
            }
            else
            {
                emptyFieldsLabel.Visible = false;
            }
        }

        private void usernameTxt_Enter(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "Όνομα χρήστη")
            {
                usernameTxt.Text = string.Empty;
                usernameTxt.ForeColor = Color.Black;
            }
        }

        private void usernameTxt_Leave(object sender, EventArgs e)
        {
            if (usernameTxt.Text == string.Empty)
            {
                usernameTxt.Text = "Όνομα χρήστη";
                usernameTxt.ForeColor = Color.Silver;
            }
        }

        private void nameTxt_Enter(object sender, EventArgs e)
        {
            if (nameTxt.Text == "Όνομα")
            {
                nameTxt.Text = string.Empty;
                nameTxt.ForeColor = Color.Black;
            }
        }

        private void nameTxt_Leave(object sender, EventArgs e)
        {
            if (nameTxt.Text == string.Empty)
            {
                nameTxt.Text = "Όνομα";
                nameTxt.ForeColor = Color.Silver;
            }
        }

        private void surnameTxt_Enter(object sender, EventArgs e)
        {
            if (surnameTxt.Text == "Επίθετο")
            {
                surnameTxt.Text = string.Empty;
                surnameTxt.ForeColor = Color.Black;
            }
        }

        private void surnameTxt_Leave(object sender, EventArgs e)
        {
            if (surnameTxt.Text == string.Empty)
            {
                surnameTxt.Text = "Όνομα";
                surnameTxt.ForeColor = Color.Silver;
            }
        }

        private void passwordTxt_Enter(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "Κωδικός")
            {
                passwordTxt.Text = string.Empty;
                passwordTxt.ForeColor = Color.Black;
                passwordTxt.UseSystemPasswordChar = true;
            }
        }

        private void passwordTxt_Leave(object sender, EventArgs e)
        {
            if (passwordTxt.Text == string.Empty)
            {
                passwordTxt.Text = "Όνομα";
                passwordTxt.ForeColor = Color.Silver;
                passwordTxt.UseSystemPasswordChar = false;
            }
        }

        private void password2Txt_Enter(object sender, EventArgs e)
        {
            if (password2Txt.Text == "Επανάληψη Κωδικού")
            {
                password2Txt.Text = string.Empty;
                password2Txt.ForeColor = Color.Black;
                password2Txt.UseSystemPasswordChar = true;
            }
        }

        private void password2Txt_Leave(object sender, EventArgs e)
        {
            if (password2Txt.Text == string.Empty)
            {
                password2Txt.Text = "Όνομα";
                password2Txt.ForeColor = Color.Silver;
                password2Txt.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
