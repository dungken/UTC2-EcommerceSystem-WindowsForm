using Source.Dtos.Account;
using Source.Service;
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
        public Login()
        { 
            InitializeComponent();
            _AccountService = new AccountService();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var emailOrUsername = txtUsername.Text;
                var password = txtPassWord.Text;
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
                    MessageBox.Show("Login successful! Token: " + response.Data.Token);
                    // Handle successful login
                    new MainForm().Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
            
           
           
        }

        private void btnResgister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resgister().Show();
          
        }

        private void btnLoginWGoogle_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginWithGoogle().Show();
       
        }

        private void lblForget_Click(object sender, EventArgs e)
        {

        }
    }
}
