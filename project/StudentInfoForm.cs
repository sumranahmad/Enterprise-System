using System;
using System.Windows.Forms;
using System.Collections.Generic; 
using System.Data.SqlClient;
using System.Data;

namespace project
{
    public partial class StudentInfoForm : Form
    {
        private List<string> LoggedInEnrollments;
        public StudentInfoForm()
        {
            InitializeComponent();

            // Define DataGridView columns in the constructor
            dataGridView1.Columns.Add("Enrollment", "Enrollment");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("Semester", "Semester");
            dataGridView1.Columns.Add("Department", "Department");
            dataGridView1.Columns.Add("BookName", "Book Name");
            dataGridView1.Columns.Add("IssueDate", "Issue Date");
            dataGridView1.Columns.Add("returnDate", "Return Date");
        }

        public void PopulateData(List<UserForm.BookInfo> bookInfoList)
        {
            dataGridView1.Rows.Clear();
            foreach (var bookInfo in bookInfoList)
            {
                // Add a row to the DataGridView with data from each BookInfo object
                dataGridView1.Rows.Add(
                    bookInfo.Enrollment,
                    bookInfo.StudentName,
                    bookInfo.Semester,
                    bookInfo.Department,
                    bookInfo.BookName,
                    bookInfo.IssueDate,
                    bookInfo.returnDate
                );
            }
        }

        public void SetLoggedInEnrollments(List<string> enrollments)
        {
            LoggedInEnrollments = enrollments;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            LoadFinesForLoggedInUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void LoadFinesForLoggedInUsers()
        {
            if (LoggedInEnrollments != null && LoggedInEnrollments.Count > 0)
            {
                //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Downloads\\lms2 (1)\\lms2\\project\\Database1.mdf;Integrated Security=True";
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf;Integrated Security=True";
                string enrollmentsCondition = string.Join(",", LoggedInEnrollments.Select(enrollment => $"'{enrollment}'"));

                string query = $"SELECT IRBook.std_name, (DATEDIFF(day, IRBook.book_return_date, GETDATE()) * 10) AS fine " +
                                $"FROM IRBook " +
                                $"WHERE IRBook.std_enroll IN ({enrollmentsCondition}) AND " +
                                $"IRBook.book_return_date IS NOT NULL AND IRBook.book_return_date < GETDATE()";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                dataGridView2.DataSource = dataTable;
                            }
                            else
                            {
                                dataGridView2.DataSource = null;
                            }
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



