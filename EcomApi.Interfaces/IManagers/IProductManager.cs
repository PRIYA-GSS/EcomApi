using Dto = EcomApi.Models.DTOs;

namespace EcomApi.Interfaces.IManagers
{
    public interface IProductManager
    {
        Task<IList<Dto.Product>> GetAllAsync();
        Task<Dto.Product> GetByIdAsync(int id);
        Task AddAsync(Dto.Product product);
        Task UpdateAsync(Dto.Product Product);
        Task DeleteAsync(int id);
    }
}
