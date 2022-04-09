namespace WindowsFormsLab_5_0
{
    partial class ForgotPass
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
            this.Forgot_B = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Forgot_B
            // 
            this.Forgot_B.Location = new System.Drawing.Point(71, 89);
            this.Forgot_B.Name = "Forgot_B";
            this.Forgot_B.Size = new System.Drawing.Size(123, 23);
            this.Forgot_B.TabIndex = 8;
            this.Forgot_B.Text = "Send email";
            this.Forgot_B.UseVisualStyleBackColor = true;
            this.Forgot_B.Click += new System.EventHandler(this.Forgot_B_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email:";
            // 
            // Email_TB
            // 
            this.Email_TB.Location = new System.Drawing.Point(43, 52);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(205, 20);
            this.Email_TB.TabIndex = 6;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.Forgot_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email_TB);
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Forgot_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email_TB;
    }
}