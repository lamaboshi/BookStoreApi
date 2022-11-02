using BookStoreApi.Data;
using BookStoreApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer db;
        public CustomerController(ICustomer _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetCustomers()
        {
            var data = db.GetCustomers();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetCustomer(id);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());

        }


        [HttpPost]
        public IActionResult AddCustomer([FromBody] Customer customer)
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
        public IActionResult Put([FromBody] Customer customer)
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
