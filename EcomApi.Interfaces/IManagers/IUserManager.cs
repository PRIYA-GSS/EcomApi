using Dto = EcomApi.Models.DTOs;

namespace EcomApi.Interfaces.IManagers
{
    public interface IUserManager
    {
        Task<IList<Dto.User>> GetAllAsync();
        Task<Dto.User> GetByIdAsync(int id);
        Task AddAsync(Dto.User user);
        Task UpdateAsync(Dto.User user);
        Task DeleteAsync(int id);
    }
}
