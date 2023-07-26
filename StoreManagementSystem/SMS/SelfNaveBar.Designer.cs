namespace SMS
{
    partial class SelfNaveBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navBtnMove = new System.Windows.Forms.Button();
            this.beMovedBtn = new System.Windows.Forms.Button();
            this.hideBtn2 = new System.Windows.Forms.Button();
            this.hideBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navBtnMove
            // 
            this.navBtnMove.Location = new System.Drawing.Point(0, 0);
            this.navBtnMove.Name = "navBtnMove";
            this.navBtnMove.Size = new System.Drawing.Size(150, 49);
            this.navBtnMove.TabIndex = 0;
            this.navBtnMove.Text = "Move button2";
            this.navBtnMove.UseVisualStyleBackColor = true;
            this.navBtnMove.Click += new System.EventHandler(this.navBtnMove_Click);
            // 
            // beMovedBtn
            // 
            this.beMovedBtn.Location = new System.Drawing.Point(0, 45);
            this.beMovedBtn.Name = "beMovedBtn";
            this.beMovedBtn.Size = new System.Drawing.Size(150, 49);
            this.beMovedBtn.TabIndex = 1;
            this.beMovedBtn.Text = "button2";
            this.beMovedBtn.UseVisualStyleBackColor = true;
            // 
            // hideBtn2
            // 
            this.hideBtn2.Location = new System.Drawing.Point(0, 91);
            this.hideBtn2.Name = "hideBtn2";
            this.hideBtn2.Size = new System.Drawing.Size(150, 49);
            this.hideBtn2.TabIndex = 2;
            this.hideBtn2.Text = "hide222222";
            this.hideBtn2.UseVisualStyleBackColor = true;
            // 
            // hideBtn1
            // 
            this.hideBtn1.Location = new System.Drawing.Point(0, 45);
            this.hideBtn1.Name = "hideBtn1";
            this.hideBtn1.Size = new System.Drawing.Size(150, 49);
            this.hideBtn1.TabIndex = 3;
            this.hideBtn1.Text = "hide1";
            this.hideBtn1.UseVisualStyleBackColor = true;
            this.hideBtn1.Click += new System.EventHandler(this.hideBtn1_Click);
            // 
            // SelfNaveBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.beMovedBtn);
            this.Controls.Add(this.navBtnMove);
            this.Controls.Add(this.hideBtn1);
            this.Controls.Add(this.hideBtn2);
            this.Name = "SelfNaveBar";
            this.Size = new System.Drawing.Size(150, 424);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button navBtnMove;
        private System.Windows.Forms.Button beMovedBtn;
        private System.Windows.Forms.Button hideBtn2;
        private System.Windows.Forms.Button hideBtn1;
    }
}
