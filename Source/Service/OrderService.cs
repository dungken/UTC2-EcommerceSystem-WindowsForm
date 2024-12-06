using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.DataAcess;
using Source.Dtos.Order;
using Source.Dtos.Reponse;

namespace Source.Service
{
    public class OrderService
    {
        private readonly ApiClient _apiClient;
        public OrderService()
        {
            _apiClient = new ApiClient(Utils.Config.BaseUrl);
        }
        public async Task<BaseResponse<CreateOrderDto>> CreateOrder(CreateOrderDto model)
        {
            return await _apiClient.PostAsync<BaseResponse<CreateOrderDto>>("Order", model);
        }
        public async Task<BaseResponse<OrderDto>> GetOrderById(Guid id)
        {
            return await _apiClient.GetAsync<BaseResponse<OrderDto>>($"Order/{id}");
        }
        public async Task<BaseResponse<IEnumerable<OrderDto>>> GetAllOrders()
        {
            return await _apiClient.GetAsync<BaseResponse<IEnumerable<OrderDto>>>("Order");
        }
        public async Task<bool> UpdateOrderStatus(Guid orderId, string status)
        {
            return await _apiClient.PatchAsync<bool>($"Order/{orderId}/status", status);
        }

    }
}
