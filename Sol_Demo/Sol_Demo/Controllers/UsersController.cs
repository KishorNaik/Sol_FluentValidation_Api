using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Models;

namespace Sol_Demo.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost("adduser")]
        public IActionResult AddUser([FromBody] UsersModel usersModel)
        {
            // Rest of Code

            return Ok((Object)usersModel);
        }
    }
}