using RestSharp;
using Source.DataAcess;
using Source.Dtos.Account;
using Source.Dtos.Reponse;
using Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source.Service
{
    public class AccountService
    {
        private readonly ApiClient _apiClient;
        public AccountService()
        {
            _apiClient = new ApiClient(Utils.Config.BaseUrl);
        }
        public async Task<BaseResponse<LoginResponse>> LoginAsync(LoginUserDto model)
        {

            return await _apiClient.PostAsync<BaseResponse<LoginResponse>>("Account/Login", model);
        }
        public async Task<BaseResponse<User>> RegisterAsync(RegisterUserDto model)
        {
            return await _apiClient.PostAsync<BaseResponse<User>>("Account/Register", model);
        }
        public async Task<BaseResponse<User>> ConfirmEmail(ConfirmEmailDto model)
        {
            return await _apiClient.PostAsync<BaseResponse<User>>("Account/ConfirmEmail", model);
        }
        public async Task<BaseResponse<object>> Logout()
        {
            return await _apiClient.PostAsync<BaseResponse<object>>("Account/SocialLogin", null);
        } 
        public async Task<BaseResponse<LoginResponse>> SocialLogin(SocialLoginDto model)
        {
            return await _apiClient.PostAsync<BaseResponse<LoginResponse>>("Account/SocialLogin", model);
        }
        public async Task<BaseResponse<object>> Verify2FA(SocialLoginDto model)
        {
            return await _apiClient.PostAsync<BaseResponse<object>>("Account/Verify2FA", model);
        }
        // get
        public async Task<BaseResponse<object>> Enable2FA(SocialLoginDto model)
        {
            return await _apiClient.GetAsync<BaseResponse<object>>("Account/Enable2FA");
        }

        public async Task<BaseResponse<object>> Disable2FA()
        {
            return await _apiClient.GetAsync<BaseResponse<object>>("Account/Enable2FA");
        }
        public async Task<BaseResponse<object>> GetTwoFAStatus()
        {
            return await _apiClient.GetAsync<BaseResponse<object>>("Account/Enable2FA");
        }


    }
}
