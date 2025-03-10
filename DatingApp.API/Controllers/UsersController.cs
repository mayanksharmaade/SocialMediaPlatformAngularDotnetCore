using DatingApp.API.Data;
using DatingApp.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext dataContext;

        public UsersController( DataContext context)
        {
            this.dataContext = context;
        }
        [HttpGet]
        public  async  Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users =  await dataContext.Users.ToListAsync();

            if (users.Count == 0)
            { return NotFound(users); }
            else
                
                    return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task< ActionResult<IEnumerable<AppUser>> >GetUsers( int id)
        {
            var user =  await dataContext.Users.Where(x=>x.ID==id).FirstAsync();

            if ( user== null)
            { return NotFound(user); }
            else
                return Ok(user);
        }

       
    }
}
