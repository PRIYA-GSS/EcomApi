using EcomApi.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Dto = EcomApi.Models.DTOs;
namespace EcomApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync(string? search)
        {
            var Products = await _service.GetAllAsync();
            return Ok(Products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var Product = await _service.GetByIdAsync(id);
            return Ok(Product);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(Dto.Product Product)
        {
            await _service.AddAsync(Product);
            return Ok("Added Successfully");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, Dto.Product Product)
        {
           
            if (id!=Product.ProductId)
                return BadRequest();
            await _service.UpdateAsync(Product);
            return Ok("Updated Successfully");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Deleted Successfully");
        }
    }
}
