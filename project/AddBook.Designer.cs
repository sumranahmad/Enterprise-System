namespace AddBook
{
    partial class AddBook
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
            groupBox1 = new GroupBox();
            txtAvailableCopies = new TextBox();
            txtTotalCopies = new TextBox();
            txtISBN = new TextBox();
            txtAuthor = new TextBox();
            txtBookPrice = new TextBox();
            txtBookTitle = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(376, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 0;
            label1.Text = "Add Books";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAvailableCopies);
            groupBox1.Controls.Add(txtTotalCopies);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtBookPrice);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(404, 85);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(538, 406);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtAvailableCopies
            // 
            txtAvailableCopies.Location = new Point(180, 247);
            txtAvailableCopies.Margin = new Padding(4, 3, 4, 3);
            txtAvailableCopies.Name = "txtAvailableCopies";
            txtAvailableCopies.Size = new Size(310, 23);
            txtAvailableCopies.TabIndex = 25;
            // 
            // txtTotalCopies
            // 
            txtTotalCopies.Location = new Point(180, 205);
            txtTotalCopies.Margin = new Padding(4, 3, 4, 3);
            txtTotalCopies.Name = "txtTotalCopies";
            txtTotalCopies.Size = new Size(310, 23);
            txtTotalCopies.TabIndex = 24;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(180, 164);
            txtISBN.Margin = new Padding(4, 3, 4, 3);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(310, 23);
            txtISBN.TabIndex = 23;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(180, 119);
            txtAuthor.Margin = new Padding(4, 3, 4, 3);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(310, 23);
            txtAuthor.TabIndex = 22;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Location = new Point(180, 77);
            txtBookPrice.Margin = new Padding(4, 3, 4, 3);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(310, 23);
            txtBookPrice.TabIndex = 21;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(180, 36);
            txtBookTitle.Margin = new Padding(4, 3, 4, 3);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(310, 23);
            txtBookTitle.TabIndex = 20;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(345, 336);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 36);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(219, 336);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 36);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 249);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 5;
            label7.Text = "Available Copies";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 208);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 4;
            label6.Text = "Total Copies";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 3;
            label5.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 121);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 2;
            label4.Text = "Author";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "Book Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "Book Title";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = project.Properties.Resources.download;
            pictureBox1.Location = new Point(14, 96);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AddBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtAvailableCopies;
        private TextBox txtTotalCopies;
        private TextBox txtISBN;
        private TextBox txtAuthor;
        private TextBox txtBookPrice;
        private TextBox txtBookTitle;
        private PictureBox pictureBox1;
    }
}

