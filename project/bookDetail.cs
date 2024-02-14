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
    public partial class bookDetail : Form
    {
        public bookDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Downloads\\lms2 (1)\\lms2\\project\\Database1.mdf;Integrated Security=True";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM IRBook ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
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

        private void button2_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Downloads\\lms2 (1)\\lms2\\project\\Database1.mdf;Integrated Security=True";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a custom query to select the student's name and calculate the fine
                string query = "SELECT IRBook.std_name as Name, IRBook.book_name as Book, (DATEDIFF(day, IRBook.book_return_date, GETDATE()) * 10) AS fine " +
                               "FROM IRBook " +
                               "WHERE IRBook.book_return_date IS NOT NULL AND IRBook.book_return_date < GETDATE()";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            // Display the search results in the DataGridView
                            dataGridView2.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No fines found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear the DataGridView
                            dataGridView2.DataSource = null;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void bookDetail_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
