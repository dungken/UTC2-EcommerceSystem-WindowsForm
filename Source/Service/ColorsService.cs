using Source.DataAcess;
using Source.Dtos.Category;
using Source.Dtos.Product;
using Source.Dtos.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Service
{
    public class ColorsService
    {
        private readonly ApiClient _apiClient;
        public ColorsService()
        {
            _apiClient = new ApiClient(Utils.Config.BaseUrl);
        }
        // Create a new color
        public async Task<BaseResponse<ColorDTO>> CreateCollorAsync(ColorDTO collorDto)
        {
            return await _apiClient.PostAsync<BaseResponse<ColorDTO>>("colors", collorDto);
        }

        public async Task<BaseResponse<ColorDTO>> GetColorByIdAsync(Guid id)
        {
            return await _apiClient.GetAsync<BaseResponse<ColorDTO>>($"colors/{id}");
        }
        
        public async Task<BaseResponse<IEnumerable<ColorDTO>>> GetAllColors()
        {
            return await _apiClient.GetAsync<BaseResponse<IEnumerable<ColorDTO>>>($"colors");
        }
        public async Task<BaseResponse<ColorDTO>> UpdateColor(Guid id, ColorDTO colorDto)
        {
            return await _apiClient.PutAsync<BaseResponse<ColorDTO>>($"colors/{id}", colorDto);
        }
        public async Task<bool> DeleteColor(Guid id)
        {
            return await _apiClient.DeleteAsync($"colors/{id}");
        }



    }
}
