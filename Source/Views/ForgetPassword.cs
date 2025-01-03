using Source.Dtos.Account;
using Source.Service;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Source.Views
{
    public partial class ForgetPassword : Form
    {
        // Biến thành viên để lưu trạng thái OTP và email
        private string userEmail;
        private readonly AccountService _accountService;

        public ForgetPassword()
        {
            InitializeComponent();
            _accountService = new AccountService();
            txtNewPassword.Hide();
            btnConfirm.Hide();
            label3.Hide();
            panel4.Hide();
        }
        private async Task ForgotPasswordAsync()
        {
            ForgotPasswordDto forgotPasswordDto = new ForgotPasswordDto
            {
                Email = userEmail
            };
            var response = await _accountService.ForgotPassword(forgotPasswordDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Forgot Password Request Successful\nMessage: {response.Message}\nReset Link: {response.Data.ResetLink}");
            }
            else
            {
                MessageBox.Show($"Forgot Password Request Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task ResetPasswordAsync()
        {
            ResetPasswordDto resetPasswordDto = new ResetPasswordDto
            {
                Token = "sampleToken",
                Email = "test@example.com",
                NewPassword = "newPassword123"
            };
            var response = await _accountService.ResetPassword(resetPasswordDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Password Reset Successful\nMessage: {response.Message}");
            }
            else
            {
                MessageBox.Show($"Password Reset Failed\nError: {string.Join(", ", response?.Errors ?? new List<string>())}");
            }
        }

        private async void btnGetLink_Click(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text.ToString();
            await ForgotPasswordAsync();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

    }
}
