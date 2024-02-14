namespace project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            UsernameTBox = new TextBox();
            label3 = new Label();
            PasswordTbox = new TextBox();
            Login = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(188, 22);
            label1.Name = "label1";
            label1.Size = new Size(388, 35);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_949118068_612x612;
            pictureBox1.Location = new Point(287, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 154);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            label2.Click += label2_Click;
            // 
            // UsernameTBox
            // 
            UsernameTBox.Location = new Point(12, 189);
            UsernameTBox.Multiline = true;
            UsernameTBox.Name = "UsernameTBox";
            UsernameTBox.Size = new Size(179, 34);
            UsernameTBox.TabIndex = 3;
            UsernameTBox.TextChanged += UsernameTBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 241);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // PasswordTbox
            // 
            PasswordTbox.Location = new Point(12, 279);
            PasswordTbox.Multiline = true;
            PasswordTbox.Name = "PasswordTbox";
            PasswordTbox.Size = new Size(179, 34);
            PasswordTbox.TabIndex = 6;
            PasswordTbox.TextChanged += PasswordTbox_TextChanged;
            // 
            // Login
            // 
            Login.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.Black;
            Login.Location = new Point(65, 332);
            Login.Name = "Login";
            Login.Size = new Size(91, 38);
            Login.TabIndex = 7;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click_1;
            Login.KeyUp += LoginButton_KeyUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.profile_icon_login_head_icon_vector;
            pictureBox2.Location = new Point(44, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AcceptButton = Login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(Login);
            Controls.Add(PasswordTbox);
            Controls.Add(label3);
            Controls.Add(UsernameTBox);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.DodgerBlue;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox UsernameTBox;
        private TextBox PasswordTbox;
        internal Label label3;
        private Button Login;
        private PictureBox pictureBox2;
    }
}