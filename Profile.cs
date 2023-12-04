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
    public partial class ProfileForm : Form
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public ProfileForm(string lblUsername, string lblPassword)
        {
            InitializeComponent();
            Username = lblUsername;
            Password = lblPassword;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Username;
            lblPassword.Text = Password;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
