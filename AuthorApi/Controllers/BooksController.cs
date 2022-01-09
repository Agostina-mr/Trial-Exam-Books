using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using AuthorApi.Database;
using AuthorApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AuthorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private AuthorDbContext _dbContext;

        public BooksController(AuthorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var all = await _dbContext.Books.ToListAsync();
            return Ok(JsonConvert.SerializeObject(all));
        }

        [HttpPost]
        [Route("{authorId:int}")]
        public async Task<ActionResult<Book>> PostBook([FromRoute] int authorId, [FromBody] Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var authorToUpdate = await _dbContext.Authors.Include(a => a.Books).FirstAsync(a => a.Id == authorId);
                authorToUpdate.Books.Add(book);
                _dbContext.Update(authorToUpdate);
                await _dbContext.SaveChangesAsync();
                return Ok(book);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{bookId:int}")]
        public async Task<ActionResult> DeleteBook([FromRoute] int bookId)
        {
            try
            {
                var bookToDelete = await _dbContext.Books.FirstOrDefaultAsync(b => b.ISBN == bookId);
                Console.WriteLine();

                if (bookToDelete != null)
                {
                    _dbContext.Remove(bookToDelete);
                    await _dbContext.SaveChangesAsync();
                    return Ok();
                }
                else
                {
                    return StatusCode(400);
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}