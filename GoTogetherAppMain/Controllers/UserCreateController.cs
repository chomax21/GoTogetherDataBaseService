using Go;
using Microsoft.AspNetCore.Mvc;
using Grpc.Net.Client;
using GoTogetherAppMain.Models;
using GoTogetherAppMain.Services;

namespace GoTogetherAppMain.Controllers
{
    [ApiController]
    public class UserCreateController : Controller
    {
        private readonly UserCreatorService _userCreator;

        public UserCreateController(UserCreatorService userCreator)
        {
            _userCreator = userCreator; 
        }

        [HttpPost]
        [Route("user-create")]
        public async Task<IActionResult> UserCreateAsync(UserViewModel viewModel)
        {                              
                var responce = await _userCreator.CreateUserAsync(viewModel);
                if (responce != null && responce.Done)
                {
                    return Ok($"User {responce.Name} created!");
                }
                return BadRequest("ErrorUserCreated");
        }
    }
}
