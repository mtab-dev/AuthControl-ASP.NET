using AuthControl.API.Abstractions;
using AuthControl.API.DTO.Request;
using AuthControl.API.Entitites;
using Microsoft.AspNetCore.Mvc;

namespace AuthControl.API.Controllers
{
    [Route("v1/user")]
    [ApiController]
    public class UserController : Controller
    {
       private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(CreateUserDTO user)
        {
            var createdUser = await _userService.CreateUserAsync(user);
            return Ok(createdUser);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            var user = await _userService.Login(login);
            return Ok(user);
        }

        [HttpDelete("delete/{username}")]
        public async Task<IActionResult> DeleteUser(string username)
        {
            var user = await _userService.DeleteUserAsync(username);
            return Ok(user);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser(UserEntity user)
        {
            var updatedUser = await _userService.UpdateUserAsync(user);
            return Ok(updatedUser);
        }

        [HttpGet("get/id={id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return Ok(user);
        }

        [HttpGet("get/email={email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var user = await _userService.GetUserByEmailAsync(email);
            return Ok(user);
        }

        [HttpGet("get/all")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }
    }
}
