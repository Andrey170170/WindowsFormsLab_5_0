namespace WindowsFormsLab_5_0
{
    partial class SignIn
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
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SignIN_B = new System.Windows.Forms.Button();
            this.ForgetPass_L = new System.Windows.Forms.Label();
            this.SignUP_L = new System.Windows.Forms.Label();
            this.Password_CB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // Login_TB
            // 
            this.Login_TB.Location = new System.Drawing.Point(89, 118);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(205, 20);
            this.Login_TB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(89, 179);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(190, 20);
            this.Password_TB.TabIndex = 3;
            this.Password_TB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // SignIN_B
            // 
            this.SignIN_B.Location = new System.Drawing.Point(129, 215);
            this.SignIN_B.Name = "SignIN_B";
            this.SignIN_B.Size = new System.Drawing.Size(123, 23);
            this.SignIN_B.TabIndex = 5;
            this.SignIN_B.Text = "Sign in";
            this.SignIN_B.UseVisualStyleBackColor = true;
            this.SignIN_B.Click += new System.EventHandler(this.SignIN_B_Click);
            // 
            // ForgetPass_L
            // 
            this.ForgetPass_L.AutoSize = true;
            this.ForgetPass_L.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgetPass_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPass_L.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ForgetPass_L.Location = new System.Drawing.Point(82, 251);
            this.ForgetPass_L.Name = "ForgetPass_L";
            this.ForgetPass_L.Size = new System.Drawing.Size(98, 15);
            this.ForgetPass_L.TabIndex = 6;
            this.ForgetPass_L.Text = "Forget password";
            this.ForgetPass_L.Click += new System.EventHandler(this.ForgetPass_L_Click);
            // 
            // SignUP_L
            // 
            this.SignUP_L.AutoSize = true;
            this.SignUP_L.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUP_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUP_L.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SignUP_L.Location = new System.Drawing.Point(258, 251);
            this.SignUP_L.Name = "SignUP_L";
            this.SignUP_L.Size = new System.Drawing.Size(49, 15);
            this.SignUP_L.TabIndex = 7;
            this.SignUP_L.Text = "Sign up";
            this.SignUP_L.Click += new System.EventHandler(this.SignUP_L_Click);
            // 
            // Password_CB
            // 
            this.Password_CB.AutoSize = true;
            this.Password_CB.Location = new System.Drawing.Point(286, 181);
            this.Password_CB.Name = "Password_CB";
            this.Password_CB.Size = new System.Drawing.Size(15, 14);
            this.Password_CB.TabIndex = 8;
            this.Password_CB.UseVisualStyleBackColor = true;
            this.Password_CB.CheckedChanged += new System.EventHandler(this.Password_CB_CheckedChanged);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 330);
            this.Controls.Add(this.Password_CB);
            this.Controls.Add(this.SignUP_L);
            this.Controls.Add(this.ForgetPass_L);
            this.Controls.Add(this.SignIN_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_TB);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignIn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SignIN_B;
        private System.Windows.Forms.Label ForgetPass_L;
        private System.Windows.Forms.Label SignUP_L;
        private System.Windows.Forms.CheckBox Password_CB;
    }
}

