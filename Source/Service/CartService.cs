using Source.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Dtos;
using Source.Models;
using api.Dtos.Cart;
namespace Source.Service
{
    public class CartService
    {
        private readonly ApiClient _apiClient;
        public CartService()
        {
            _apiClient = new ApiClient(Utils.Config.BaseUrl);
        }
        public async Task<Cart> GetCartByUserIdAsync(Guid userId)
        {
            return await _apiClient.GetAsync<Cart>($"api/cart/{userId}");
        }

        public async Task AddToCartAsync(Guid userId, InforProductForCartDto inforProductForCart)
        {
            await _apiClient.PostAsync<object>($"api/cart/Add?userId={userId}", inforProductForCart);
        }

        public async Task RemoveFromCartAsync(Guid userId, Guid cartItemId)
        {
            await _apiClient.DeleteAsync($"api/cart/Remove?userId={userId}&cartItemId={cartItemId}");
        }

        public async Task ClearCartAsync(Guid userId)
        {
            await _apiClient.DeleteAsync($"api/cart/Clear/{userId}");
        }

        public async Task<decimal> GetCartTotalAsync(Guid userId)
        {
            return await _apiClient.GetAsync<decimal>($"api/cart/total/{userId}");
        }
    }
}
