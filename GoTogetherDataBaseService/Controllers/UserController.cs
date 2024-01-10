using GoTogetherDataBaseService.Data.Models;
using GoTogetherDataBaseService.Interfaces;
using GoTogetherDataBaseService.Services;
using Microsoft.AspNetCore.Mvc;

namespace GoTogetherDataBaseService.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPersonCreator<User> _creator;

        public UserController(IPersonCreator<User> creator)
        {
            _creator = creator;
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return Ok("Hello");
        }

        [HttpGet]
        [Route("get-user")]
        public async Task<IActionResult> GetUser(int id)
        {
            var request = await _creator.GetUserAsync(id);
            if(request != null)
            {
                return Ok(request);
            }
            return BadRequest("Error404");
        }

        [HttpPost]
        [Route("create-user")]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (user != null)
            {
                var request = await _creator.CreateUserAsync(user);
                
                if (request)
                    return Ok(user);
                else return BadRequest("Error404");
            }
            return BadRequest("Error in CreateMethod");                       
        }

        [HttpDelete]
        [Route("delete-user")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var request = await _creator.DeleteUserAsync(id);
            if (request)
            {
                return Ok($"User {id} is deleted!");
            }
            return BadRequest($"User {id} not found");
        }

        [HttpPut]
        [Route("update-user")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            var request = await _creator.UpdateUserAsync(user);
            if (request)
            {
                return Ok(user);
            }
            return BadRequest("Error404");
        }
    }
}
