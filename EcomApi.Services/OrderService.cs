using EcomApi.Interfaces.IManagers;
using EcomApi.Interfaces.IServices;
using Dto = EcomApi.Models.DTOs;
namespace EcomApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderManager _manager;

        public OrderService(IOrderManager manager)
        {
            _manager = manager;
        }
        public async Task<IList<Dto.Order>> GetAllAsync() => await _manager.GetAllAsync();
        public async Task<Dto.Order> GetByIdAsync(int id) => await _manager.GetByIdAsync(id);
        public async Task AddAsync(Dto.Order order) => await _manager.AddAsync(order);
        public async Task UpdateAsync(Dto.Order order) => await _manager.UpdateAsync(order);
        public async Task DeleteAsync(int id) => await _manager.DeleteAsync(id);

    }
}
