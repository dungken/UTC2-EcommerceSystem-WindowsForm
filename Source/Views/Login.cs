using Source.Dtos.Account;
using Source.Service;
using Source.Utils;
using Source.Views.Admin;
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
                    var p = await _AccountService.CheckEnableVerifyAsync(emailOrUsername);
                    if (p.Data.TwoFactorEnabled == true)
                    {
                        MessageBox.Show("Please verify your email before login");
                        Form modalBackground = new Form();

                        using (_2StepVerifycationForLogin modal = new _2StepVerifycationForLogin())
                        {
                            modalBackground.StartPosition = FormStartPosition.Manual;
                            modalBackground.FormBorderStyle = FormBorderStyle.None;
                            modalBackground.Opacity = 0.50d;
                            modalBackground.Size = new Size(this.Width, this.Height);


                            modalBackground.Location = new Point(this.Location.X, this.Location.Y);
                            modalBackground.ShowInTaskbar = false;
                            modalBackground.Show();
                            modal.Owner = modalBackground;

                            parentX = this.Location.X + Login.pnlChildFormLocationX + 200;
                            parentY = this.Location.Y + Login.pnlChildFormLocationY;
                            modal.ShowDialog();
                            modalBackground.Dispose();

                        }
                        if (_2StepVerifycationForLogin.isVerifyEmail)
                        {
                            Config.token = response.Data.Token;
                            MessageBox.Show("Login successful! ");
                            // Handle successful login
                            openChildForm(new MainFormAdmin());
                        }
                        else
                        {
                            MessageBox.Show("Login failed: Your email is not verify");
                        }
                    }
                    else
                    {
                        Config.token = response.Data.Token;
                        MessageBox.Show("Login successful! ");
                        // Handle successful login
                        openChildForm(new MainFormAdmin());

                    }
                 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }

        }
    
    }

}
