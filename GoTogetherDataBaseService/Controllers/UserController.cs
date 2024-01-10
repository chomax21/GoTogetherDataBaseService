﻿using GoTogetherDataBaseService.Data.Models;
using GoTogetherDataBaseService.Services;
using Microsoft.AspNetCore.Mvc;

namespace GoTogetherDataBaseService.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly PersonCreator _creator;

        public UserController(PersonCreator creator)
        {
            _creator = creator;                
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return Ok("Hello");
        }

        [HttpPost]
        [Route("create-user")]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (user != null)
            {
                var responce = await _creator.CreateUserAsync(user);
                
                if (responce)
                    return Ok(user);
                else return BadRequest("Responce get false");
            }
            return BadRequest("Error in CreateMethod");                       
        }
    }
}
