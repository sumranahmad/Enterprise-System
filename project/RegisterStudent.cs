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

namespace project
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textEnroll.Clear();
            textDept.Clear();
            textSemester.Clear();
            textContact.Clear();
            textEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textName.Text != "" && textEnroll.Text != "" && textDept.Text != "" && textSemester.Text != "" && textContact.Text != "" && textEmail.Text != "")
            {
                string name = textName.Text;
                string enrollNo = textEnroll.Text;
                string dept = textDept.Text;
                string semesterText = textSemester.Text.Trim(); 
                string contactText = textContact.Text.Trim();
                string email = textEmail.Text.Trim();

                if ((contactText.StartsWith("+92") && contactText.Length == 12) || (contactText.StartsWith("03") && contactText.Length == 11))
                {
                    if (email.EndsWith("@gmail.com"))
                    {
                        if (int.TryParse(semesterText, out int semester) && semester >= 1 && semester <= 8)
                        {
                            SqlConnection conn = new SqlConnection();
                            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.CommandText = "INSERT INTO AddStudent(sname, enroll, dep, sem, contact, email) VALUES('" + name + "','" + enrollNo + "','" + dept + "','" + semesterText + "','" + contactText + "','" + email + "')";
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textName.Clear();
                            textEnroll.Clear();
                            textDept.Clear();
                            textSemester.Clear();
                            textContact.Clear();
                            textEmail.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Semester! Please enter a value between 1 and 8.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email Address! Please enter a valid email ending with '@gmail.com'.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Contact Number! Please enter a valid contact number starting with '+92' or '03'.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to insert the data! Empty Text Box not Allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RegisterStudent_Load_1(object sender, EventArgs e)
        {

        }
    }
}
