namespace PAS
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            label2 = new Label();
            btnRegisterHere = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(166, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(191, 277);
            label1.Name = "label1";
            label1.Size = new Size(154, 54);
            label1.TabIndex = 1;
            label1.Text = "Log In";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(72, 401);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(72, 459);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 3);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(72, 527);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(72, 585);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 3);
            panel2.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(132, 417);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 24);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(132, 545);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(320, 24);
            txtPassword.TabIndex = 7;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = SystemColors.Highlight;
            btnLogIn.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.ForeColor = SystemColors.Control;
            btnLogIn.Location = new Point(94, 763);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(322, 77);
            btnLogIn.TabIndex = 8;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 667);
            label2.Name = "label2";
            label2.Size = new Size(234, 26);
            label2.TabIndex = 9;
            label2.Text = "Don't have account?";
            label2.Click += label2_Click;
            // 
            // btnRegisterHere
            // 
            btnRegisterHere.Cursor = Cursors.Hand;
            btnRegisterHere.FlatAppearance.BorderSize = 0;
            btnRegisterHere.FlatStyle = FlatStyle.Flat;
            btnRegisterHere.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisterHere.ForeColor = SystemColors.HotTrack;
            btnRegisterHere.Location = new Point(282, 658);
            btnRegisterHere.Name = "btnRegisterHere";
            btnRegisterHere.Size = new Size(194, 40);
            btnRegisterHere.TabIndex = 10;
            btnRegisterHere.Text = "Register Here";
            btnRegisterHere.UseVisualStyleBackColor = true;
            btnRegisterHere.Click += btnRegisterHere_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 951);
            Controls.Add(btnRegisterHere);
            Controls.Add(label2);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogIn;
        private Label label2;
        private Button btnRegisterHere;
    }
}