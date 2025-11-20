using Dto = EcomApi.Models.DTOs;
namespace EcomApi.Interfaces.IServices
{
    public interface IUserService
    {
    Task<IList<Dto.User>> GetAllAsync();
    Task<Dto.User> GetByIdAsync(int id);
    Task AddAsync(Dto.User user);
    Task UpdateAsync(Dto.User user);
    Task DeleteAsync(int id);
    
    }
}
