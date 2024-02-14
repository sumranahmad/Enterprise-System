namespace project
{
    partial class updateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateBook));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
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
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 203);
            label1.Name = "label1";
            label1.Size = new Size(180, 17);
            label1.TabIndex = 1;
            label1.Text = "Enter Book Name to Update";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 130);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 2;
            label2.Text = "Update Book";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 235);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 43);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 348);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(801, 104);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(256, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(531, 298);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
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
            txtISBN.Location = new Point(180, 163);
            txtISBN.Margin = new Padding(4, 3, 4, 3);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(310, 23);
            txtISBN.TabIndex = 23;
            txtISBN.TextChanged += txtISBN_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(180, 119);
            txtAuthor.Margin = new Padding(4, 3, 4, 3);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(310, 23);
            txtAuthor.TabIndex = 22;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Location = new Point(180, 80);
            txtBookPrice.Margin = new Padding(4, 3, 4, 3);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(310, 23);
            txtBookPrice.TabIndex = 21;
            txtBookPrice.TextChanged += txtBookPrice_TextChanged;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(180, 36);
            txtBookTitle.Margin = new Padding(4, 3, 4, 3);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(310, 23);
            txtBookTitle.TabIndex = 20;
            txtBookTitle.TextChanged += txtBookTitle_TextChanged;
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
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(29, 249);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 17);
            label7.TabIndex = 5;
            label7.Text = "Available Copies";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 208);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 17);
            label6.TabIndex = 4;
            label6.Text = "Total Copies";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 3;
            label5.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 121);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 2;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 1;
            label3.Text = "Book Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 38);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 0;
            label8.Text = "Book Title";
            // 
            // button1
            // 
            button1.Location = new Point(555, 310);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 26;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(74, 287);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 27;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(695, 311);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 28;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // updateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "updateBook";
            Text = "updateBook";
            Load += updateBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtAvailableCopies;
        private TextBox txtTotalCopies;
        private TextBox txtISBN;
        private TextBox txtAuthor;
        private TextBox txtBookPrice;
        private TextBox txtBookTitle;
        private Button btnCancel;
        private Button btnSave;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}