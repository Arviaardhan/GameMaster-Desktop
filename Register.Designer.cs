namespace PAS
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtConfirmPassword = new TextBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            btnLoginHere = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.Highlight;
            btnRegister.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(97, 823);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(322, 77);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(133, 547);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(320, 24);
            txtPassword.TabIndex = 16;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(133, 425);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 24);
            txtUsername.TabIndex = 15;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(73, 587);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 3);
            panel2.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(73, 529);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(73, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 3);
            panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 409);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(163, 282);
            label1.Name = "label1";
            label1.Size = new Size(205, 54);
            label1.TabIndex = 10;
            label1.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.Control;
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Location = new Point(133, 664);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(320, 24);
            txtConfirmPassword.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(73, 704);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 3);
            panel3.TabIndex = 18;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Control;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(73, 646);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // btnLoginHere
            // 
            btnLoginHere.Cursor = Cursors.Hand;
            btnLoginHere.FlatAppearance.BorderSize = 0;
            btnLoginHere.FlatStyle = FlatStyle.Flat;
            btnLoginHere.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginHere.ForeColor = SystemColors.HotTrack;
            btnLoginHere.Location = new Point(314, 748);
            btnLoginHere.Name = "btnLoginHere";
            btnLoginHere.Size = new Size(155, 40);
            btnLoginHere.TabIndex = 22;
            btnLoginHere.Text = "Login Here";
            btnLoginHere.UseVisualStyleBackColor = true;
            btnLoginHere.Click += btnLoginHere_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 757);
            label2.Name = "label2";
            label2.Size = new Size(255, 26);
            label2.TabIndex = 21;
            label2.Text = "Do you have account?";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 951);
            Controls.Add(btnLoginHere);
            Controls.Add(label2);
            Controls.Add(txtConfirmPassword);
            Controls.Add(panel3);
            Controls.Add(pictureBox4);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtConfirmPassword;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Button btnLoginHere;
        private Label label2;
    }
}