using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace PAS
{
    public partial class DashboardForm : Form
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            this.panelDashboard.Controls.Clear();
            HomeForm homeForm = new HomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelDashboard.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            this.panelDashboard.Controls.Clear();
            HomeForm homeForm = new HomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelDashboard.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnProfile.Height;
            sidePanel.Top = btnProfile.Top;
            this.panelDashboard.Controls.Clear();
            ProfileForm profileForm = new ProfileForm(Username, Password) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelDashboard.Controls.Add(profileForm);
            profileForm.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnMenu.Height;
            sidePanel.Top = btnMenu.Top;
            this.panelDashboard.Controls.Clear();
            StoreForm menuForm = new StoreForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelDashboard.Controls.Add(menuForm);
            menuForm.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnCart.Height;
            sidePanel.Top = btnCart.Top;
            this.panelDashboard.Controls.Clear();
            CartForm cartForm = new CartForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelDashboard.Controls.Add(cartForm);
            cartForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Menutup aplikasi jika pengguna memilih "Yes"
                Application.Exit();
            }
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
