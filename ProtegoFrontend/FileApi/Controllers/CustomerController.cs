using FileApi.DatabaseConnection;
using FileApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CustomerController : Controller
    {
        private readonly MasDbContext DbContext;

        public CustomerController(MasDbContext DbContext)
        {
            this.DbContext = DbContext;
        }


        [Route("Customers")]
        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetCustomers()
        {
            return Ok(await DbContext.Client
                .Include(p => p.Policies)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(b => b.Brand).ToListAsync());
        }

        [Route("Insurance/New")]
        [HttpPost]
        public async Task<ActionResult<int>> AddNewInsurance([FromBody] Policies Policy)
        {
            var Id = await DbContext.Policy2.AddAsync(Policy);
            await DbContext.SaveChangesAsync();
            return Ok(Id);
        }

        [Route("Login/{Login}/{Password}")]
        [HttpGet]
        public async Task<ActionResult<int>> GetUserInfo(string Login, string Password)
        {
            var id = await DbContext.Users.FirstAsync(e => e.Login == Login && e.Password == Password);
            return id.UserId;
        }

        [Route("Client/{ClientId}")]
        [HttpGet]
        public async Task<ActionResult<Client>> GetCustomerData(int ClientId)
        {
            return await DbContext.Client.FirstAsync(e => e.ClientId == ClientId);
        }

    }
}
