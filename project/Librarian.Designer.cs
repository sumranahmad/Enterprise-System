namespace project
{
    partial class Librarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librarian));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            viewBookToolStripMenuItem = new ToolStripMenuItem();
            deleteBookToolStripMenuItem = new ToolStripMenuItem();
            updateBookToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            issueBookToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            detailBookToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            registerStudentToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, issueBookToolStripMenuItem, returnBookToolStripMenuItem, detailBookToolStripMenuItem, studentToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(911, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, viewBookToolStripMenuItem, deleteBookToolStripMenuItem, updateBookToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(101, 34);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.BackColor = Color.Wheat;
            addBookToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBookToolStripMenuItem.Image = (Image)resources.GetObject("addBookToolStripMenuItem.Image");
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(182, 26);
            addBookToolStripMenuItem.Text = "Add Book";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // viewBookToolStripMenuItem
            // 
            viewBookToolStripMenuItem.BackColor = Color.Wheat;
            viewBookToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            viewBookToolStripMenuItem.Image = (Image)resources.GetObject("viewBookToolStripMenuItem.Image");
            viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            viewBookToolStripMenuItem.Size = new Size(182, 26);
            viewBookToolStripMenuItem.Text = "Search Book";
            viewBookToolStripMenuItem.Click += viewBookToolStripMenuItem_Click;
            // 
            // deleteBookToolStripMenuItem
            // 
            deleteBookToolStripMenuItem.BackColor = Color.Wheat;
            deleteBookToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBookToolStripMenuItem.Image = (Image)resources.GetObject("deleteBookToolStripMenuItem.Image");
            deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            deleteBookToolStripMenuItem.Size = new Size(182, 26);
            deleteBookToolStripMenuItem.Text = "Delete Book";
            deleteBookToolStripMenuItem.Click += deleteBookToolStripMenuItem_Click;
            // 
            // updateBookToolStripMenuItem
            // 
            updateBookToolStripMenuItem.BackColor = Color.Wheat;
            updateBookToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateBookToolStripMenuItem.Image = (Image)resources.GetObject("updateBookToolStripMenuItem.Image");
            updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            updateBookToolStripMenuItem.Size = new Size(182, 26);
            updateBookToolStripMenuItem.Text = "Update Book";
            updateBookToolStripMenuItem.Click += updateBookToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.BackColor = Color.Wheat;
            viewBooksToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(182, 26);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click_1;
            // 
            // issueBookToolStripMenuItem
            // 
            issueBookToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            issueBookToolStripMenuItem.Image = (Image)resources.GetObject("issueBookToolStripMenuItem.Image");
            issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            issueBookToolStripMenuItem.Size = new Size(147, 34);
            issueBookToolStripMenuItem.Text = "Issue Book";
            issueBookToolStripMenuItem.Click += issueBookToolStripMenuItem_Click;
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            returnBookToolStripMenuItem.Image = (Image)resources.GetObject("returnBookToolStripMenuItem.Image");
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(164, 34);
            returnBookToolStripMenuItem.Text = "Return Book";
            returnBookToolStripMenuItem.Click += returnBookToolStripMenuItem_Click;
            // 
            // detailBookToolStripMenuItem
            // 
            detailBookToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            detailBookToolStripMenuItem.Image = (Image)resources.GetObject("detailBookToolStripMenuItem.Image");
            detailBookToolStripMenuItem.Name = "detailBookToolStripMenuItem";
            detailBookToolStripMenuItem.Size = new Size(155, 34);
            detailBookToolStripMenuItem.Text = "Detail Book";
            detailBookToolStripMenuItem.Click += detailBookToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerStudentToolStripMenuItem });
            studentToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            studentToolStripMenuItem.Image = Properties.Resources._141;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(118, 34);
            studentToolStripMenuItem.Text = "Student";
            // 
            // registerStudentToolStripMenuItem
            // 
            registerStudentToolStripMenuItem.Image = Properties.Resources._132;
            registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            registerStudentToolStripMenuItem.Size = new Size(248, 34);
            registerStudentToolStripMenuItem.Text = "Register Student";
            registerStudentToolStripMenuItem.Click += registerStudentToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(78, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Librarian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._16;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 450);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "Librarian";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librarian";
            Load += Librarian_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem issueBookToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem viewBookToolStripMenuItem;
        private ToolStripMenuItem deleteBookToolStripMenuItem;
        private ToolStripMenuItem updateBookToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem registerStudentToolStripMenuItem;
        private ToolStripMenuItem detailBookToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
    }
}