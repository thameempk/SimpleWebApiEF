using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User.Models;

namespace User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsers _users;

        public UserController(IUsers users)
        {
            _users = users;
        }

        [HttpGet]

        public ActionResult GetUsers()
        {
            return Ok(_users.GetUsers());
        }

        [HttpPost]

        public ActionResult AddUsers([FromBody] Users user)
        {
            _users.AddUsers(user);
            return Ok();
        }

        //[HttpPut("{id}")]

        //public IActionResult UpdateUser(int id, [FromBody] Users user)
        //{
        //    var userDto = _users.GetUsers().FirstOrDefault(s => s.Id == id);
            
        //    if(userDto == null)
        //    {
        //        return BadRequest();
        //    }

        //    userDto.Name = user.Name;
        //    userDto.Email = user.Email;

        //    return Ok();
        //}
    }
}
