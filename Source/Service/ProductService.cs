using Source.DataAcess;
using Source.Dtos.Product;
using Source.Dtos.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Service
{
    public class ProductService
    {
        private readonly ApiClient _apiClient;
        public ProductService()
        {
            _apiClient = new ApiClient(Utils.Config.BaseUrl);
        }
        // Create a new product
        public async Task<BaseResponse<ProductDTO>> CreateProductAsync(ProductDTO productDto)
        {
            return await _apiClient.PostAsync<BaseResponse<ProductDTO>>("Products/Create", productDto);
        }
        // Get product by id
        public async Task<BaseResponse<ProductDTO>> GetProductByIdAsync(Guid id)
        {
            return await _apiClient.GetAsync<BaseResponse<ProductDTO>>($"Products/{id}");
        }
        // Get all products
        public async Task<BaseResponse<IEnumerable<ProductDTO>>> GetAllProducts()
        {
            return await _apiClient.GetAsync<BaseResponse<IEnumerable<ProductDTO>>>($"Products");
        }
        // Get Products by category
        public async Task<BaseResponse<IEnumerable<ProductDTO>>> GetProductsByCategory(Guid categoryId)
        {
            return await _apiClient.GetAsync<BaseResponse<IEnumerable<ProductDTO>>>($"Products/Category/{categoryId}");
        }

        // Update product
        public async Task<BaseResponse<ProductDTO>> UpdateProduct(Guid id, ProductDTO productDto)
        {
            return await _apiClient.PutAsync<BaseResponse<ProductDTO>>($"Products/{id}", productDto);
        }

        // Delete product
        public async Task<bool> DeleteProduct(Guid id)
        {
            return await _apiClient.DeleteAsync($"Products/{id}");
        }
    }
}
