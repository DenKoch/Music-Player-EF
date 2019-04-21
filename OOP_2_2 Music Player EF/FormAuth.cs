using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Entity;
using LibraryDataEF;

namespace OOP_2_2_Music_Player_EF
{
    public partial class FormAuth : Form
    {
        private bool sign_in = true;
        private bool sign_up = false;
        private FormMain mainForm;
        private MPEntities ctx;

        public FormAuth()
        {
            InitializeComponent();
        }
        public FormAuth(FormMain main)
        {
            mainForm = main;
            InitializeComponent();
        }

        // Form load-close

        private void FormAuth_Load(object sender, EventArgs e)
        {
            ctx = new MPEntities();
            ctx.Users.Load();
            this.ActiveControl = SignInLabel;
        }
        private void FormAuth_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
            //if (mainForm != null)
            //mainForm.Close();
        }

        // SIGN_IN / SIGN_UP switch

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            SignUpUnderline.Visible = true;
            SignUpUnderline.Width = 1;
            int x_pos_signup = 446;
            int x_pos_signin = 310;
            SignUpUnderline.Location = new Point(x_pos_signup, 197);

            ConfirmPassTextBox.Visible = true;

            ConfirmButton.Text = "SIGN UP";

            sign_in = false;
            sign_up = true;

            //ANIMATION
            Timer t = new Timer();
            t.Interval = 30;
            t.Tick += new EventHandler((o, ev) =>
            {
                x_pos_signup -= 11;
                x_pos_signin += 11;

                SignUpUnderline.Width += 22;
                SignInUnderline.Width -= 22;
                SignUpUnderline.Location = new Point(x_pos_signup, 197);
                SignInUnderline.Location = new Point(x_pos_signin, 197);

                if (SignInUnderline.Width <= 1)
                    SignInUnderline.Visible = false;

                if (SignUpUnderline.Width >= 66)
                    t.Stop();
            });
            t.Start();
        }
        private void SignInLabel_Click(object sender, EventArgs e)
        {
            SignInUnderline.Visible = true;
            SignInUnderline.Width = 1;

            int x_pos_signup = 413;
            int x_pos_signin = 343;

            SignUpUnderline.Location = new Point(x_pos_signup, 197);

            ConfirmPassTextBox.Visible = false;

            ConfirmButton.Text = "SIGN IN";

            sign_in = true;
            sign_up = false;

            //ANIMATION
            Timer t = new Timer();
            t.Interval = 30;
            t.Tick += new EventHandler((o, ev) =>
            {
                x_pos_signin -= 11;
                x_pos_signup += 11;

                SignInUnderline.Width += 22;
                SignUpUnderline.Width -= 22;

                SignUpUnderline.Location = new Point(x_pos_signup, 197);
                SignInUnderline.Location = new Point(x_pos_signin, 197);

                if (SignUpUnderline.Width <= 1)
                    SignUpUnderline.Visible = false;

                if (SignInUnderline.Width >= 66)
                    t.Stop();
            });
            t.Start();
        }

        // Username text box Enter-Leave

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "Username")
            {
                UsernameTextBox.ForeColor = Color.Black;
                UsernameTextBox.Text = String.Empty;
            }
        }
        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == String.Empty)
            {
                UsernameTextBox.Text = "Username";
                UsernameTextBox.ForeColor = Color.FromArgb(167, 169, 174);
            }
        }

        // Password text box Enter-Leave

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Password")
            {
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.PasswordChar = '*';
                PasswordTextBox.Text = String.Empty;
            }
        }
        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == String.Empty)
            {
                PasswordTextBox.Text = "Password";
                PasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.ForeColor = Color.FromArgb(167, 169, 174);
            }
        }

        // Confirm password text box Enter-Leave

        private void ConfirmPassTextBox_Enter(object sender, EventArgs e)
        {
            if (ConfirmPassTextBox.Text == "Confirm password")
            {
                ConfirmPassTextBox.ForeColor = Color.Black;
                ConfirmPassTextBox.PasswordChar = '*';
                ConfirmPassTextBox.Text = String.Empty;
            }
        }
        private void ConfirmPassTextBox_Leave(object sender, EventArgs e)
        {
            if (ConfirmPassTextBox.Text == String.Empty)
            {
                ConfirmPassTextBox.Text = "Confirm password";
                ConfirmPassTextBox.PasswordChar = '\0';
                ConfirmPassTextBox.ForeColor = Color.FromArgb(167, 169, 174);
            }
        }

        // Confirm button click

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var input_username = UsernameTextBox.Text.Trim();
            var input_password = PasswordTextBox.Text.Trim();
            var input_password_2 = ConfirmPassTextBox.Text.Trim();
            try
            {
                if (sign_in)
                {
                    // Get stored password
                    var usernamePassList = (from u in ctx.Users
                                            where u.username == input_username
                                            select u.password).ToList();

                    if (usernamePassList.Count() == 0)
                        throw new Exception("Wrong Username!");

                    var savedPasswordHash = usernamePassList[0];

                    byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

                    // Get the salt
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);

                    // Compute the hash on the password the user entered
                    var pbkdf2 = new Rfc2898DeriveBytes(input_password, salt, 1000);
                    byte[] hash = pbkdf2.GetBytes(20);

                    // Compare the results
                    for (int i = 0; i < 20; i++)
                        if (hashBytes[i + 16] != hash[i])
                            throw new Exception("Wrong Password!");
                }
                if (sign_up)
                {
                    var isUserInDB = (from u in ctx.Users
                                      where u.username == input_username
                                      select u).Any();

                    // This username is taken
                    if (isUserInDB == true)
                        throw new Exception("User with this username already exists!");

                    // Passwords dont match
                    if (input_password != input_password_2)
                        throw new Exception("Passwords do not match!");

                    byte[] salt;
                    new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

                    var pbkdf2 = new Rfc2898DeriveBytes(input_password, salt, 1000);
                    byte[] hash = pbkdf2.GetBytes(20);

                    byte[] hashBytes = new byte[36];
                    Array.Copy(salt, 0, hashBytes, 0, 16);
                    Array.Copy(hash, 0, hashBytes, 16, 20);

                    string savedPasswordHash = Convert.ToBase64String(hashBytes);
                    ctx.Users.Add(new User { username = input_username, password = savedPasswordHash });
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var user_id = (from u in ctx.Users where u.username == input_username select u.user_id).First();

            this.Hide();
            mainForm = new FormMain(user_id, this);
            mainForm.Show();
        }
    }
}
