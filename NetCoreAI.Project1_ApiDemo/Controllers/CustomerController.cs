using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreAI.Project1_ApiDemo.Context;
using NetCoreAI.Project1_ApiDemo.Entities;

namespace NetCoreAI.Project1_ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private NetCoreContext _context;

        public CustomerController(NetCoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CustomerList()
        {
            var values = _context.Customers.ToList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Ok("Müşteri Eklendi ");
                
        }
        [HttpDelete]
        public IActionResult DeleteCustomer(int id)
        {
            var values =_context.Customers.Find(id);
            _context.Customers.Remove(values);
            _context.SaveChanges();
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return Ok("müsteri eklendi");
            
        }
    }
}
    