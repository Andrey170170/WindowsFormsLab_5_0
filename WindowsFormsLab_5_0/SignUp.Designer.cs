namespace WindowsFormsLab_5_0
{
    partial class SignUp
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
            this.Password_CB = new System.Windows.Forms.CheckBox();
            this.SignUP_B = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Repeat_Pass_CB = new System.Windows.Forms.CheckBox();
            this.Repeat_Pass_L = new System.Windows.Forms.Label();
            this.Repeat_Pass_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Password_CB
            // 
            this.Password_CB.AutoSize = true;
            this.Password_CB.Location = new System.Drawing.Point(298, 262);
            this.Password_CB.Name = "Password_CB";
            this.Password_CB.Size = new System.Drawing.Size(15, 14);
            this.Password_CB.TabIndex = 15;
            this.Password_CB.UseVisualStyleBackColor = true;
            this.Password_CB.CheckedChanged += new System.EventHandler(this.Password_CB_CheckedChanged);
            // 
            // SignUP_B
            // 
            this.SignUP_B.Location = new System.Drawing.Point(150, 352);
            this.SignUP_B.Name = "SignUP_B";
            this.SignUP_B.Size = new System.Drawing.Size(123, 23);
            this.SignUP_B.TabIndex = 14;
            this.SignUP_B.Text = "Sign up";
            this.SignUP_B.UseVisualStyleBackColor = true;
            this.SignUP_B.Click += new System.EventHandler(this.SignUP_B_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password:";
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(101, 260);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(190, 20);
            this.Password_TB.TabIndex = 12;
            this.Password_TB.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login:";
            // 
            // Login_TB
            // 
            this.Login_TB.Location = new System.Drawing.Point(101, 142);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(205, 20);
            this.Login_TB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sign up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email:";
            // 
            // Email_TB
            // 
            this.Email_TB.Location = new System.Drawing.Point(101, 201);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(205, 20);
            this.Email_TB.TabIndex = 16;
            // 
            // Repeat_Pass_CB
            // 
            this.Repeat_Pass_CB.AutoSize = true;
            this.Repeat_Pass_CB.Location = new System.Drawing.Point(298, 318);
            this.Repeat_Pass_CB.Name = "Repeat_Pass_CB";
            this.Repeat_Pass_CB.Size = new System.Drawing.Size(15, 14);
            this.Repeat_Pass_CB.TabIndex = 20;
            this.Repeat_Pass_CB.UseVisualStyleBackColor = true;
            this.Repeat_Pass_CB.CheckedChanged += new System.EventHandler(this.Repeat_Pass_CB_CheckedChanged);
            // 
            // Repeat_Pass_L
            // 
            this.Repeat_Pass_L.AutoSize = true;
            this.Repeat_Pass_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repeat_Pass_L.Location = new System.Drawing.Point(97, 293);
            this.Repeat_Pass_L.Name = "Repeat_Pass_L";
            this.Repeat_Pass_L.Size = new System.Drawing.Size(139, 20);
            this.Repeat_Pass_L.TabIndex = 19;
            this.Repeat_Pass_L.Text = "Repeat Password:";
            // 
            // Repeat_Pass_TB
            // 
            this.Repeat_Pass_TB.Location = new System.Drawing.Point(101, 316);
            this.Repeat_Pass_TB.Name = "Repeat_Pass_TB";
            this.Repeat_Pass_TB.Size = new System.Drawing.Size(190, 20);
            this.Repeat_Pass_TB.TabIndex = 18;
            this.Repeat_Pass_TB.UseSystemPasswordChar = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 402);
            this.Controls.Add(this.Repeat_Pass_CB);
            this.Controls.Add(this.Repeat_Pass_L);
            this.Controls.Add(this.Repeat_Pass_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_TB);
            this.Controls.Add(this.Password_CB);
            this.Controls.Add(this.SignUP_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_TB);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Password_CB;
        private System.Windows.Forms.Button SignUP_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email_TB;
        private System.Windows.Forms.CheckBox Repeat_Pass_CB;
        private System.Windows.Forms.Label Repeat_Pass_L;
        private System.Windows.Forms.TextBox Repeat_Pass_TB;
    }
}