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
    public partial class updateBook : Form
    {
        public updateBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateBook_Load(object sender, EventArgs e)
        {

        }

        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Retrieve the book's title (name) to update from a text box (txtTitleToUpdate)
                string titleToUpdate = textBox1.Text;
                string updateQuery = "UPDATE Book SET title = @NewTitle, price = @NewPrice, author = @NewAuthor, isbn = @NewISBN WHERE title = @TitleToUpdate";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@NewTitle", txtBookTitle.Text);
                    cmd.Parameters.AddWithValue("@NewPrice", txtBookPrice.Text);
                    cmd.Parameters.AddWithValue("@NewAuthor", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@NewISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@TitleToUpdate", titleToUpdate);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // After updating, you can search for the book with the updated information
                        string searchCriteria = txtBookTitle.Text; // Use the updated title to search
                        string searchQuery = "SELECT * FROM Book WHERE title LIKE @SearchCriteria";
                        using (SqlCommand searchCmd = new SqlCommand(searchQuery, conn))
                        {
                            searchCmd.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%"); // The "%" is used for partial matching
                            using (SqlDataAdapter adapter = new SqlDataAdapter(searchCmd))
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
                                    MessageBox.Show("Book not found after update.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Clear the DataGridView
                                    dataGridView1.DataSource = null;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchCriteria = textBox1.Text.Trim(); 
            if (!string.IsNullOrEmpty(searchCriteria))
            {
                //string connectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\hp\\Desktop\\lms2\\project\\Database1.mdf\"; Integrated Security=True";
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";
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

        private void txtBookPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
