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
    public partial class viewBook : Form
    {
        public viewBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\hp\\Downloads\\lms2\\project\\Database1.mdf\"; Integrated Security=True";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Define the SQL query for searching books based on the title (name)
                string query = "SELECT * FROM Book ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Use parameterized queries to avoid SQL injection

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check if any rows were returned
                        if (dataTable.Rows.Count > 0)
                        {
                            // Display the search results in the DataGridView
                            dataGridView1.DataSource = dataTable;

                        }
                        else
                        {
                            MessageBox.Show("Books not Found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear the DataGridView
                            dataGridView1.DataSource = null;

                        }
                    }
                }
            }
        }

        private void viewBook_Load(object sender, EventArgs e)
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
