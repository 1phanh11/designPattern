namespace FInalProject
{
    partial class AddStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imgStudent = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.txtIdReader = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(240, 169);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(391, 27);
            this.txtStudentName.TabIndex = 7;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(240, 431);
            this.txtStudentEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(391, 27);
            this.txtStudentEmail.TabIndex = 11;
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Location = new System.Drawing.Point(240, 366);
            this.txtStudentPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Size = new System.Drawing.Size(391, 27);
            this.txtStudentPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(240, 298);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(391, 27);
            this.txtAddress.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(287, 789);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(97, 789);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(469, 789);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imgStudent
            // 
            this.imgStudent.Location = new System.Drawing.Point(0, 0);
            this.imgStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgStudent.Name = "imgStudent";
            this.imgStudent.Size = new System.Drawing.Size(200, 231);
            this.imgStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStudent.TabIndex = 15;
            this.imgStudent.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(307, 586);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(100, 35);
            this.btnImage.TabIndex = 16;
            this.btnImage.Text = "Upload Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.imgStudent);
            this.panel1.Location = new System.Drawing.Point(16, 512);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 231);
            this.panel1.TabIndex = 17;
            // 
            // cbbGender
            // 
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbbGender.Location = new System.Drawing.Point(240, 242);
            this.cbbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(160, 28);
            this.cbbGender.TabIndex = 20;
            // 
            // txtIdReader
            // 
            this.txtIdReader.Location = new System.Drawing.Point(240, 116);
            this.txtIdReader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdReader.Name = "txtIdReader";
            this.txtIdReader.Size = new System.Drawing.Size(391, 27);
            this.txtIdReader.TabIndex = 7;
            this.txtIdReader.Visible = false;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 878);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtStudentPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIdReader);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtStudentName;
        public System.Windows.Forms.TextBox txtStudentEmail;
        public System.Windows.Forms.TextBox txtStudentPhone;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox imgStudent;
        public System.Windows.Forms.ComboBox cbbGender;
        public TextBox txtIdReader;
    }
}