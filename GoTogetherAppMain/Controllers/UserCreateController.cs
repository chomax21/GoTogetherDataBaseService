using Go;
using GoTogetherAppMain.Models;
using GoTogetherAppMain.Services;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> UserCreate(UserViewModel userView)
        {         
            GoRequest request = new();
            request.Age = userView.Age;
            request.Name = userView.Name;
            request.Email = userView.Email;
            var responce =  await _userCreator.UserCreate(request);
            if (responce.Done) 
            {
                return Ok($"User {userView.Name} created!");
            }
            return BadRequest("ErrorUserCreated");
        }
    }
}
