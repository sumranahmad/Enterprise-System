namespace project
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            menuStrip1 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            viewInfoToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 128, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewInfoToolStripMenuItem });
            studentToolStripMenuItem.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            studentToolStripMenuItem.ForeColor = Color.FromArgb(192, 64, 0);
            studentToolStripMenuItem.Image = Properties.Resources._14;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(117, 34);
            studentToolStripMenuItem.Text = "Student";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // viewInfoToolStripMenuItem
            // 
            viewInfoToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            viewInfoToolStripMenuItem.ForeColor = Color.Blue;
            viewInfoToolStripMenuItem.Image = Properties.Resources._7;
            viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            viewInfoToolStripMenuItem.Size = new Size(180, 24);
            viewInfoToolStripMenuItem.Text = "View Info";
            viewInfoToolStripMenuItem.Click += viewInfoToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            exitToolStripMenuItem.ForeColor = Color.Purple;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(62, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = Color.AntiqueWhite;
            MainMenuStrip = menuStrip1;
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem viewInfoToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}