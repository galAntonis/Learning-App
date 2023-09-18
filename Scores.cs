using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ekpLog
{
    public partial class Scores : KryptonForm
    {
        Student student;
        private static string connectionString = "Data Source = AntonisGaleos\\SQLEXPRESS;Initial Catalog=ekpLogDB;Integrated Security=true";
        private SqlConnection con = new SqlConnection(connectionString);
        public Scores()
        {
            InitializeComponent();
        }

        public Scores(Student user)
        {
            InitializeComponent();
            student = user;
        }

        private void Scores_Load(object sender, EventArgs e)
        {
                try
                {
                 SqlCommand cmd = new SqlCommand("Select subjectID,chapter,score from Scores where studentID = " + student.Id, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            

        }


    }
}
