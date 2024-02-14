using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace IssueBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\A.H Computer\Desktop\lms2\project\Database1.mdf;Integrated Security=True";
            //conn.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\hp\\Downloads\\lms2 (1)\\lms2\\project\\Database1.mdf\"; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand("select title from Book", conn);
            SqlDataReader Sdr = cmd.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {

                    txtBookName.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();

            conn.Close();
        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollement.Text != "")
            {
                String eid = txtEnrollement.Text;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\A.H Computer\Desktop\lms2\project\Database1.mdf;Integrated Security=True";
                //conn.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\hp\\Downloads\\lms2 (1)\\lms2\\project\\Database1.mdf\"; Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from AddStudent where enroll='" + eid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                //------------------ Filter Student Data through enroll number  ----------
                cmd.CommandText = "SELECT COUNT(std_enroll) FROM IRBook WHERE std_enroll = '" + eid + "'";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);
                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();

                }
                else
                {
                    txtName.Clear();
                    txtDepartment.Clear();
                    txtSemester.Clear();
                    txtContact.Clear();

                    MessageBox.Show("Invalid Enrollment Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (txtBookName.SelectedIndex != -1)
                {
                    // Get the enrollment ID
                    String enroll = txtEnrollement.Text;

                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\A.H Computer\Desktop\lms2\project\Database1.mdf;Integrated Security=True"))
                    {
                        conn.Open();

                        // Check if the same book is already issued and not returned to the student
                        using (SqlCommand cmdCheckBook = new SqlCommand("SELECT COUNT(*) FROM IRBook WHERE std_enroll = @enroll AND book_name = @bookname ", conn))
                        {
                            cmdCheckBook.Parameters.AddWithValue("@enroll", enroll);
                            cmdCheckBook.Parameters.AddWithValue("@bookname", txtBookName.Text);

                            int existingIssuedBooks = (int)cmdCheckBook.ExecuteScalar();

                            if (existingIssuedBooks > 0)
                            {
                                MessageBox.Show("This book is already issued to the student", "Duplicate Book Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; 
                            }
                        }

                        // Count the number of books issued to the same enrollment ID
                        using (SqlCommand cmdCountBooks = new SqlCommand("SELECT COUNT(*) FROM IRBook WHERE std_enroll = @enroll", conn))
                        {
                            cmdCountBooks.Parameters.AddWithValue("@enroll", enroll);

                            int currentlyIssuedBooks = (int)cmdCountBooks.ExecuteScalar();
                            if (currentlyIssuedBooks >= 3)
                            {
                                MessageBox.Show("Maximum Number of Books Issued (3) for this Enrollment ID", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; 
                            }
                        }
                        String sname = txtName.Text;
                        String sdep = txtDepartment.Text;
                        String sem = txtSemester.Text;
                        Int64 contact = Int64.Parse(txtContact.Text);
                        String bookname = txtBookName.Text;
                        String bookIssueDate = dateTimePicker.Text;

                        // Calculate the return date as 14 days after the issue date
                        DateTime issueDate = DateTime.Parse(bookIssueDate);
                        DateTime returnDate = issueDate.AddDays(14);

                        using (SqlCommand cmdIssueBook = new SqlCommand("INSERT INTO IRBook(std_enroll, std_name, std_dep, std_sem, std_contact, book_name, book_issue_date, book_return_date) VALUES(@enroll, @sname, @sdep, @sem, @contact, @bookname, @bookIssueDate, @returnDate)", conn))
                        {
                            cmdIssueBook.Parameters.AddWithValue("@enroll", enroll);
                            cmdIssueBook.Parameters.AddWithValue("@sname", sname);
                            cmdIssueBook.Parameters.AddWithValue("@sdep", sdep);
                            cmdIssueBook.Parameters.AddWithValue("@sem", sem);
                            cmdIssueBook.Parameters.AddWithValue("@contact", contact);
                            cmdIssueBook.Parameters.AddWithValue("@bookname", bookname);
                            cmdIssueBook.Parameters.AddWithValue("@bookIssueDate", bookIssueDate);
                            cmdIssueBook.Parameters.AddWithValue("@returnDate", returnDate.ToString("yyyy-MM-dd"));

                            cmdIssueBook.ExecuteNonQuery();
                            MessageBox.Show($"Book Issued and Your Return Date will be {returnDate}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select Book", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollement.Text != "")
            {
                txtName.Clear();
                txtDepartment.Clear();
                txtSemester.Clear();
                txtContact.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                this.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
