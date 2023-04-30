namespace FInalProject
{
    partial class DashBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentInforToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneDashboard = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.bookDetailToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1179, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewBookToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.viewBookToolStripMenuItem.Text = "View Book";
            this.viewBookToolStripMenuItem.Click += new System.EventHandler(this.viewBookToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentInforToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            // 
            // viewStudentInforToolStripMenuItem
            // 
            this.viewStudentInforToolStripMenuItem.Name = "viewStudentInforToolStripMenuItem";
            this.viewStudentInforToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewStudentInforToolStripMenuItem.Text = "View Student Infor";
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookIssueToolStripMenuItem});
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.issueBookToolStripMenuItem.Text = "Book Status";
            // 
            // bookIssueToolStripMenuItem
            // 
            this.bookIssueToolStripMenuItem.Name = "bookIssueToolStripMenuItem";
            this.bookIssueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookIssueToolStripMenuItem.Text = "Book Issue";
            this.bookIssueToolStripMenuItem.Click += new System.EventHandler(this.bookIssueToolStripMenuItem_Click);
            // 
            // bookDetailToolStripMenuItem
            // 
            this.bookDetailToolStripMenuItem.Name = "bookDetailToolStripMenuItem";
            this.bookDetailToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.bookDetailToolStripMenuItem.Text = "Report Detail";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // paneDashboard
            // 
            this.paneDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneDashboard.BackgroundImage")));
            this.paneDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneDashboard.Location = new System.Drawing.Point(0, 30);
            this.paneDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paneDashboard.Name = "paneDashboard";
            this.paneDashboard.Size = new System.Drawing.Size(1179, 756);
            this.paneDashboard.TabIndex = 1;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 786);
            this.Controls.Add(this.paneDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentInforToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel paneDashboard;
        private System.Windows.Forms.ToolStripMenuItem bookIssueToolStripMenuItem;
    }
}