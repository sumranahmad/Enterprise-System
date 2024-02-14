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
    public partial class searchBook : Form
    {
        public searchBook()
        {
            InitializeComponent();
        }

        private void viewBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchCriteria = textBox1.Text.Trim(); // Get the search criteria from the text box

            if (!string.IsNullOrEmpty(searchCriteria))
            {
                string connectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\"; Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Book WHERE title LIKE @SearchCriteria";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%"); // The "%" is used for partial matching
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("Book not Found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
