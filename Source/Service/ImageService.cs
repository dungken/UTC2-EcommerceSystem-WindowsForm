using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.DataAcess;
using Source.Dtos.Account;
using Source.Dtos.Image;
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
        public async Task<BaseResponse<UploadImagesResponse>> UploadMultipleImages(UploadImagesResponse model)
        {
            return await _apiClient.PostAsync<BaseResponse<UploadImagesResponse>>("Images/UploadMultiple", model);
        }
        public async Task<BaseResponse<ImageDTO>> GetImagesByProductId(Guid productId)
        {
            return await _apiClient.GetAsync<BaseResponse<ImageDTO>>($"Images/GetByProductId/{productId}");
        }
        public async Task<BaseResponse<UpdateImagesRespone>> UpdateImages(UpdateImagesRespone model)
        {
            return await _apiClient.PutAsync<BaseResponse<UpdateImagesRespone>>("Images/UploadMultiple", model);
        }
        public async Task<bool> DeleteImage(Guid id)
        {
            return await _apiClient.DeleteAsync($"Images/Delete/{id}");
        }
    }
}
