using Dto = EcomApi.Models.DTOs;
namespace EcomApi.Interfaces.IManagers
{
    public interface IOrderManager
    {
        Task<IList<Dto.Order>> GetAllAsync();
        Task<Dto.Order> GetByIdAsync(int id);
        Task AddAsync(Dto.Order order);
        Task UpdateAsync(Dto.Order order);
        Task DeleteAsync(int id);
    }
}
