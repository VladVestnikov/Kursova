namespace Kursova
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.buttonHome = new System.Windows.Forms.Button();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkRegistr = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonHome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHome.Location = new System.Drawing.Point(854, 625);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(239, 74);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "УВІЙТИ";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(877, 423);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(184, 27);
            this.Name1.TabIndex = 1;
            this.Name1.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(877, 503);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(184, 27);
            this.Password.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1902, 1033);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(877, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(877, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // linkRegistr
            // 
            this.linkRegistr.AutoSize = true;
            this.linkRegistr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkRegistr.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkRegistr.Location = new System.Drawing.Point(690, 788);
            this.linkRegistr.Name = "linkRegistr";
            this.linkRegistr.Size = new System.Drawing.Size(195, 31);
            this.linkRegistr.TabIndex = 4;
            this.linkRegistr.TabStop = true;
            this.linkRegistr.Text = "Зареєструватися";
            this.linkRegistr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistr_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 92);
            this.button1.TabIndex = 5;
            this.button1.Text = "Головна";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkRegistr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Log";
            this.Text = "Log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Log_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonHome;
        private TextBox Name1;
        private TextBox Password;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private LinkLabel linkRegistr;
        private Button button1;
    }
}