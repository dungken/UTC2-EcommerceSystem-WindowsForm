using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.DataAcess;
using Source.Dtos.Account;
using Source.Dtos.Product;
using Source.Dtos.Reponse;
using Source.Models;

namespace Source.Service
{
    public class ImageService
    {
        private readonly ApiClient _apiClient;
        public ImageService()
        {
            _apiClient = new ApiClient(Utils.Config.BaseUrl);
        }
        public async Task<BaseResponse<ImageResponse>> UploadMultipleImages(ImageResponse model)
        {
            return await _apiClient.PostAsync<BaseResponse<ImageResponse>>("Images/UploadMultiple", model);
        }
        public async Task<BaseResponse<ImageDTO>> GetImagesByProductId(Guid productId)
        {
            return await _apiClient.GetAsync<BaseResponse<ImageDTO>>($"Images/GetByProductId/{productId}");
        }
        public async Task<BaseResponse<ImageDTO>> UpdateImages(ImageResponse model)
        {
            return await _apiClient.PutAsync<BaseResponse<ImageDTO>>("Images/UploadMultiple", model);
        }
        public async Task<bool> DeleteImage(Guid id)
        {
            return await _apiClient.DeleteAsync($"Images/Delete/{id}");
        }
    }
}
