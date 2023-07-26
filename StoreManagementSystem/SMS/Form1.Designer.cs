namespace SMS
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControl21 = new SMS.UserControl2();
            this.userControl11 = new SMS.UserControl1();
            this.selfNaveBar1 = new SMS.SelfNaveBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl21);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Location = new System.Drawing.Point(243, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 336);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selfNaveBar1);
            this.panel2.Location = new System.Drawing.Point(29, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 424);
            this.panel2.TabIndex = 3;
            // 
            // userControl21
            // 
            this.userControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(533, 336);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(533, 336);
            this.userControl11.TabIndex = 0;
            // 
            // selfNaveBar1
            // 
            this.selfNaveBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selfNaveBar1.Location = new System.Drawing.Point(0, 0);
            this.selfNaveBar1.Name = "selfNaveBar1";
            this.selfNaveBar1.Size = new System.Drawing.Size(150, 424);
            this.selfNaveBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private System.Windows.Forms.Panel panel2;
        private SelfNaveBar selfNaveBar1;
    }
}

