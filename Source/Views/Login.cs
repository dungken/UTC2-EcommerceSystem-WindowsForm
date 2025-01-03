using Google.Apis.Auth;
using Google.Apis.Util;
using Newtonsoft.Json;
using Source.Dtos.Account;
using Source.Models;
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
using System.Net;
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
        private static readonly HttpClient client = new HttpClient();
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
                        if (_2StepVerifycationForLogin.isVerifyEmail)
                        {
                            Config.token = response.Data.Token;
                            MessageBox.Show("Login successful! ");

                            // Handle successful login
                            //openChildForm(new OrdersList());
                            openChildForm(new MainForm());
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
                        
                        openChildForm(new MainForm());
                        //openChildForm(new DiscountsList());
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }

        }

        private async void btnLoginWGoogle_Click(object sender, EventArgs e)
        {
            try
            {
                // Thông tin Client ID và Client Secret
                string clientId = "929983322362-n15r2kq4njvpdd32p8nb3hmotlduoq14.apps.googleusercontent.com";
                string clientSecret = "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";
                string redirectUri = "http://localhost:8081/";

                // Lấy mã xác thực từ Google
                string authCode = await GetAuthCodeAsync(clientId, redirectUri);

                // Trao đổi mã xác thực để lấy Access Token và ID Token
                var tokenResponse = await ExchangeAuthCodeForTokens(authCode, clientId, clientSecret, redirectUri);

                // Đọc ID Token từ phản hồi
                string idToken = tokenResponse.id_token;
                if (string.IsNullOrWhiteSpace(idToken))
                {
                    throw new Exception("Không lấy được ID Token từ phản hồi của Google.");
                }

                // Giải mã ID Token để lấy thông tin người dùng
                var userInfo = DecodeJwt(idToken);

                // Hiển thị thông tin người dùng
                MessageBox.Show($"Đăng nhập thành công!\nTên: {userInfo["name"]}\nEmail: {userInfo["email"]}");

                // Chuyển đến MainForm
                this.Hide();
                new MainForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập với Google: {ex.Message}");
            }
        }

        private async Task<dynamic> ExchangeAuthCodeForTokens(string authCode, string clientId, string clientSecret, string redirectUri)
        {
            var queryParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("code", authCode),
                new KeyValuePair<string, string>("client_id", clientId),
                new KeyValuePair<string, string>("client_secret", clientSecret),
                new KeyValuePair<string, string>("redirect_uri", redirectUri),
                new KeyValuePair<string, string>("grant_type", "authorization_code")
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(queryParams);
                var response = await client.PostAsync("https://oauth2.googleapis.com/token", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<dynamic>(responseContent);
                }
                else
                {
                    throw new Exception($"Lỗi khi trao đổi mã xác thực: {response.StatusCode}");
                }
            }
        }

        private async Task<string> GetAuthCodeAsync(string clientId, string redirectUri)
        {
            using (var httpListener = new HttpListener())
            {
                httpListener.Prefixes.Add(redirectUri);
                httpListener.Start();

                string authUrl = $"https://accounts.google.com/o/oauth2/v2/auth?client_id={clientId}&response_type=code&scope=openid%20email%20profile&redirect_uri={Uri.EscapeDataString(redirectUri)}&access_type=offline";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = authUrl,
                    UseShellExecute = true
                });

                var context = await httpListener.GetContextAsync();
                string code = context.Request.QueryString["code"];
                if (string.IsNullOrWhiteSpace(code))
                {
                    throw new Exception("Không nhận được mã xác thực từ Google.");
                }

                using (var writer = new StreamWriter(context.Response.OutputStream))
                {
                    writer.WriteLine("<html><body><h1>Đăng nhập thành công!</h1><p>Bạn có thể quay lại ứng dụng.</p></body></html>");
                }

                context.Response.StatusCode = 200;
                context.Response.Close();

                return code;
            }
        }

        // Giải mã ID Token để lấy thông tin người dùng
        private Dictionary<string, string> DecodeJwt(string idToken)
        {
            System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler handler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(idToken);

            var claims = jwtToken.Claims.ToDictionary(c => c.Type, c => c.Value);
            return claims;
        }

        private void lblForget_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }
    }

}
