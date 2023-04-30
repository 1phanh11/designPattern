namespace FInalProject
{
    partial class IssueBookForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpExpiration = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgStudent = new System.Windows.Forms.PictureBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.cbbBookName = new System.Windows.Forms.ComboBox();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 154);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.txtStatus);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnAddBook);
            this.panel3.Controls.Add(this.txtReaderName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtEmpID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dtpExpiration);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.txtBookID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtRPID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnIssue);
            this.panel3.Controls.Add(this.cbbBookName);
            this.panel3.Controls.Add(this.dtpIssue);
            this.panel3.Controls.Add(this.txtRID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 729);
            this.panel3.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(196, 412);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(216, 27);
            this.txtStatus.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 417);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 74;
            this.label9.Text = "Status";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(533, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 62);
            this.button1.TabIndex = 73;
            this.button1.Text = "Create Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddBook.Location = new System.Drawing.Point(533, 198);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(145, 60);
            this.btnAddBook.TabIndex = 72;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(196, 238);
            this.txtReaderName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(216, 27);
            this.txtReaderName.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Reader Name";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(196, 278);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(216, 27);
            this.txtEmpID.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Emp ID";
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.CustomFormat = "dd-MM-yyy";
            this.dtpExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiration.Location = new System.Drawing.Point(196, 523);
            this.dtpExpiration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(216, 27);
            this.dtpExpiration.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 523);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Expiration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.imgStudent);
            this.panel1.Location = new System.Drawing.Point(533, 312);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 231);
            this.panel1.TabIndex = 65;
            // 
            // imgStudent
            // 
            this.imgStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgStudent.Location = new System.Drawing.Point(0, 0);
            this.imgStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgStudent.Name = "imgStudent";
            this.imgStudent.Size = new System.Drawing.Size(200, 231);
            this.imgStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStudent.TabIndex = 0;
            this.imgStudent.TabStop = false;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(196, 371);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(216, 27);
            this.txtBookID.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Book ID";
            // 
            // txtRPID
            // 
            this.txtRPID.Location = new System.Drawing.Point(196, 120);
            this.txtRPID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRPID.Name = "txtRPID";
            this.txtRPID.Size = new System.Drawing.Size(216, 27);
            this.txtRPID.TabIndex = 61;
            this.txtRPID.TextChanged += new System.EventHandler(this.txtSID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "ID";
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(571, 654);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(163, 35);
            this.btnIssue.TabIndex = 60;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // cbbBookName
            // 
            this.cbbBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBookName.FormattingEnabled = true;
            this.cbbBookName.Location = new System.Drawing.Point(196, 329);
            this.cbbBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbBookName.Name = "cbbBookName";
            this.cbbBookName.Size = new System.Drawing.Size(216, 28);
            this.cbbBookName.TabIndex = 59;
            this.cbbBookName.SelectedIndexChanged += new System.EventHandler(this.cbbBookName_SelectedIndexChanged);
            // 
            // dtpIssue
            // 
            this.dtpIssue.CustomFormat = "dd-MM-yyy";
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssue.Location = new System.Drawing.Point(196, 466);
            this.dtpIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(216, 27);
            this.dtpIssue.TabIndex = 58;
            // 
            // txtRID
            // 
            this.txtRID.Location = new System.Drawing.Point(196, 180);
            this.txtRID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(216, 27);
            this.txtRID.TabIndex = 5;
            this.txtRID.TextChanged += new System.EventHandler(this.txtSName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 466);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Book Issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Book Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Reader ID";
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 883);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IssueBookForm";
            this.Text = "IssueBookForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbBookName;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.TextBox txtRPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgStudent;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddBook;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
    }
}