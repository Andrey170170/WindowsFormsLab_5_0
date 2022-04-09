using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab_5_0
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignUP_L_Click(object sender, EventArgs e)
        {
            var su = new SignUp();
            this.Hide();
            su.Show();
        }

        private void SignIN_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login_TB.Text == "")
                {
                    throw new Exception("Login is empty");
                }

                if (Password_TB.Text == "")
                {
                    throw new Exception("Password is empty");
                }

                using (UserContext db = new UserContext())
                {
                    foreach (var user in db.Users)
                    {
                        if (MyHash.GetHashString(Login_TB.Text) == user.Login && MyHash.GetHashString(Password_TB.Text) == user.Password)
                        {
                            MessageBox.Show($"You signed in successfully");
                            var pr = new Profile();
                            this.Hide();
                            pr.Show();
                            return;
                        }
                        MessageBox.Show($"Login or password are invalid");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Password_CB_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.UseSystemPasswordChar = Password_TB.UseSystemPasswordChar == false;
        }

        private void ForgetPass_L_Click(object sender, EventArgs e)
        {
            var f = new ForgotPass();
            this.Hide();
            f.Show();
        }
    }
}
