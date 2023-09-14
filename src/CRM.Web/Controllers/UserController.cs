using Microsoft.AspNetCore.Mvc;
using CRM.Application.Services.Interfaces;
using CRM.Core.Dto;

namespace CRM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //todo: important! restrict each action by roles (organizer, exhibitor, visitor)
    public class UserController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public UserController(
            IWebHostEnvironment env,
            IConfiguration configuration,
            IUserService userService
            )
        {
            _env = env;
            _configuration = configuration;
            _userService = userService;
            
        }

        [Route("users")]
        [HttpGet]
        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            return await _userService.GetUsers();
        }

        [Route("user")]
        [HttpGet]
        public async Task<UserDto> GetUser()
        {
            return await _userService.GetUser();
        }
        
        [Route("user")]
        [HttpPost]
        public async Task<ActionResult> CreateUser(UserDto input)
        {
            await _userService.CreateUser(input);
            return new OkResult();

        }

        [Route("users/{id]")]
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
            var users = await _userService.GetUsers();

            return new OkResult();
        }

    }
}
