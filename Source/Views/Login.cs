using Source.Dtos.Account;
using Source.Service;
using Source.Utils;
using Source.Views.Custommer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source.Views
{
    public partial class Login : Form
    {
        private readonly AccountService _AccountService;
        public static int frmLoginLocationX, frmLoginLocationY;
        public static int pnlChildFormLocationX, pnlChildFormLocationY;
        public static int frmWith, frmHeight;

        public static int parentX, parentY;
        private readonly UserService _userService = new UserService();
        public Login()
        {
            InitializeComponent();
            _AccountService = new AccountService();
        }
        // Tạo Form con 
        private Form? activeForm = null;
        private void openChildForm(Form childForm)
        {
            frmLoginLocationX = this.Location.X;
            frmLoginLocationY = this.Location.Y;
            frmHeight = this.Height;
            frmWith = this.Width;
            pnlChildFormLocationX = pnlLogin.Location.X;
            pnlChildFormLocationY = pnlLogin.Location.Y;
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

        }

        private void btnResgister_Click(object sender, EventArgs e)
        {
            openChildForm(new Resgister());
        }     

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var emailOrUsername = txtUsername.Text;
                var password = txtPassWord.Text;

                // Validate input
                if (string.IsNullOrWhiteSpace(emailOrUsername))
                {
                    MessageBox.Show("Please enter your email or username.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter your password.");
                    return;
                }

                var loginUserDto = new LoginUserDto
                {
                    EmailOrUsername = emailOrUsername,
                    Password = password
                };

                var response = await _AccountService.LoginAsync(loginUserDto);


                // If token is null, login failed
                if (response == null)
                {
                    MessageBox.Show("Your information is not corret");
                }
                else
                {
                    Config.token = response.Data.Token;
                    MessageBox.Show("Login successful! ");
                    // Handle successful login
                    openChildForm(new MainForm());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }

        }
    }
}
