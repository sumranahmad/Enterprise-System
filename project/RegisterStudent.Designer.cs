namespace project
{
    partial class RegisterStudent
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
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnRefresh = new Button();
            textEmail = new TextBox();
            textContact = new TextBox();
            textSemester = new TextBox();
            textDept = new TextBox();
            textEnroll = new TextBox();
            textName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(339, 35);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8;
            pictureBox1.Location = new Point(233, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._9;
            pictureBox2.Location = new Point(-1, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 333);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(textEmail);
            panel2.Controls.Add(textContact);
            panel2.Controls.Add(textSemester);
            panel2.Controls.Add(textDept);
            panel2.Controls.Add(textEnroll);
            panel2.Controls.Add(textName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(177, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 333);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(394, 252);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(295, 252);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(202, 252);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(175, 193);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(249, 23);
            textEmail.TabIndex = 11;
            // 
            // textContact
            // 
            textContact.Location = new Point(175, 155);
            textContact.Name = "textContact";
            textContact.Size = new Size(249, 23);
            textContact.TabIndex = 10;
            // 
            // textSemester
            // 
            textSemester.Location = new Point(175, 121);
            textSemester.Name = "textSemester";
            textSemester.Size = new Size(249, 23);
            textSemester.TabIndex = 9;
            // 
            // textDept
            // 
            textDept.Location = new Point(175, 91);
            textDept.Name = "textDept";
            textDept.Size = new Size(249, 23);
            textDept.TabIndex = 8;
            // 
            // textEnroll
            // 
            textEnroll.Location = new Point(175, 56);
            textEnroll.Name = "textEnroll";
            textEnroll.Size = new Size(249, 23);
            textEnroll.TabIndex = 7;
            // 
            // textName
            // 
            textName.Location = new Point(175, 21);
            textName.Name = "textName";
            textName.Size = new Size(249, 23);
            textName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(43, 193);
            label7.Name = "label7";
            label7.Size = new Size(94, 17);
            label7.TabIndex = 5;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(43, 156);
            label6.Name = "label6";
            label6.Size = new Size(107, 17);
            label6.TabIndex = 4;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(43, 121);
            label5.Name = "label5";
            label5.Size = new Size(116, 17);
            label5.TabIndex = 3;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 91);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 62);
            label3.Name = "label3";
            label3.Size = new Size(98, 17);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 27);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 428);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "RegisterStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            Load += RegisterStudent_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textSemester;
        private TextBox textDept;
        private TextBox textEnroll;
        private TextBox textName;
        private TextBox textEmail;
        private TextBox textContact;
        private Button btnExit;
        private Button btnSave;
        private Button btnRefresh;
    }
}