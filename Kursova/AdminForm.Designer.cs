namespace Kursova
{
    partial class AdminForm
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
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.ListBox();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(368, 363);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(124, 64);
            this.btnRemoveUser.TabIndex = 1;
            this.btnRemoveUser.Text = "Видалити користувача";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(990, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "головна";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.FormattingEnabled = true;
            this.TxtBox.ItemHeight = 20;
            this.TxtBox.Location = new System.Drawing.Point(3, 3);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(359, 424);
            this.TxtBox.TabIndex = 5;
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.ItemHeight = 20;
            this.listBoxTeachers.Location = new System.Drawing.Point(368, 3);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.Size = new System.Drawing.Size(362, 324);
            this.listBoxTeachers.TabIndex = 6;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 20;
            this.listBoxStudents.Location = new System.Drawing.Point(736, 3);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(384, 324);
            this.listBoxStudents.TabIndex = 7;
            // 
            // btnRemoveTeacher
            // 
            this.btnRemoveTeacher.Location = new System.Drawing.Point(514, 363);
            this.btnRemoveTeacher.Name = "btnRemoveTeacher";
            this.btnRemoveTeacher.Size = new System.Drawing.Size(133, 64);
            this.btnRemoveTeacher.TabIndex = 8;
            this.btnRemoveTeacher.Text = "Видалити вчителя";
            this.btnRemoveTeacher.UseVisualStyleBackColor = true;
            this.btnRemoveTeacher.Click += new System.EventHandler(this.btnRemoveTeacher_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(666, 363);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(133, 64);
            this.btnRemoveStudent.TabIndex = 9;
            this.btnRemoveStudent.Text = "Видалення учня";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 442);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnRemoveTeacher);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.listBoxTeachers);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveUser);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnRemoveUser;
        private Button button1;
        private ListBox TxtBox;
        private ListBox listBoxTeachers;
        private ListBox listBoxStudents;
        private Button btnRemoveTeacher;
        private Button btnRemoveStudent;
    }
}