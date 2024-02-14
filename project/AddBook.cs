using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddBook
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text != "" && txtBookPrice.Text != "" && txtAuthor.Text != "" && txtISBN.Text != "" && txtTotalCopies.Text != "" && txtAvailableCopies.Text != "")
            {
                String bTitle = txtBookTitle.Text;
                Int64 bPrice = Int64.Parse(txtBookPrice.Text);
                String bAuthor = txtAuthor.Text;
                String bISBN = txtISBN.Text;
                Int64 bCopies = Int64.Parse(txtTotalCopies.Text);
                Int64 availabeBooks = Int64.Parse(txtAvailableCopies.Text);
                string cleanISBN = bISBN.Replace("-", "").Trim();
                // Remove non-digit characters from the ISBN
                cleanISBN = new string(cleanISBN.Where(char.IsDigit).ToArray());
                if (cleanISBN.Length == 13 && cleanISBN.StartsWith("978"))
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\";Integrated Security=True";
                    //conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Desktop\\lmsss\\project\\Database1.mdf;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "INSERT INTO Book(title, price, author, isbn, total_copies, available_copies) VALUES('" + bTitle + "','" + bPrice + "','" + bAuthor + "','" + bISBN + "','" + bCopies + "','" + availabeBooks + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookTitle.Clear();
                    txtBookPrice.Clear();
                    txtAuthor.Clear();
                    txtISBN.Clear();
                    txtTotalCopies.Clear();
                    txtAvailableCopies.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid ISBN! It should be 13 characters long and start with '978'.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to insert the data! Empty Text Box not Allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
