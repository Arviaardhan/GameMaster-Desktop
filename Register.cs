using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAS
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnLoginHere_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormLogin"] as LoginForm) == null)
            {
                LoginForm baru = new LoginForm();
                baru.Show();
                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Cursor = Cursors.Hand;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Harap isi semua kolom");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Password dan Confirm Password harus sama.");
                ClearAllTextBoxes();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Username = username;
                loginForm.Password = password;
                loginForm.Show();
                this.Hide();
            }
        }

        private void ClearAllTextBoxes()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
