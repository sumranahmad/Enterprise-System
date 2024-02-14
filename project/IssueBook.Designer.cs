
namespace IssueBook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtEnrollement = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            btnSearch = new Button();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            btnIssueBooks = new Button();
            dateTimePicker = new DateTimePicker();
            txtBookName = new ComboBox();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 128);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(388, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = project.Properties.Resources._10;
            pictureBox1.Location = new Point(281, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(txtEnrollement);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(14, 149);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 388);
            panel2.TabIndex = 1;
            // 
            // txtEnrollement
            // 
            txtEnrollement.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnrollement.Location = new Point(36, 210);
            txtEnrollement.Margin = new Padding(4, 3, 4, 3);
            txtEnrollement.Name = "txtEnrollement";
            txtEnrollement.Size = new Size(244, 22);
            txtEnrollement.TabIndex = 4;
            txtEnrollement.TextChanged += txtEnrollment_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter Enrollement NO";
            label2.Click += label2_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(172, 314);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 43);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(76, 246);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 38);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = project.Properties.Resources._11;
            pictureBox2.Location = new Point(61, 12);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 255);
            panel3.Controls.Add(btnIssueBooks);
            panel3.Controls.Add(dateTimePicker);
            panel3.Controls.Add(txtBookName);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtSemester);
            panel3.Controls.Add(txtDepartment);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(348, 150);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(479, 387);
            panel3.TabIndex = 2;
            // 
            // btnIssueBooks
            // 
            btnIssueBooks.FlatStyle = FlatStyle.Popup;
            btnIssueBooks.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssueBooks.Location = new Point(234, 294);
            btnIssueBooks.Margin = new Padding(4, 3, 4, 3);
            btnIssueBooks.Name = "btnIssueBooks";
            btnIssueBooks.Size = new Size(130, 26);
            btnIssueBooks.TabIndex = 13;
            btnIssueBooks.Text = "Issue Book";
            btnIssueBooks.UseVisualStyleBackColor = true;
            btnIssueBooks.Click += btnIssueBooks_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(183, 250);
            dateTimePicker.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(237, 23);
            dateTimePicker.TabIndex = 12;
            // 
            // txtBookName
            // 
            txtBookName.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBookName.FormattingEnabled = true;
            txtBookName.Location = new Point(183, 205);
            txtBookName.Margin = new Padding(4, 3, 4, 3);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(237, 23);
            txtBookName.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(183, 160);
            txtContact.Margin = new Padding(4, 3, 4, 3);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(237, 23);
            txtContact.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(183, 117);
            txtSemester.Margin = new Padding(4, 3, 4, 3);
            txtSemester.Name = "txtSemester";
            txtSemester.ReadOnly = true;
            txtSemester.Size = new Size(237, 23);
            txtSemester.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(183, 78);
            txtDepartment.Margin = new Padding(4, 3, 4, 3);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(237, 23);
            txtDepartment.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 39);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(237, 23);
            txtName.TabIndex = 7;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(97, 368);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(325, 16);
            label9.TabIndex = 6;
            label9.Text = "*Maximum 3 Books Can be Issued to 1 Student";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(48, 250);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 16);
            label8.TabIndex = 5;
            label8.Text = "Book Issue Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(48, 209);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 16);
            label7.TabIndex = 4;
            label7.Text = "Book Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 164);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 16);
            label6.TabIndex = 3;
            label6.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 2;
            label5.Text = "Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 82);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 16);
            label4.TabIndex = 1;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 16);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(842, 550);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private TextBox txtEnrollement;
        private Label label2;
        private Button btnExit;
        private Button btnSearch;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private TextBox txtName;
        private Button btnIssueBooks;
        private DateTimePicker dateTimePicker;
        private ComboBox txtBookName;
    }
}

