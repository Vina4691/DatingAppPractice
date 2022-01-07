using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
       private DataContext _context;
        public UsersController(DataContext context )
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<AppUser>> Get()
        {
          return  await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<AppUser> Get(int id)
        {
            return await _context.Users.FindAsync(id);
        }



    }
}
