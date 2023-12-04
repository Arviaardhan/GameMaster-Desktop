using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PAS
{
    public partial class LoginForm : Form
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;
            btnLogIn.Cursor = Cursors.Hand;

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Harap isi semua kolom");
            }
            else if (enteredUsername != Username)
            {
                MessageBox.Show("Username Salah");
                ClearAllTextBoxes();
            }
            else if (enteredPassword != Password)
            {
                MessageBox.Show("Password Salah");
                ClearAllTextBoxes();
            }
            else
            {
                MessageBox.Show("Login berhasil!");
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Username = enteredUsername;
                dashboardForm.Password = enteredPassword;
                dashboardForm.Show();
                this.Hide();
            }
        }

        private void ClearAllTextBoxes()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnRegisterHere_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Register"] as RegisterForm) == null)
            {
                RegisterForm baru = new RegisterForm();
                baru.Show();
                this.Hide();
            }
            btnRegisterHere.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}