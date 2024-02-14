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
    public partial class deleteBook : Form
    {
        public deleteBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void deleteBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string bookTitleToDelete = textBox1.Text; // You can use the title or another identifier to delete the book

            if (!string.IsNullOrEmpty(bookTitleToDelete))
            {
                SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\hp\\Desktop\\lms2\\project\\Database1.mdf\"; Integrated Security=True";
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                conn.Open();

                // Use a SQL DELETE statement to remove the book based on the provided identifier (e.g., title)
                cmd.CommandText = "DELETE FROM Book WHERE title = '" + bookTitleToDelete + "'";

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Book not found or deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the title of the book you want to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
