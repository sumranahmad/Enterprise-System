using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic; 

namespace project
{
    public partial class UserForm : Form
    {
        private string currentUserEnroll = null;
        private string username = null;
        private string password = null;

        public UserForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            currentUserEnroll = GetEnrollNumberForUser(username, password);
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent st = new RegisterStudent();
            st.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentUserEnroll))
            {
                List<BookInfo> bookInfoList = GetBookInfoForEnroll(currentUserEnroll); // Use List<BookInfo>

                if (bookInfoList.Count > 0)
                {
                    StudentInfoForm studentInfoForm = new StudentInfoForm();

                    // Populate the DataGridView in the StudentInfoForm with the data.
                    studentInfoForm.PopulateData(bookInfoList);
                    // Show the StudentInfoForm.
                    List<string> enrolledNumbers = bookInfoList.Select(info => info.Enrollment).ToList();
                    studentInfoForm.SetLoggedInEnrollments(enrolledNumbers);
                    studentInfoForm.Show();
                }
                else
                {
                    MessageBox.Show("No records found for the current user's enrollment.");
                }
            }
            else
            {
                MessageBox.Show("User not logged in or no enrollment available.");
            }
        }

        private string GetEnrollNumberForUser(string username, string password)
        {
            string enroll = null;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\A.H Computer\Desktop\lms2\project\Database1.mdf;Integrated Security=True";
            //string connectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\hp\\Downloads\\lms2 (1)\\lms2\\project\\Database1.mdf\"; Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT enroll_no FROM login WHERE Username = @Username AND Password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            enroll = reader["enroll_no"].ToString();
                        }
                    }
                }
            }

            return enroll;
        }

        private List<BookInfo> GetBookInfoForEnroll(string enroll)
        {
            List<BookInfo> bookInfoList = new List<BookInfo>();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\A.H Computer\Desktop\lms2\project\Database1.mdf;Integrated Security=True";
            //string connectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\hp\\Downloads\\lms2 (1)\\lms2\\project\\Database1.mdf\"; Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT std_enroll, std_name, std_sem, std_dep, book_name, book_issue_date,book_return_date FROM IRBook WHERE std_enroll = @enroll";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@enroll", enroll);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookInfoList.Add(new BookInfo
                            {
                                Enrollment = reader["std_enroll"].ToString(),
                                StudentName = reader["std_name"].ToString(),
                                Semester = reader["std_sem"].ToString(),
                                Department = reader["std_dep"].ToString(),
                                BookName = reader["book_name"].ToString(),
                                IssueDate = reader["book_issue_date"].ToString(),
                                returnDate = reader["book_return_date"].ToString()
                            });
                        }
                    }
                }
            }

            return bookInfoList;
        }

        public class BookInfo
        {
            public string Enrollment { get; set; }
            public string StudentName { get; set; }
            public string Semester { get; set; }
            public string Department { get; set; }
            public string BookName { get; set; }
            public string IssueDate { get; set; }

            public string returnDate { get; set; }

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
