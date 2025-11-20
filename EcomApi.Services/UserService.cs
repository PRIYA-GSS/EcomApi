using EcomApi.Interfaces.IManagers;
using EcomApi.Interfaces.IServices;
using Dto = EcomApi.Models.DTOs;
namespace EcomApi.Services
{
    public class UserService:IUserService
    {
        private readonly IUserManager _manager;

        public UserService(IUserManager manager)
        {
            _manager = manager;
        }
        public async Task<IList<Dto.User>> GetAllAsync() => await _manager.GetAllAsync();
        public async Task<Dto.User> GetByIdAsync(int id) => await _manager.GetByIdAsync(id);
        public async Task AddAsync(Dto.User User) => await _manager.AddAsync(User);
        public async Task UpdateAsync(Dto.User User) => await _manager.UpdateAsync(User);
        public async Task DeleteAsync(int id) => await _manager.DeleteAsync(id);
    }
}
