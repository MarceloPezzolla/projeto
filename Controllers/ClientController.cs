using projeto.Data;
using projeto.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace projeto.Controllers
{
    [Route("v1/client")]
    public class ClientController : Controller
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Client>>> Get([FromServices] DataContext context)
        {
            var clients = await context.Clients.ToListAsync();
            return clients;
        }
        [HttpGet]
        [Route("getClient/{id:int}")]
        public async Task<ActionResult<Client>> FindById([FromServices] DataContext context, int id)
        {
            var client = await context.Clients
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id ==id);
            return client;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Client>> Post([FromServices] DataContext context, [FromBody] Client model)
        {
            if (ModelState.IsValid)
            {
                context.Clients.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}