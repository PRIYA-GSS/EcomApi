using EcomApi.Interfaces.IManagers;
using EcomApi.Interfaces.IServices;
using Dto = EcomApi.Models.DTOs;
namespace EcomApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductManager _manager;

        public ProductService(IProductManager manager)
        {
            _manager = manager;
        }
        public async Task<IList<Dto.Product>> GetAllAsync() => await _manager.GetAllAsync();
        public async Task<Dto.Product> GetByIdAsync(int id) => await _manager.GetByIdAsync(id);
        public async Task AddAsync(Dto.Product Product) => await _manager.AddAsync(Product);
        public async Task UpdateAsync(Dto.Product Product) => await _manager.UpdateAsync(Product);
        public async Task DeleteAsync(int id) => await _manager.DeleteAsync(id);

    }
}
