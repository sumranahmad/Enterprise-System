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

namespace project
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int count;
        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchCriteria = textBox1.Text.Trim(); // get enroll no from user 
            if (!string.IsNullOrEmpty(searchCriteria))
            {
                //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\hp\\Downloads\\lms2 (1)\\lms2\\project\\Database1.mdf\"; Integrated Security=True";
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM IRBook WHERE std_enroll LIKE @SearchCriteria";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%"); // The "%" is used for partial matching
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                // Display the search results in the DataGridView
                                dataGridView1.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("Student not Found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Clear the DataGridView
                                dataGridView1.DataSource = null;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a search criteria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string enrollment = textBox1.Text;
                string bookName = textBox2.Text;
                SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Downloads\\lms2 (1)\\lms2\\project\\Database1.mdf;Integrated Security=True";
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                // Check if the book was issued to the student
                cmd.CommandText = "SELECT * FROM IRBook WHERE std_enroll = '" + enrollment + "' AND book_name = '" + bookName + "' AND book_return_date IS NOT NULL";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DateTime issueDate = Convert.ToDateTime(reader["book_issue_date"]);
                    DateTime returnDate = Convert.ToDateTime(reader["book_return_date"]);

                    // Calculate the fine based on the return date and current date
                    TimeSpan overdue = DateTime.Now - returnDate;
                    int daysOverdue = overdue.Days;

                    int finePerDay = 10; // Set your fine amount per day here
                    int totalFine = daysOverdue * finePerDay;

                    if (daysOverdue <= 0)
                    {
                        MessageBox.Show($"Book '{bookName}' is returned on time. No fine is applicable.", "Fine Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Book '{bookName}' is returned {daysOverdue} days late. Student has to pay a fine of {totalFine} RS.", "Fine Calculation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    reader.Close();
                    // Delete the record for the returned book
                    cmd.CommandText = "DELETE FROM IRBook WHERE std_enroll = '" + enrollment + "' AND book_name = '" + bookName + "' AND book_return_date = '" + returnDate.ToString("yyyy-MM-dd") + "'";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("The book is not issued to this student or has not yet been returned.", "Return Book Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Enter a valid Enrollment Number.", "Invalid Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                this.Close();
            }
        }
    }

}
