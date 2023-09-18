using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekpLog
{
    public class Student
    {
        private int id;
        private string username;
        private string firstname;
        private string lastname;
        public Student()
        {

        }
        public Student(int id, string username, string firstname, string lastname)
        {
            this.id = id;
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
    }

   
}
