using EcomApi.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Dto = EcomApi.Models.DTOs;
namespace EcomApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var Users = await _service.GetAllAsync();
            return Ok(Users);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var User = await _service.GetByIdAsync(id);
            return Ok(User);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody]Dto.User User)
        {
            await _service.AddAsync(User);
            return Ok("Added Successfully");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id,[FromBody] Dto.User User)
        {
           
            if (id!=User.UserId)
                return BadRequest();
            await _service.UpdateAsync(User);
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
