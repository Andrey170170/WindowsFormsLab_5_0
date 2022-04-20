using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab_5_0
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUP_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login_TB.Text == "")
                {
                    throw new Exception("Login is empty");
                }
                if (Email_TB.Text == "")
                {
                    throw new Exception("Email is empty");
                }
                if (Password_TB.Text == "")
                {
                    throw new Exception("Password is empty");
                }
                if (Password_TB.Text != Repeat_Pass_TB.Text)
                {
                    throw new Exception("Passwords do not match");
                }

                using (UserContext db = new UserContext())
                {
                    db.Users.Add(new User(
                        MyHash.GetHashString(Login_TB.Text), 
                        MyHash.GetHashString(Password_TB.Text),
                        MyHash.GetHashString(Email_TB.Text), 
                        "User"));
                    db.SaveChanges();
                    MessageBox.Show($"User {Login_TB.Text} registered successfully");
                    var si = new SignIn();
                    this.Hide();
                    si.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

        }

        private void Password_CB_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.UseSystemPasswordChar = Password_TB.UseSystemPasswordChar == false;
        }

        private void Repeat_Pass_CB_CheckedChanged(object sender, EventArgs e)
        {
            Repeat_Pass_TB.UseSystemPasswordChar = Repeat_Pass_TB.UseSystemPasswordChar == false;
        }

        private void SignUp_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
