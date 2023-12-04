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
    public partial class StoreForm : Form
    {
        public static List<GameClass> cart = new List<GameClass>();


        public class ProdukInfo
        {
            public string Nama { get; set; }
            public string Genre { get; set; }
            public string Rating { get; set; }
            public double Harga { get; set; }
            public Image Gambar { get; set; }
            public Button RemoveButton { get; set; }

            public ProdukInfo(string nama, string genre, string rating, double harga, Image gambar, Button removeButton)
            {
                Nama = nama;
                Genre = genre;
                Rating = rating;
                Harga = harga;
                Gambar = gambar;
                RemoveButton = removeButton;
            }
        }

        private CartForm cartForm;

        public StoreForm()
        {
            InitializeComponent();
            cartForm = new CartForm();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBeliWD_Click(object sender, EventArgs e)
        {
            GameClass walkingDead = new GameClass
            {
                gameImage = pbWD.Image,
                gameName = "Walking Dead",
                gameGanre = "Adventure, Drama",
                gameRating = "4.8",
                gamePrice = 200000,
                removeButton = new Button { Text = "Remove" }
            };

            if (!cart.Any(game => game.gameName == walkingDead.gameName))
            {
                cart.Add(walkingDead);
                cartForm.AddToCart(walkingDead);
            }
            else
            {
                MessageBox.Show("Maaf, game ini sudah ada dalam keranjang Anda.", "Game Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBeliRaft_Click(object sender, EventArgs e)
        {
            GameClass raft = new GameClass
            {
                gameImage = pbRaft.Image,
                gameName = "Raft",
                gameGanre = "Adventure, Action",
                gameRating = "4.5",
                gamePrice = 150000,
            };

            if (!cart.Any(game => game.gameName == raft.gameName))
            {
                cart.Add(raft);
                cartForm.AddToCart(raft);
            }
            else
            {
                MessageBox.Show("Maaf, game ini sudah ada dalam keranjang Anda.", "Game Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBeliCOD_Click(object sender, EventArgs e)
        {
            GameClass COD = new GameClass
            {
                gameImage = pbCOD.Image,
                gameName = "Call Of Duty",
                gameGanre = "Action, Adventure",
                gameRating = "4.7",
                gamePrice = 180000,
            };

            if (!cart.Any(game => game.gameName == COD.gameName))
            {
                cart.Add(COD);
                cartForm.AddToCart(COD);
            }
            else
            {
                MessageBox.Show("Maaf, game ini sudah ada dalam keranjang Anda.", "Game Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBeliAssasin_Click(object sender, EventArgs e)
        {
            GameClass assasin = new GameClass
            {
                gameImage = pbAssasin.Image,
                gameName = "Assasin Creed",
                gameGanre = "Fight, Adventure",
                gameRating = "4.8",
                gamePrice = 240000,
            };

            if (!cart.Any(game => game.gameName == assasin.gameName))
            {
                cart.Add(assasin);
                cartForm.AddToCart(assasin);
            }
            else
            {
                MessageBox.Show("Maaf, game ini sudah ada dalam keranjang Anda.", "Game Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBeliNFS_Click(object sender, EventArgs e)
        {
            GameClass NFS = new GameClass
            {
                gameImage = pbNFS.Image,
                gameName = "Need For Speed",
                gameGanre = "Racing, Adventure",
                gameRating = "4.8",
                gamePrice = 220000,
            };

            if (!cart.Any(game => game.gameName == NFS.gameName))
            {
                cart.Add(NFS);
                cartForm.AddToCart(NFS);
            }
            else
            {
                MessageBox.Show("Maaf, game ini sudah ada dalam keranjang Anda.", "Game Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBeliFaith_Click(object sender, EventArgs e)
        {
            GameClass faith = new GameClass
            {
                gameImage = pbFaith.Image,
                gameName = "The Last Faith",
                gameGanre = "Fighting",
                gameRating = "4.6",
                gamePrice = 160000,
            };

            if (!cart.Any(game => game.gameName == faith.gameName))
            {
                cart.Add(faith);
                cartForm.AddToCart(faith);
            }
            else
            {
                MessageBox.Show("Maaf, game ini sudah ada dalam keranjang Anda.", "Game Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBeliElden_Click(object sender, EventArgs e)
        {
            GameClass elden = new GameClass
            {
                gameImage = pbElden.Image,
                gameName = "Elden Ring",
                gameGanre = "Fighting",
                gameRating = "4.5",
                gamePrice = 170000,
            };

            if (!cart.Any(game => game.gameName == elden.gameName))
            {
                cart.Add(elden);
                cartForm.AddToCart(elden);
            }
            else
            {
                MessageBox.Show("Maaf, game ini sudah ada dalam keranjang Anda.", "Game Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnbeliHades_Click(object sender, EventArgs e)
        {
            GameClass hades = new GameClass
            {
                gameImage = pbHades.Image,
                gameName = "Hades",
                gameGanre = "Fighting, Shooter",
                gameRating = "4.6",
                gamePrice = 200000,
            };

            if (!cart.Any(game => game.gameName == hades.gameName))
            {
                cart.Add(hades);
                cartForm.AddToCart(hades);
            }
            else
            {
                MessageBox.Show("Maaf, game ini sudah ada dalam keranjang Anda.", "Game Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbWD_Click(object sender, EventArgs e)
        {

        }
    }
}
