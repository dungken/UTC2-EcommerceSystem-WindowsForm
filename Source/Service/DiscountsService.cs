using Source.DataAcess;
using Source.Dtos.Product;
using Source.Dtos.Discount;
using Source.Dtos.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Service
{
    public class DiscountsService
    {
        private readonly ApiClient _apiClient;
        public DiscountsService()
        {
            _apiClient = new ApiClient(Utils.Config.BaseUrl);
        }
        // Create a new discount
        public async Task<DiscountDto> CreateDiscountAsync(CreateDiscountDto discountDto)
        {
            return await _apiClient.PostAsync<DiscountDto>("Discounts", discountDto);
        }
        // Get all discounts
        public async Task<BaseResponse<IEnumerable<DiscountDto>>> GetAllDiscounts()
        {
            return await _apiClient.GetAsync<BaseResponse<IEnumerable<DiscountDto>>>($"Discounts");
        }

        // Get discount by id
        public async Task<BaseResponse<DiscountDto>> GetDiscountByIdAsync(Guid id)
        {
            return await _apiClient.GetAsync<BaseResponse<DiscountDto>>($"Discounts/{id}");
        }

        // Update discount
        public async Task<BaseResponse<DiscountDto>> UpdateDiscount(Guid id, CreateDiscountDto discountDto)
        {
            return await _apiClient.PutAsync<BaseResponse<DiscountDto>>($"Discounts/{id}", discountDto);
        }

        // Delete discount
        public async Task<bool> DeleteDiscount(Guid id)
        {
            return await _apiClient.DeleteAsync($"Discounts/{id}");
        }
    }
}
