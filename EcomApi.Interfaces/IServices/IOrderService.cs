using Dto = EcomApi.Models.DTOs;
namespace EcomApi.Interfaces.IServices
{
    public interface IOrderService
    {
        Task<IList<Dto.Order>> GetAllAsync();
        Task<Dto.Order> GetByIdAsync(int id);
        Task AddAsync(Dto.Order order);
        Task UpdateAsync(Dto.Order order);
        Task DeleteAsync(int id);
    }
}
