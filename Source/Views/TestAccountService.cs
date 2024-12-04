using Source.Dtos.Account;
using Source.Dtos.Category;
using Source.Models;
using Source.Repository;
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
    public partial class TestAccountService : Form
    {
        private readonly AccountService _accountService;
        private readonly CategoriesService _categoriesService;
        public TestAccountService()
        {
            InitializeComponent();
            _accountService = new AccountService();
            _categoriesService = new CategoriesService();
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            #region test _categoriesService
            // Test create category

            //CreateCategoryDto createCategoryDto = new CreateCategoryDto
            //{
            //    Name = "New Category",
            //    Description = "This is a new category",
            //    Status = "Active",
            //    ParentCategoryId = null // or set a valid parent category ID if needed
            //};
            //var createCategoryResponse = await _categoriesService.CreateCategoryAsync(createCategoryDto);
            //if (createCategoryResponse != null && createCategoryResponse.Success)
            //{
            //    MessageBox.Show($"Category Created Successfully\nMessage: {createCategoryResponse.Message}\nCategory: {createCategoryResponse.Data.Name}");
            //}
            //else
            //{
            //    MessageBox.Show($"Category Creation Failed\nError: {string.Join(", ", createCategoryResponse.Errors)}");
            //}

            //// Test get category by ID
            //if (createCategoryResponse != null && createCategoryResponse.Success)
            //{
            //    Guid categoryId = createCategoryResponse.Data.Id; // Use the ID of the created category
            //    var getCategoryResponse = await _categoriesService.GetCategoryByIdAsync(categoryId);
            //    if (getCategoryResponse != null && getCategoryResponse.Success)
            //    {
            //        MessageBox.Show($"Category Retrieved Successfully\nMessage: {getCategoryResponse.Message}\nCategory: {getCategoryResponse.Data.Name}");
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Get Category Failed\nError: {string.Join(", ", getCategoryResponse.Errors)}");
            //    }
            //}

            // Test update category

            //Guid categoryId = Guid.Parse("61D960DA-4BB2-4475-82C6-87CC1817E2B5"); // Use the ID of the created category
            //UpdateCategoryDto updateCategoryDto = new UpdateCategoryDto
            //{
            //    Name = "Updated Category",
            //    Description = "This is an updated category",
            //    Status = "Active",
            //    ParentCategoryId = null // or set a valid parent category ID if needed
            //};
            //var updateCategoryResponse = await _categoriesService.UpdateCategory(categoryId, updateCategoryDto);
            //if (updateCategoryResponse != null && updateCategoryResponse.Success)
            //{
            //    MessageBox.Show($"Category Updated Successfully\nMessage: {updateCategoryResponse.Message}\nCategory: {updateCategoryResponse.Data.Name}");
            //}
            //else
            //{
            //    MessageBox.Show($"Category Update Failed\nError: {string.Join(", ", updateCategoryResponse.Errors)}");
            //}

            // Test Delele category
            //Guid categoryId = Guid.Parse("61D960DA-4BB2-4475-82C6-87CC1817E2B5"); // Use the ID of the created category
            //var deleteCategoryResponse = await _categoriesService.DeleteCategory(categoryId);
            //if (deleteCategoryResponse)
            //{
            //    MessageBox.Show($"Category Deleted Successfully");
            //}
            //else
            //{
            //    MessageBox.Show($"Category Deletion Failed");
            //}


            // Test get all categories
            var GetAllCategoriesResponse = await _categoriesService.GetAllCategories();
            foreach (var item in GetAllCategoriesResponse.Data)
            {
                MessageBox.Show($"Category: {item.Name}");
            }
            #endregion
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            #region test _accountService
            // test LoginAsync

            //LoginUserDto x1 = new LoginUserDto
            //{
            //    EmailOrUsername = "xyz",
            //    Password = "123"
            //};
            //var response1 = await _accountService.LoginAsync(x1);
            //if (response1 != null && response1.Success)
            //{
            //    MessageBox.Show($"Message: {response1.Message}\nToken: {response1.Data.Token}\nUser: {response1.Data.User.UserName}");
            //}
            //else
            //{
            //    MessageBox.Show($"Error: {string.Join(", ", response1.Errors)}");
            //}


            // Test RegisterAsync

            //RegisterUserDto registerDto = new RegisterUserDto
            //{
            //    Email = "6351071021@st.utc2.edu.vn",
            //    UserName = "testuser2",
            //    Password = "password123A@",
            //    FirstName = "Test",
            //    LastName = "User"
            //};
            //var registerResponse = await _accountService.RegisterAsync(registerDto);
            //if (registerResponse != null && registerResponse.Success)
            //{
            //    MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.UserName}");

            //}
            //else
            //{
            //    MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            //}

            // Test ConfirmEmail, it is not possible to test this function because the token is generated by the server

            //ConfirmEmailDto confirmEmailDto = new ConfirmEmailDto
            //{
            //    Token = "CfDJ8MMhO3A1IBpLrRudcTwhJRgRSQgdVO6Q%2bqTL%2fqcWFffk%2b8rGWi1vx6wYZ%2fc98yBmeazvwoGzaX1vNZnf5Bpch%2bMqChmt%2bsQn54gDVSFBlZ26JnyMfzfmZkgGwBKjixKDCTmt9FgSQGWmNJbeT1u2UbACcMITbxEDPa%2bLRZV3UMa6xi2Z0Lzbxvue8ShIFI1bWZoqeZyfY43D3LWiqTwY6j6lKDY3LaT06RHhUwvwF6UWsuZwWnUEamIOSFf213FT9w%3d%3d",
            //    Email = "6351071021@st.utc2.edu.vn"
            //};
            //var confirmEmailResponse = await _accountService.ConfirmEmail(confirmEmailDto);
            //if (confirmEmailResponse != null && confirmEmailResponse.Success)
            //{
            //    MessageBox.Show($"Email Confirmation Successful\nMessage: {confirmEmailResponse.Message}\nUser: {confirmEmailResponse.Data.UserName}");
            //}
            //else
            //{
            //    MessageBox.Show($"Email Confirmation Failed\nError: {string.Join(", ", confirmEmailResponse.Errors)}");
            //}

            // Test Logout

            //var logoutResponse = await _accountService.Logout();
            //if (logoutResponse != null && logoutResponse.Success)
            //{
            //    MessageBox.Show($"Logout Successful\nMessage: {logoutResponse.Message}");
            //}
            //else
            //{
            //    MessageBox.Show($"Logout Failed\nError: {string.Join(", ", logoutResponse.Errors)}");
            //}


            // Test SocialLogin

            //SocialLoginDto socialLoginDto = new SocialLoginDto
            //{
            //    AccessToken = "sampleAccessToken",
            //    Provider = "Google"
            //};
            //var socialLoginResponse = await _accountService.SocialLogin(socialLoginDto);
            //if (socialLoginResponse != null && socialLoginResponse.Success)
            //{
            //    MessageBox.Show($"Social Login Successful\nMessage: {socialLoginResponse.Message}\nToken: {socialLoginResponse.Data.Token}\nUser: {socialLoginResponse.Data.User.UserName}");
            //}
            //else
            //{
            //    MessageBox.Show($"Social Login Failed\nError: {string.Join(", ", socialLoginResponse.Errors)}");
            //}

            // Test Enable2FA

            //var enable2FAResponse = await _accountService.Enable2FA();
            //if (enable2FAResponse != null && enable2FAResponse.Success)
            //{
            //    MessageBox.Show($"2FA Enabled\nMessage: {enable2FAResponse.Message}\nVerification Code: {enable2FAResponse.Data.VerificationCode}");
            //}
            //else
            //{
            //    MessageBox.Show($"Enable 2FA Failed\nError: {string.Join(", ", enable2FAResponse.Errors)}");
            //}


            // Test Verify2FA

            //Verify2FADto verify2FADto = new Verify2FADto
            //{
            //    UserId = "sampleUserId",
            //    VerifyCode = "123456"
            //};
            //var verify2FAResponse = await _accountService.Verify2FA(verify2FADto);
            //if (verify2FAResponse != null && verify2FAResponse.Success)
            //{
            //    MessageBox.Show($"2FA Verification Successful\nMessage: {verify2FAResponse.Message}");
            //}
            //else
            //{
            //    MessageBox.Show($"2FA Verification Failed\nError: {string.Join(", ", verify2FAResponse.Errors)}");
            //}

            // Test Disable2FA


            //var disable2FAResponse = await _accountService.Disable2FA();
            //if (disable2FAResponse != null && disable2FAResponse.Success)
            //{
            //    MessageBox.Show($"2FA Disabled\nMessage: {disable2FAResponse.Message}");
            //}
            //else
            //{
            //    MessageBox.Show($"Disable 2FA Failed\nError: {string.Join(", ", disable2FAResponse.Errors)}");
            //}

            // Test GetTwoFAStatus


            //var twoFAStatusResponse = await _accountService.GetTwoFAStatus();
            //if (twoFAStatusResponse != null && twoFAStatusResponse.Success)
            //{
            //    MessageBox.Show($"2FA Status Retrieved\nMessage: {twoFAStatusResponse.Message}\nTwoFactorEnabled: {twoFAStatusResponse.Data.TwoFactorEnabled}");
            //}
            //else
            //{
            //    MessageBox.Show($"Get 2FA Status Failed\nError: {string.Join(", ", twoFAStatusResponse.Errors)}");
            //}


            // Test ForgotPassword
            //ForgotPasswordDto forgotPasswordDto = new ForgotPasswordDto
            //{
            //    Email = "test@example.com"
            //};
            //var forgotPasswordResponse = await _accountService.ForgotPassword(forgotPasswordDto);
            //if (forgotPasswordResponse != null && forgotPasswordResponse.Success)
            //{
            //    MessageBox.Show($"Forgot Password Request Successful\nMessage: {forgotPasswordResponse.Message}\nReset Link: {forgotPasswordResponse.Data.ResetLink}");
            //}
            //else
            //{
            //    MessageBox.Show($"Forgot Password Request Failed\nError: {string.Join(", ", forgotPasswordResponse.Errors)}");
            //}


            // Test ResetPassword
            //ResetPasswordDto resetPasswordDto = new ResetPasswordDto
            //{
            //    Token = "sampleToken",
            //    Email = "test@example.com",
            //    NewPassword = "newPassword123"
            //};
            //var resetPasswordResponse = await _accountService.ResetPassword(resetPasswordDto);
            //if (resetPasswordResponse != null && resetPasswordResponse.Success)
            //{
            //    MessageBox.Show($"Password Reset Successful\nMessage: {resetPasswordResponse.Message}");
            //}
            //else
            //{
            //    MessageBox.Show($"Password Reset Failed\nError: {string.Join(", ", resetPasswordResponse.Errors)}");
            //}


            // Test ChangePassword
            //ChangePasswordDto changePasswordDto = new ChangePasswordDto
            //{
            //    CurrentPassword = "currentPassword123",
            //    NewPassword = "newPassword123"
            //};
            //var changePasswordResponse = await _accountService.ChangePassword(changePasswordDto);
            //if (changePasswordResponse != null && changePasswordResponse.Success)
            //{
            //    MessageBox.Show($"Password Change Successful\nMessage: {changePasswordResponse.Message}");
            //}
            //else
            //{
            //    MessageBox.Show($"Password Change Failed\nError: {string.Join(", ", changePasswordResponse.Errors)}");
            //}
            #endregion

        }

    
    }
}
