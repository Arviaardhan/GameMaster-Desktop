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
    public partial class CartForm : Form
    {
        List<GameClass> gameClasses = StoreForm.cart;

        public CartForm()
        {
            InitializeComponent();
            DisplayCartContents();
            CalculateTotal();
        }

        public static List<GameClass> cart = new List<GameClass>();

        public void AddToCart(GameClass game)
        {
            cart.Add(game);
            DisplayCartContents();
        }

        private void UpdateBayarButtonState()
        {
            btnBayar.Enabled = !((cbGopay.Checked && (cbDana.Checked || cbOvo.Checked)) || (cbDana.Checked && (cbGopay.Checked || cbOvo.Checked)) || (cbOvo.Checked && (cbGopay.Checked || cbDana.Checked)));
        }

        private void CalculateTotal()
        {
            double total = 0;

            foreach (var game in StoreForm.cart)
            {
                total += Convert.ToDouble(game.gamePrice);
            }

            lblTotal.Text = "Total : Rp " + total.ToString();
        }


        private void DisplayCartContents()
        {
            List<GameClass> cartContents = StoreForm.cart;
            panel2.Controls.Clear();
            CalculateTotal();

            if (cartContents.Count == 0)
            {
                panel2.Visible = false;
                return;
            }

            int panelWidth = 300;
            int panelHeight = 350;
            int horizontalSpacing = 20;
            int verticalSpacing = 15;

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.WrapContents = true;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Padding = new Padding(horizontalSpacing, verticalSpacing, horizontalSpacing, verticalSpacing);

            for (int i = 0; i < cartContents.Count; i++)
            {
                Panel productPanel = new Panel();
                productPanel.BackColor = Color.FloralWhite;
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                productPanel.Size = new Size(panelWidth, panelHeight);
                productPanel.Margin = new Padding(horizontalSpacing);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = cartContents[i].gameImage;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = panelWidth;
                pictureBox.Height = 190;
                productPanel.Controls.Add(pictureBox);

                Label nameLabel = new Label();
                nameLabel.Text = cartContents[i].gameName;
                nameLabel.Location = new Point(40, pictureBox.Height + 10);
                nameLabel.AutoSize = true;
                nameLabel.Font = new Font(nameLabel.Font.FontFamily, 12, FontStyle.Bold);
                productPanel.Controls.Add(nameLabel);

                Label genreLabel = new Label();
                genreLabel.Text = "Genre : " + cartContents[i].gameGanre;
                genreLabel.Location = new Point(20, pictureBox.Height + 50);
                genreLabel.AutoSize = true;
                genreLabel.Font = new Font(genreLabel.Font.FontFamily, 10);
                genreLabel.Font = new Font(genreLabel.Font, FontStyle.Bold);
                genreLabel.ForeColor = Color.Black;
                productPanel.Controls.Add(genreLabel);

                Label rateLabel = new Label();
                rateLabel.Text = "Rate : " + cartContents[i].gameRating;
                rateLabel.Location = new Point(20, pictureBox.Height + 80);
                rateLabel.AutoSize = true;
                rateLabel.Font = new Font(rateLabel.Font.FontFamily, 10);
                rateLabel.Font = new Font(rateLabel.Font, FontStyle.Bold);
                rateLabel.ForeColor = Color.Black;
                productPanel.Controls.Add(rateLabel);

                Label priceLabel = new Label();
                priceLabel.Text = "Rp " + cartContents[i].gamePrice.ToString();
                priceLabel.Location = new Point(40, pictureBox.Height + 120);
                priceLabel.AutoSize = true;
                priceLabel.Font = new Font(priceLabel.Font.FontFamily, 12);
                priceLabel.Font = new Font(priceLabel.Font, FontStyle.Bold);
                priceLabel.ForeColor = Color.Black;
                productPanel.Controls.Add(priceLabel);

                Button removeButton = new Button();
                removeButton.Text = "Remove";
                removeButton.Cursor = Cursors.Hand;
                removeButton.Location = new Point(190, pictureBox.Height + 120);
                removeButton.AutoSize = true;
                removeButton.BackColor = Color.Red;
                removeButton.ForeColor = Color.White;
                removeButton.Click += (sender, e) =>
                {
                    DialogResult result = MessageBox.Show("Anda yakin akan membuang item ini?", "Konfirmasi Hapus Item", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        GameClass itemToRemove = cartContents.FirstOrDefault(item => item.gameImage == pictureBox.Image);

                        if (itemToRemove != null)
                        {
                            cartContents.Remove(itemToRemove);
                            DisplayCartContents();
                        }
                    }
                };
                productPanel.Controls.Add(removeButton);

                flowLayoutPanel.Controls.Add(productPanel);
            }

            panel2.Controls.Add(flowLayoutPanel);
            panel2.Visible = true;
        }


        private void CartForm_Load(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (StoreForm.cart.Count == 0)
            {
                MessageBox.Show("Tidak ada item yang dibeli", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (btnBayar.Enabled && (cbGopay.Checked || cbDana.Checked || cbOvo.Checked))
            {
                DialogResult confirmation = MessageBox.Show("Apakah Anda yakin ingin melanjutkan pembayaran?", "Konfirmasi Pembayaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    cbGopay.Checked = false;
                    cbDana.Checked = false;
                    cbOvo.Checked = false;

                    StoreForm.cart.Clear();
                    DisplayCartContents();
                    lblTotal.Text = "Total : Rp 0";
                }
                else
                {
                    // Jika pengguna memilih No, tidak ada tindakan yang diambil
                }
            }
            else
            {
                MessageBox.Show("Pilih salah satu metode pembayaran terlebih dahulu.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbGopay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGopay.Checked)
            {
                cbDana.Checked = false;
                cbOvo.Checked = false;
            }
            UpdateBayarButtonState();
        }

        private void cbDana_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDana.Checked)
            {
                cbGopay.Checked = false;
                cbOvo.Checked = false;
            }
            UpdateBayarButtonState();
        }

        private void cbOvo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOvo.Checked)
            {
                cbGopay.Checked = false;
                cbDana.Checked = false;
            }
            UpdateBayarButtonState();
        }
    }
}
