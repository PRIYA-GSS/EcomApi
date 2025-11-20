using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto = EcomApi.Models.DTOs;
namespace EcomApi.Interfaces.IServices
{
    public interface IProductService
    {

        Task<IList<Dto.Product>> GetAllAsync(string? search);
        Task<Dto.Product> GetByIdAsync(int id);
        Task AddAsync(Dto.Product product);
        Task UpdateAsync(Dto.Product Product);
        Task DeleteAsync(int id);
    }
}
