using AutoMapper;
using EcomApi.Interfaces.IManagers;
using EcomApi.Interfaces.IRepository;
using Dto = EcomApi.Models.DTOs;
using Entity = EcomApi.DataAccess.Entities;

namespace EcomApi.Managers
{
    public class UserManager:IUserManager
    {
        private readonly IBaseRepository<Entity.User> _repo;
        private readonly IMapper _mapper;
        public UserManager(IBaseRepository<Entity.User> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<IList<Dto.User>> GetAllAsync()
        {
            var UserDto = await _repo.GetAllAsync();
            return _mapper.Map<IList<Dto.User>>(UserDto);

        }
        public async Task<Dto.User> GetByIdAsync(int id)
        {
            var User = await _repo.GetByIdAsync(id);
            return _mapper.Map<Dto.User>(User);
        }
        public async Task AddAsync(Dto.User User)
        {
            var newUser = _mapper.Map<Entity.User>(User);
            await _repo.AddAsync(newUser);
        }
        public async Task UpdateAsync(Dto.User User)
        {
            var newUser = _mapper.Map<Entity.User>(User);
            await _repo.UpdateAsync(newUser);
        }
        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }
    }
}
