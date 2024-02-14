using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private bool AuthenticateUser(string username, string password, out string userRole, out string enrollmentNumber)
        {
            userRole = "User"; 
            enrollmentNumber = null;
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\A.H Computer\\Desktop\\lms2\\project\\Database1.mdf\"; Integrated Security=True";
            //string connectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"C:\\Users\\hp\\Downloads\\lms2\\project\\Database1.mdf\"; Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT R.Role, L.enroll_no FROM Login L " +
                               "INNER JOIN LoginRoles LR ON L.id = LR.user_id " +
                               "INNER JOIN Roles R ON LR.role_id = R.Role_id " +
                               "WHERE L.username = @username AND L.password = @password";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userRole = reader["Role"].ToString();
                        enrollmentNumber = reader["enroll_no"].ToString();
                        return true;
                    }
                }

                return false; 
            }
        }


        private void Login_Click_1(object sender, EventArgs e)
        {
            string username = UsernameTBox.Text;
            string password = PasswordTbox.Text;

            if (AuthenticateUser(username, password, out string userRole, out string enrollmentNumber))
            {
                if (userRole == "Librarian")
                {
                    MessageBox.Show("You are a librarian.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Open the LibrarianForm
                    Librarian librarianForm = new Librarian();
                    librarianForm.Show();
                }
                else if (userRole == "User")
                {
                    MessageBox.Show($"You are a user with Enrollment No: {enrollmentNumber}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Open the UserForm
                    UserForm userForm = new UserForm(username, password);
                    userForm.Show();
                }
                else
                {
                    MessageBox.Show("Account does not exist or the role is not recognized. Please contact the administrator.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoginButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click_1(sender, e);
            }
        }

        private void PasswordTbox_TextChanged(object sender, EventArgs e)
        {
            PasswordTbox.PasswordChar = '*';
        }

        private void UsernameTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
