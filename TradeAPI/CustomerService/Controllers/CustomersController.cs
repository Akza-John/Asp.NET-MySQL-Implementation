using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerService.Data;
using CustomerService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerContext _context;

        public CustomersController(CustomerContext context)
        {
            _context = context;
        }

        [HttpGet("count")]
        public async Task<ActionResult<int>> GetCustomerCount()
        {
            return await _context.Customers.CountAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
