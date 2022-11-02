using BookStoreApi.Data;
using BookStoreApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerBookController : ControllerBase
    {
        
        private readonly ICustomerBook db;
        public CustomerBookController(ICustomerBook _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetCustomersBook()
        {
            var data = db.GetCustomerBooks();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetCustomerBook(id);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerBook customer)
        {
            if (customer == null)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(customer);
                return Ok();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] CustomerBook customer)
        {
            if (customer == null || customer.Id == 0)
            {
                //return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(customer);
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
