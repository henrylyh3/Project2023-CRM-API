using Microsoft.AspNetCore.Mvc;
using CRM.Application.Services;
using CRM.Core.Dto;

namespace CRM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;


        public UserController(IConfiguration configuration)
        {
            _userService = new UserService(configuration);
        }

        [Route("users")]
        [HttpGet]
        public async Task<List<UserDto>> GetUsers()
        {
            return await _userService.GetUsers();
        }

        [Route("user/{id}")]
        [HttpGet]
        public async Task<UserDto> GetUserById(string id)
        {
            return await _userService.GetUserById(id);
        }
        
        [Route("user")]
        [HttpPost]
        public async Task<ActionResult> CreateUser(UserDto input)
        {
            await _userService.CreateUser(input);
            return new OkResult();

        }

        [Route("user/{id}")]
        [HttpDelete]
        public async Task<ActionResult> DeleteUser(string id)
        {
            await _userService.DeleteUserById(id);

            return new OkResult();
        }

        [Route("user")]
        [HttpPut]
        public async Task<ActionResult> UpdateUser(UserDto input)
        {
            await _userService.UpdateUser(input);

            return new OkResult();
        }

    }
}
