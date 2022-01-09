using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AuthorApi.Database;
using AuthorApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;

namespace AuthorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController :ControllerBase
    {
        private AuthorDbContext _dbContext;

        public AuthorsController(AuthorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult<Author>> PostAuthor([FromBody] Author author)
        {
            try
            {
               var postAuthor = await _dbContext.Authors.AddAsync(author);
               await _dbContext.SaveChangesAsync();
               return Ok(JsonConvert.SerializeObject(postAuthor.Entity));


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet]
        [Route("/AllAuthors")]
        public async Task<ActionResult<List<Author>>> GetAllAuthors()
        {
            var all = await _dbContext.Authors.Include(a => a.Books).ToListAsync();
            return Ok(JsonConvert.SerializeObject(all));
        }
        
    }
}