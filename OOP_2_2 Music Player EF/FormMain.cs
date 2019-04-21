using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDataEF;

namespace OOP_2_2_Music_Player_EF
{
    public partial class FormMain : Form
    {
        private MPEntities ctx;
        private FormAuth authForm;

        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(int id, FormAuth auth)
        {
            InitializeComponent();
            ctx = new MPEntities();
            authForm = auth;
            UsernameLabel.Text = (from u in ctx.Users where u.user_id == id select u.username).FirstOrDefault();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            authForm.Close();
        }

        private void SongsLabel_MouseEnter(object sender, EventArgs e)
        {
            SongsLabel.ForeColor = Color.White;
        }
        private void SongsLabel_MouseLeave(object sender, EventArgs e)
        {
            SongsLabel.ForeColor = Color.FromArgb(167, 169, 174);
        }

        private void AlbumsLabel_MouseEnter(object sender, EventArgs e)
        {
            AlbumsLabel.ForeColor = Color.White;
        }

        private void AlbumsLabel_MouseLeave(object sender, EventArgs e)
        {
            AlbumsLabel.ForeColor = Color.FromArgb(167, 169, 174);
        }

        private void ArtistsLabel_MouseEnter(object sender, EventArgs e)
        {
            ArtistsLabel.ForeColor = Color.White;
        }

        private void ArtistsLabel_MouseLeave(object sender, EventArgs e)
        {
            ArtistsLabel.ForeColor = Color.FromArgb(167, 169, 174);
        }
    }
}
