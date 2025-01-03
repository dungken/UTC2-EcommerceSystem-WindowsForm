using Source.Dtos.Account;
using Source.Service;
using Source.Utils;
using System;
using System.Formats.Tar;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using static Google.Apis.Requests.BatchRequest;

namespace Source.Views
{
    public partial class ForgetPassword : Form
    {
        // Biến thành viên để lưu trạng thái OTP và email
        private string userEmail;
        private readonly AccountService _accountService;
        public static int parentX, parentY;
        private readonly UserService _userService = new UserService();
        private static readonly HttpClient client = new HttpClient();

        public ForgetPassword()
        {
            InitializeComponent();
            _accountService = new AccountService();
            txtNewPassword.Hide();
            btnConfirm.Hide();
            label3.Hide();
            panel4.Hide();
        }


        private async void btnGetLink_Click(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text.ToString();

            if (string.IsNullOrWhiteSpace(userEmail))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ.");
                return;
            }

            MessageBox.Show("Vui lòng xác minh email trước khi đăng nhập.");

            var loginUserDto = new LoginUserDto
            {
                EmailOrUsername = userEmail,
                Password = "1234@Abcd"
            };
            var response = await _accountService.LoginAsync(loginUserDto);
            Config.token = response.Data.Token;
            var p = await _accountService.CheckEnableVerifyAsync(userEmail);
            if (p.Data.TwoFactorEnabled == true)
            {
                MessageBox.Show("Xác thực hai yếu tố đã được bật. Vui lòng xác minh email của bạn.");

                Form modalBackground = new Form();

                using (_2StepVerifycationForLogin modal = new _2StepVerifycationForLogin())
                {
                    modalBackground.StartPosition = FormStartPosition.Manual;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = 0.50d;
                    modalBackground.Size = new System.Drawing.Size(this.Width, this.Height);
                    modalBackground.Location = new Point(this.Location.X, this.Location.Y);
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();
                    modal.Owner = modalBackground;

                    parentX = this.Location.X + Login.pnlChildFormLocationX + 200;
                    parentY = this.Location.Y + Login.pnlChildFormLocationY;
                    modal.ShowDialog();
                    modalBackground.Dispose();
                }

                if (_2StepVerificationForForgetPass.isVerifyEmail)
                {
                    Refresh();
                    txtNewPassword.Show();
                    btnConfirm.Show();
                    label3.Show();
                    panel4.Show();
                    txtEmail.Hide();
                    btnGetLink.Hide();
                    label2.Hide();
                    panel7.Hide();
                }
            }
            else
            {
                MessageBox.Show("Xác thực hai yếu tố không được bật. Bạn có thể tiếp tục với việc đặt lại mật khẩu.");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            
        }
    }
}
