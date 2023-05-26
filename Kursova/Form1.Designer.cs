namespace Kursova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogaut = new System.Windows.Forms.Button();
            this.RagAndLog = new System.Windows.Forms.ComboBox();
            this.buttonGuest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1902, 1033);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogaut
            // 
            this.buttonLogaut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogaut.BackgroundImage")));
            this.buttonLogaut.Location = new System.Drawing.Point(774, 957);
            this.buttonLogaut.Name = "buttonLogaut";
            this.buttonLogaut.Size = new System.Drawing.Size(373, 76);
            this.buttonLogaut.TabIndex = 2;
            this.buttonLogaut.UseVisualStyleBackColor = true;
            this.buttonLogaut.Click += new System.EventHandler(this.buttonLogaut_Click);
            // 
            // RagAndLog
            // 
            this.RagAndLog.FormattingEnabled = true;
            this.RagAndLog.Location = new System.Drawing.Point(1687, 30);
            this.RagAndLog.Name = "RagAndLog";
            this.RagAndLog.Size = new System.Drawing.Size(80, 28);
            this.RagAndLog.TabIndex = 3;
            this.RagAndLog.Text = "Вхід";
            this.RagAndLog.SelectedIndexChanged += new System.EventHandler(this.RagAndLog_SelectedIndexChanged);
            // 
            // buttonGuest
            // 
            this.buttonGuest.Location = new System.Drawing.Point(1797, 29);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(54, 29);
            this.buttonGuest.TabIndex = 4;
            this.buttonGuest.Text = "Гість";
            this.buttonGuest.UseVisualStyleBackColor = true;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.buttonGuest);
            this.Controls.Add(this.RagAndLog);
            this.Controls.Add(this.buttonLogaut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonLogaut;
        private ComboBox RagAndLog;
        private Button buttonGuest;
    }
}