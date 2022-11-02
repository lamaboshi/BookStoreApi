using BookStoreApi.Data;
using BookStoreApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthor db;
        public AuthorController(IAuthor _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var data = db.GetAuthors();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetAuthor(id);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());

        }


        [HttpPost]
        public IActionResult AddCustomer([FromBody] Author author)
        {
            if (author == null)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(author);
                return Ok();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Author author)
        {
            if (author == null || author.Id == 0)
            {
                //return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(author);
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return Ok();
        }
    }
}
