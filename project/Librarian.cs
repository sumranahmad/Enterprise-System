using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook.AddBook add = new AddBook.AddBook();
            add.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchBook viewBooksForm = new searchBook();
            viewBooksForm.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook.Form1 issueBook = new IssueBook.Form1();
            issueBook.Show();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteBook delBook = new deleteBook();
            delBook.Show();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateBook upbook = new updateBook();
            upbook.Show();
        }

        private void Librarian_Load(object sender, EventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent st = new RegisterStudent();
            st.Show();
        }

        private void detailBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookDetail bkDetail = new bookDetail();
            bkDetail.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewBooksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            viewBook viewBook = new viewBook();
            viewBook.Show();

        }
    }
}
