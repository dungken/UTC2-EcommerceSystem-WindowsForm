using Microsoft.AspNetCore.Http;
using Source.DataAcess;
using Source.Dtos.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Service
{
    public class UserService
    {
        private readonly ApiClient _apiClient;
        public UserService()
        {
            _apiClient = new ApiClient(Utils.Config.BaseUrl);
        }
        // GenerateSignature method
        public async Task<BaseResponse<GenerateSignatureRespone>> GenerateSignature(Dictionary<string, string> parameters) {
            return await _apiClient.PostAsync<BaseResponse<GenerateSignatureRespone>>("User/GenerateSignature", parameters);
        }

        // Upload Image method
        public async Task<BaseResponse<MessageRespone>> UploadImage(IFormFile file, string? username = null)
        {
            var formData = new MultipartFormDataContent();
            formData.Add(new StreamContent(file.OpenReadStream()), "file", file.FileName);
            if (username != null)
            {
                formData.Add(new StringContent(username), "username");
            }
            return await _apiClient.PostAsync<BaseResponse<MessageRespone>>("User/UploadImage", formData);
        }

        // Get User by Id
        public async Task<BaseResponse<User>> GetUserById(Guid id)
        {
            return await _apiClient.GetAsync<BaseResponse<User>>($"User/{id}");
        }

    }
}
