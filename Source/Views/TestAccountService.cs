using Source.Dtos.Account;
using Source.Dtos.Category;
using Source.Dtos.Discount;
using Source.Dtos.Product;
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
        private readonly ColorsService _colorsService;
        private readonly ProductService _productService;
        private readonly DiscountsService _discountService;
        private readonly FeedbackService _feedbackService;

        public TestAccountService()
        {
            InitializeComponent();
            _accountService = new AccountService();
            _categoriesService = new CategoriesService();
            _colorsService = new ColorsService();
            _productService = new ProductService();
            _discountService = new DiscountsService();
            _feedbackService = new FeedbackService();

        }
        #region test _categoriesService
        private async Task CreateCategoryAsync()
        {
            CreateCategoryDto createCategoryDto = new CreateCategoryDto
            {
                Name = "New Category",
                Description = "This is a new category",
                Status = "Active",
                ParentCategoryId = null // or set a valid parent category ID if needed
            };
            var createCategoryResponse = await _categoriesService.CreateCategoryAsync(createCategoryDto);
            if (createCategoryResponse != null && createCategoryResponse.Success)
            {
                MessageBox.Show($"Category Created Successfully\nMessage: {createCategoryResponse.Message}\nCategory: {createCategoryResponse.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Category Creation Failed\nError: {string.Join(", ", createCategoryResponse.Errors)}");
            }
        }


        private async Task GetCategoryByIdAsync(Guid categoryId)
        {
            var getCategoryResponse = await _categoriesService.GetCategoryByIdAsync(categoryId);
            if (getCategoryResponse != null && getCategoryResponse.Success)
            {
                MessageBox.Show($"Category Retrieved Successfully\nMessage: {getCategoryResponse.Message}\nCategory: {getCategoryResponse.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Get Category Failed\nError: {string.Join(", ", getCategoryResponse.Errors)}");
            }
        }


        private async Task UpdateCategoryAsync(Guid categoryId)
        {
            UpdateCategoryDto updateCategoryDto = new UpdateCategoryDto
            {
                Name = "Updated Category",
                Description = "This is an updated category",
                Status = "Active",
                ParentCategoryId = null // or set a valid parent category ID if needed
            };
            var updateCategoryResponse = await _categoriesService.UpdateCategory(categoryId, updateCategoryDto);
            if (updateCategoryResponse != null && updateCategoryResponse.Success)
            {
                MessageBox.Show($"Category Updated Successfully\nMessage: {updateCategoryResponse.Message}\nCategory: {updateCategoryResponse.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Category Update Failed\nError: {string.Join(", ", updateCategoryResponse.Errors)}");
            }
        }


        private async Task DeleteCategoryAsync(Guid categoryId)
        {
            var deleteCategoryResponse = await _categoriesService.DeleteCategory(categoryId);
            if (deleteCategoryResponse)
            {
                MessageBox.Show($"Category Deleted Successfully");
            }
            else
            {
                MessageBox.Show($"Category Deletion Failed");
            }
        }


        private async Task GetAllCategoriesAsync()
        {
            var getAllCategoriesResponse = await _categoriesService.GetAllCategories();
            if (getAllCategoriesResponse != null && getAllCategoriesResponse.Success)
            {
                foreach (var item in getAllCategoriesResponse.Data)
                {
                    MessageBox.Show($"Category: {item.Name}");
                }
            }
            else
            {
                MessageBox.Show($"Get All Categories Failed\nError: {string.Join(", ", getAllCategoriesResponse.Errors)}");
            }
        }

        #endregion


        #region test _accountService

        private async Task TestLoginAsync()
        {
            LoginUserDto loginDto = new LoginUserDto
            {
                EmailOrUsername = "duoc14525@gmail.com",
                Password = "123456aA@"
            };
            var response = await _accountService.LoginAsync(loginDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Message: {response.Message}\nToken: {response.Data.Token}\nUser: {response.Data.User.UserName}");
                Utils.Config.token = response.Data.Token;
            }
            else
            {
                MessageBox.Show($"Error: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestRegisterAsync()
        {
            RegisterUserDto registerDto = new RegisterUserDto
            {
                Email = "6351071021@st.utc2.edu.vn",
                UserName = "testuser2",
                Password = "password123A@",
                FirstName = "Test",
                LastName = "User"
            };
            var response = await _accountService.RegisterAsync(registerDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Registration Successful\nMessage: {response.Message}\nUser: {response.Data.UserName}");
            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestConfirmEmailAsync()
        {
            ConfirmEmailDto confirmEmailDto = new ConfirmEmailDto
            {
                Token = "CfDJ8MMhO3A1IBpLrRudcTwhJRgRSQgdVO6Q%2bqTL%2fqcWFffk%2b8rGWi1vx6wYZ%2fc98yBmeazvwoGzaX1vNZnf5Bpch%2bMqChmt%2bsQn54gDVSFBlZ26JnyMfzfmZkgGwBKjixKDCTmt9FgSQGWmNJbeT1u2UbACcMITbxEDPa%2bLRZV3UMa6xi2Z0Lzbxvue8ShIFI1bWZoqeZyfY43D3LWiqTwY6j6lKDY3LaT06RHhUwvwF6UWsuZwWnUEamIOSFf213FT9w%3d%3d",
                Email = "6351071021@st.utc2.edu.vn"
            };
            var response = await _accountService.ConfirmEmail(confirmEmailDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Email Confirmation Successful\nMessage: {response.Message}\nUser: {response.Data.UserName}");
            }
            else
            {
                MessageBox.Show($"Email Confirmation Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestLogoutAsync()
        {
            var response = await _accountService.Logout();
            if (response != null && response.Success)
            {
                MessageBox.Show($"Logout Successful\nMessage: {response.Message}");
            }
            else
            {
                MessageBox.Show($"Logout Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }
        private async Task TestSocialLoginAsync()
        {
            SocialLoginDto socialLoginDto = new SocialLoginDto
            {
                AccessToken = "sampleAccessToken",
                Provider = "Google"
            };
            var response = await _accountService.SocialLogin(socialLoginDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Social Login Successful\nMessage: {response.Message}\nToken: {response.Data.Token}\nUser: {response.Data.User.UserName}");
            }
            else
            {
                MessageBox.Show($"Social Login Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestEnable2FAAsync()
        {
            var response = await _accountService.Enable2FA();
            if (response != null && response.Success)
            {
                MessageBox.Show($"2FA Enabled\nMessage: {response.Message}\nVerification Code: {response.Data.VerificationCode}");
            }
            else
            {
                MessageBox.Show($"Enable 2FA Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestVerify2FAAsync()
        {
            Verify2FADto verify2FADto = new Verify2FADto
            {
                UserId = "sampleUserId",
                VerifyCode = "123456"
            };
            var response = await _accountService.Verify2FA(verify2FADto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"2FA Verification Successful\nMessage: {response.Message}");
            }
            else
            {
                MessageBox.Show($"2FA Verification Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }
        private async Task TestDisable2FAAsync()
        {
            var response = await _accountService.Disable2FA();
            if (response != null && response.Success)
            {
                MessageBox.Show($"2FA Disabled\nMessage: {response.Message}");
            }
            else
            {
                MessageBox.Show($"Disable 2FA Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }
        private async Task TestGetTwoFAStatusAsync()
        {
            var response = await _accountService.GetTwoFAStatus();
            if (response != null && response.Success)
            {
                MessageBox.Show($"2FA Status Retrieved\nMessage: {response.Message}\nTwoFactorEnabled: {response.Data.TwoFactorEnabled}");
            }
            else
            {
                MessageBox.Show($"Get 2FA Status Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }
        private async Task TestResetPasswordAsync()
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
        private async Task TestChangePasswordAsync()
        {
            ChangePasswordDto changePasswordDto = new ChangePasswordDto
            {
                CurrentPassword = "currentPassword123",
                NewPassword = "newPassword123"
            };
            var response = await _accountService.ChangePassword(changePasswordDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Password Change Successful\nMessage: {response.Message}");
            }
            else
            {
                MessageBox.Show($"Password Change Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }
        private async Task TestForgotPasswordAsync()
        {
            ForgotPasswordDto forgotPasswordDto = new ForgotPasswordDto
            {
                Email = "test@example.com"
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

        #endregion


        #region test _colorsService
        private async Task CreateColorAsync()
        {
            try
            {
                ColorDTO colorDto = new ColorDTO
                {
                    Id = Guid.NewGuid(),
                    Name = "New Color test",
                    ColorCode = "#FFFFFF"
                };
                // Response is a BaseResponse<ColorDTO>, alwawys null but the code is working
                var response = await _colorsService.CreateCollorAsync(colorDto);
                if (response != null)
                {
                    MessageBox.Show($"Discount Created Successfully\nMessage: \nDiscount: {response.Name}");
               
                }
                else
                {
                    MessageBox.Show($"Discount Creation Failed\nError: Not create object");
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                MessageBox.Show($"Exception1 in CreateColorAsync: {ex.Message}");
            }
        }

        private async Task GetColorByIdAsync(Guid colorId)
        {
            var response = await _colorsService.GetColorByIdAsync(colorId);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Color Retrieved Successfully\nMessage: {response.Message}\nColor: {response.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Get Color Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }
        private async Task UpdateColorAsync(Guid colorId)
        {
            ColorDTO colorDto = new ColorDTO
            {
                Id = colorId,
                Name = "Updated Color",
                ColorCode = "#000000"
            };
            var response = await _colorsService.UpdateColor(colorId, colorDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Color Updated Successfully\nMessage: {response.Message}\nColor: {response.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Color Update Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task DeleteColorAsync(Guid colorId)
        {
            var response = await _colorsService.DeleteColor(colorId);
            if (response)
            {
                MessageBox.Show($"Color Deleted Successfully");
            }
            else
            {
                MessageBox.Show($"Color Deletion Failed");
            }
        }
        private async Task GetAllColorsAsync()
        {
            var response = await _colorsService.GetAllColors();
            if (response != null && response.Success)
            {
                foreach (var item in response.Data)
                {
                    MessageBox.Show($"Color: {item.Name}");
                }
            }
            else
            {
                MessageBox.Show($"Get All Colors Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        #endregion


        #region test _discountService
        private async Task TestCreateDiscountAsync()
        {
            CreateDiscountDto createDiscountDto = new CreateDiscountDto
            {
                Name = "New Year Discount",
                Percentage = 10.5m,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1)
            };
            var response = await _discountService.CreateDiscountAsync(createDiscountDto);
            if (response != null)
            {
                MessageBox.Show($"Discount Created Successfully\nMessage: \nDiscount: {response.Name}");
            }
            else
            {
                MessageBox.Show($"Discount Creation Failed\nError: Not create object");
            }
        }

        private async Task TestGetAllDiscountsAsync()
        {
            var response = await _discountService.GetAllDiscounts();
            if (response != null && response.Success)
            {
                foreach (var item in response.Data)
                {
                    MessageBox.Show($"Discount: {item.Name}");
                }
            }
            else
            {
                MessageBox.Show($"Get All Discounts Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestGetDiscountByIdAsync(Guid discountId)
        {
            var response = await _discountService.GetDiscountByIdAsync(discountId);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Discount Retrieved Successfully\nMessage: {response.Message}\nDiscount: {response.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Get Discount Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestUpdateDiscountAsync(Guid discountId)
        {
            CreateDiscountDto updateDiscountDto = new CreateDiscountDto
            {
                Name = "Updated Discount",
                Percentage = 15.0m,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(2)
            };
            var response = await _discountService.UpdateDiscount(discountId, updateDiscountDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Discount Updated Successfully\nMessage: {response.Message}\nDiscount: {response.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Discount Update Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestDeleteDiscountAsync(Guid discountId)
        {
            var response = await _discountService.DeleteDiscount(discountId);
            if (response)
            {
                MessageBox.Show($"Discount Deleted Successfully");
            }
            else
            {
                MessageBox.Show($"Discount Deletion Failed");
            }
        }

        #endregion


        #region test _feedbackService
        private async Task TestCreateFeedbackAsync()
        {
            CreateFeedbackDto createFeedbackDto = new CreateFeedbackDto
            {
                ProductId = Guid.Parse("AB3A1D7B-23A7-45BD-9E75-1EA2640F9D2B"),
                Rating = 5,
                Comment = "Great product!"
            };
    
            var response = await _feedbackService.CreateFeedbackAsync(createFeedbackDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Feedback Created Successfully\nMessage: {response.Message}\nFeedback: {response.Data.Comment}");
            }
            else
            {
                MessageBox.Show($"Feedback Creation Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestGetFeedbackByIdAsync(Guid feedbackId)
        {
            var response = await _feedbackService.GetFeedbackByIdAsync(feedbackId);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Feedback Retrieved Successfully\nMessage: {response.Message}\nFeedback: {response.Data.Comment}");
            }
            else
            {
                MessageBox.Show($"Get Feedback Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestGetAllFeedbacksForAProductAsync(Guid productId)
        {
            var response = await _feedbackService.GetAllFeedbacksForAProduct(productId);
            if (response != null && response.Success)
            {
                foreach (var item in response.Data)
                {
                    MessageBox.Show($"Feedback: {item.Comment}");
                }
            }
            else
            {
                MessageBox.Show($"Get All Feedbacks Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestUpdateFeedbackAsync(Guid feedbackId)
        {
            UpdateFeedbackDto updateFeedbackDto = new UpdateFeedbackDto
            {
                Rating = 4,
                Comment = "Good product, but could be better."
            };
            var response = await _feedbackService.UpdateFeedback(feedbackId, updateFeedbackDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Feedback Updated Successfully\nMessage: {response.Message}\nFeedback: {response.Data.Comment}");
            }
            else
            {
                MessageBox.Show($"Feedback Update Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestDeleteFeedbackAsync(Guid feedbackId)
        {
            var response = await _feedbackService.DeleteFeedback(feedbackId);
            if (response)
            {
                MessageBox.Show($"Feedback Deleted Successfully");
            }
            else
            {
                MessageBox.Show($"Feedback Deletion Failed");
            }
        }


        #endregion

        #region test _productService

        private async Task TestCreateProductAsync()
        {
            ProductDTO createProductDto = new ProductDTO
            {
                Id = Guid.NewGuid(),
                Name = "New Product",
                Description = "This is a new product",
                Price = 100.0m,
                StockQuantity = 50,
                CategoryId = Guid.Parse("C0CA6AA4-2787-4EEE-9A16-10B21C3322D0"),
                Status = "Active",
                Colors = new List<ColorDTO>
        {
            new ColorDTO { Id = Guid.NewGuid(), Name = "Red", ColorCode = "#FF0000" }
        },
                Sizes = new List<SizeDTO>
        {
            new SizeDTO { Id = Guid.NewGuid(), Name = "M" }
        },
                Images = new List<ImageDTO>
        {
            new ImageDTO { Id = Guid.NewGuid(), Url = "http://example.com/image.jpg", AltText = "Product Image" }
        },
                Discounts = new List<DiscountDto>
        {
            new DiscountDto { Id = Guid.NewGuid(), Name = "Summer Sale", Percentage = 10.0m, StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1) }
        },
                Feedbacks = new List<FeedbackDTO>()
            };
            var response = await _productService.CreateProductAsync(createProductDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Product Created Successfully\nMessage: {response.Message}\nProduct: {response.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Product Creation Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestGetProductByIdAsync(Guid productId)
        {
            var response = await _productService.GetProductByIdAsync(productId);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Product Retrieved Successfully\nMessage: {response.Message}\nProduct: {response.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Get Product Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestGetAllProductsAsync()
        {
            var response = await _productService.GetAllProducts();
            if (response != null && response.Success)
            {
                foreach (var item in response.Data)
                {
                    MessageBox.Show($"Product: {item.Name}");
                }
            }
            else
            {
                MessageBox.Show($"Get All Products Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestGetProductsByCategoryAsync(Guid categoryId)
        {
            var response = await _productService.GetProductsByCategory(categoryId);
            if (response != null && response.Success)
            {
                foreach (var item in response.Data)
                {
                    MessageBox.Show($"Product: {item.Name}");
                }
            }
            else
            {
                MessageBox.Show($"Get Products by Category Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestUpdateProductAsync(Guid productId)
        {
            ProductDTO updateProductDto = new ProductDTO
            {
                Id = productId,
                Name = "Updated Product",
                Description = "This is an updated product",
                Price = 120.0m,
                StockQuantity = 40,
                CategoryId = Guid.Parse("C0CA6AA4-2787-4EEE-9A16-10B21C3322D0"),
                Status = "Active",
                Colors = new List<ColorDTO>
        {
            new ColorDTO { Id = Guid.NewGuid(), Name = "Blue", ColorCode = "#0000FF" }
        },
                Sizes = new List<SizeDTO>
        {
            new SizeDTO { Id = Guid.NewGuid(), Name = "L" }
        },
                Images = new List<ImageDTO>
        {
            new ImageDTO { Id = Guid.NewGuid(), Url = "http://example.com/image2.jpg", AltText = "Updated Product Image" }
        },
                Discounts = new List<DiscountDto>
        {
            new DiscountDto { Id = Guid.NewGuid(), Name = "Winter Sale", Percentage = 15.0m, StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(2) }
        },
                Feedbacks = new List<FeedbackDTO>()
            };
            var response = await _productService.UpdateProduct(productId, updateProductDto);
            if (response != null && response.Success)
            {
                MessageBox.Show($"Product Updated Successfully\nMessage: {response.Message}\nProduct: {response.Data.Name}");
            }
            else
            {
                MessageBox.Show($"Product Update Failed\nError: {string.Join(", ", response.Errors)}");
            }
        }

        private async Task TestDeleteProductAsync(Guid productId)
        {
            var response = await _productService.DeleteProduct(productId);
            if (response)
            {
                MessageBox.Show($"Product Deleted Successfully");
            }
            else
            {
                MessageBox.Show($"Product Deletion Failed");
            }
        }

        #endregion


        private async void btnCate_Click(object sender, EventArgs e)
        {
            // Create Category
            await CreateCategoryAsync();

            // Assuming you have the categoryId from the create response
            Guid categoryId = Guid.Parse("C0CA6AA4-2787-4EEE-9A16-10B21C3322D0");

            // Get Category by ID
            //await GetCategoryByIdAsync(categoryId);

            // Update Category
            await UpdateCategoryAsync(categoryId);

            // Delete Category
            await DeleteCategoryAsync(categoryId);

            // Get All Categories
            await GetAllCategoriesAsync();

        }

        private async void btnAccount_Click(object sender, EventArgs e)
        {
            //await TestRegisterAsync();
            await TestLoginAsync();
            //await TestConfirmEmailAsync();
            //await TestLogoutAsync();
            //await TestSocialLoginAsync();
            //await TestEnable2FAAsync();
            //await TestVerify2FAAsync();
            //await TestDisable2FAAsync();
            //await TestGetTwoFAStatusAsync();
            //await TestForgotPasswordAsync();
            //await TestResetPasswordAsync();
            //await TestChangePasswordAsync();

        }

        private async void btnColors_Click(object sender, EventArgs e)
        {
            // Create Color
            await CreateColorAsync();

            //// Assuming you have the colorId from the create response
            //Guid colorId = Guid.Parse("02D3CBE5-17AC-4307-AF8A-1459F357CAF4");

            ////    // Get Color by ID
            //await GetColorByIdAsync(colorId);

            ////    // Update Color
            //await UpdateColorAsync(colorId);

            //// Delete Color
            //await DeleteColorAsync(colorId);

            //// Get All Colors
            //await GetAllColorsAsync();
        }

        private async void btnDiscount_Click(object sender, EventArgs e)
        {
            // Create Discount
            await TestCreateDiscountAsync();

            // Assuming you have the discountId from the create response
            Guid discountId = Guid.Parse("0cb03d51-5b01-4f3b-9f18-13a4140fedbe");

            // Get Discount by ID
            await TestGetDiscountByIdAsync(discountId);

            // Update Discount
            await TestUpdateDiscountAsync(discountId);

            // Delete Discount
            await TestDeleteDiscountAsync(discountId);

            // Get All Discounts
            await TestGetAllDiscountsAsync();
        }

        private async void btnFeedBack_Click(object sender, EventArgs e)
        {
            // Create Feedback
            await TestCreateFeedbackAsync(); // it do not macth with the api

            //// Assuming you have the feedbackId from the create response
            //Guid feedbackId = Guid.Parse("54820FE4-0F3B-418A-B0E8-05F549FCE5C8");

            //// Get Feedback by ID
            //await TestGetFeedbackByIdAsync(feedbackId);

            //// Update Feedback
            //await TestUpdateFeedbackAsync(feedbackId);

            //// Delete Feedback
            //await TestDeleteFeedbackAsync(feedbackId);

            //// Get All Feedbacks for a Product
            //Guid productId = Guid.Parse("AB3A1D7B-23A7-45BD-9E75-1EA2640F9D2B");
            //await TestGetAllFeedbacksForAProductAsync(productId);

        }

        private async void btnProduct_Click(object sender, EventArgs e)
        {
            // Create Product
            await TestCreateProductAsync();

            // Assuming you have the productId from the create response
            Guid productId = Guid.Parse("02D3CBE5-17AC-4307-AF8A-1459F357CAF4");

            // Get Product by ID
            await TestGetProductByIdAsync(productId);

            // Update Product
            await TestUpdateProductAsync(productId);

            // Delete Product
            await TestDeleteProductAsync(productId);

            // Get All Products
            await TestGetAllProductsAsync();

            // Get Products by Category
            Guid categoryId = Guid.Parse("C0CA6AA4-2787-4EEE-9A16-10B21C3322D0");
            await TestGetProductsByCategoryAsync(categoryId);

        }

       
    }
}
