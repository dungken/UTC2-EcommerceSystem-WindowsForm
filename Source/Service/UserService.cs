using Microsoft.AspNetCore.Http;
using Source.DataAcess;
using Source.Dtos.Reponse;
using Source.Dtos.Role;
using Source.Dtos.User;
using Source.Models;
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
        public async Task<BaseResponse<GetUserRespone>> GetUserById(Guid id)
        {
            return await _apiClient.GetAsync<BaseResponse<GetUserRespone>>($"User/Get/{id}");
        }

        // Get All user 
        public async Task<BaseResponse<GetAllUserRespone>> GetAllUser(int page = 1, int pageSize = 10)
        {
            return await _apiClient.GetAsync<BaseResponse<GetAllUserRespone>>("User/GetAll");
        }
        // Create User method
        public async Task<BaseResponse<AddUserDto>> CreateUser(AddUserDto model)
        {
            return await _apiClient.PostAsync<BaseResponse<AddUserDto>>("User/Create", model);
        }

        // Update User method
        public async Task<BaseResponse<User>> UpdateUser(UpdateUserDto model)
        {
            return await _apiClient.PutAsync<BaseResponse<User>>("User/Update", model);
        }

        // Get Personal Information method
        public async Task<BaseResponse<GetPersonalInformationRespone>> GetPersonalInformation()
        {
            return await _apiClient.GetAsync<BaseResponse<GetPersonalInformationRespone>>("User/GetPersonalInformation");
        }

        // Update Personal Infomaion method
        public async Task<BaseResponse<UpdatePersonalInfoDto>> UpdatePersonalInformation(UpdatePersonalInfoDto model)
        {
            return await _apiClient.PutAsync<BaseResponse<UpdatePersonalInfoDto>>("User/UpdatePersonalInformation", model);
        }

        // Delete Account method
        public async Task<bool> DeleteAccount()
        {
            return await _apiClient.DeleteAsync("User/DeleteAccount");
        }

        // Bulk Soft Delete method
        public async Task<BaseResponse<List<string>>> BulkSoftDelete(List<string> userIds)
        {
            return await _apiClient.PostAsync<BaseResponse<List<string>>>("User/BulkSoftDelete", userIds);
        }

        // Bulk Restore method
        public async Task<BaseResponse<List<string>>> BulkRestoreUser(List<string> userIds)
        {
            return await _apiClient.PostAsync<BaseResponse<List<string>>>("User/BulkRestore", userIds);
        }

        // Restore
        public async Task<BaseResponse<User>> RestoreUser(RestoreUserDto restoreUserDto)
        {
            return await _apiClient.PostAsync<BaseResponse<User>>($"User/Restore");
        }

        // Export Excel method
        public async Task<BaseResponse<byte[]>> ExportUserToExcel()
        {
            return await _apiClient.GetAsync<BaseResponse<byte[]>>("User/Export/Excel");
        }
        // Check email/Username exist method
        public async Task<BaseResponse<CheckUsernameEmailRespone>> CheckEmailUsernameExist(string email, string username)
        {
            return await _apiClient.GetAsync<BaseResponse<CheckUsernameEmailRespone>>($"User/CheckEmailUsernameExist?email={email}&username={username}");
        }

        // Assign Role To User method
        public async Task<BaseResponse<User>> AssignRoleToUser(AssignRoleToUserRequest model)
        {
            return await _apiClient.PostAsync<BaseResponse<User>>("User/AssignRole", model);
        }

        // Search User method
        public async Task<BaseResponse<User>> SearchUser(string searchTerm)
        {
            return await _apiClient.GetAsync<BaseResponse<User>>($"User/Search");
        }
    }
}
