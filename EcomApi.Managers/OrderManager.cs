using AutoMapper;
using EcomApi.Interfaces.IManagers;
using EcomApi.Interfaces.IRepository;
using Dto = EcomApi.Models.DTOs;
using Entity = EcomApi.DataAccess.Entities;
namespace EcomApi.Managers
{
    public class OrderManager : IOrderManager
    {
        private readonly IBaseRepository<Entity.Order> _repo;
        private readonly IMapper _mapper;
        public OrderManager(IBaseRepository<Entity.Order> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<IList<Dto.Order>> GetAllAsync()
        {
            var OrderDto = await _repo.GetAllAsync();
            return _mapper.Map<IList<Dto.Order>>(OrderDto);

        }
        public async Task<Dto.Order> GetByIdAsync(int id)
        {
            var order = await _repo.GetByIdAsync(id);
            return _mapper.Map<Dto.Order>(order);
        }
        public async Task AddAsync(Dto.Order order)
        {
            var neworder = _mapper.Map<Entity.Order>(order);
            await _repo.AddAsync(neworder);
        }
        public async Task UpdateAsync(Dto.Order order)
        {
            var neworder = _mapper.Map<Entity.Order>(order);
            await _repo.UpdateAsync(neworder);
        }
        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }

    }
}
