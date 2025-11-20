using AutoMapper;
using EcomApi.Interfaces.IManagers;
using EcomApi.Interfaces.IRepository;
using Dto = EcomApi.Models.DTOs;
using Entity = EcomApi.DataAccess.Entities;
namespace EcomApi.Managers
{
    public class ProductManager:IProductManager
    {
        private readonly IBaseRepository<Entity.Product> _repo;
        private readonly IMapper _mapper;
        public ProductManager(IBaseRepository<Entity.Product> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<IList<Dto.Product>> GetAllAsync()
        {
            var ProductDto = await _repo.GetAllAsync();
            return _mapper.Map<IList<Dto.Product>>(ProductDto);

        }
        public async Task<Dto.Product> GetByIdAsync(int id)
        {
            var Product = await _repo.GetByIdAsync(id);
            return _mapper.Map<Dto.Product>(Product);
        }
        public async Task AddAsync(Dto.Product Product)
        {
            var newProduct = _mapper.Map<Entity.Product>(Product);
            await _repo.AddAsync(newProduct);
        }
        public async Task UpdateAsync(Dto.Product Product)
        {
            var newProduct = _mapper.Map<Entity.Product>(Product);
            await _repo.UpdateAsync(newProduct);
        }
        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }
    }
}
