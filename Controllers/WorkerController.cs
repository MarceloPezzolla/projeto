using projeto.Data;
using projeto.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace projeto.Controllers
{
    [Route("v1/worker")]
    public class WorkerController : Controller
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Worker>>> Get([FromServices] DataContext context)
        {
            var workers = await context.Workers.ToListAsync();
            return workers;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Worker>> Post([FromServices] DataContext context, [FromBody] Worker model)
        {
            if (ModelState.IsValid)
            {
                context.Workers.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpGet]
        [Route("getProduct/{id:int}")]
        public async Task<ActionResult<Worker>> FindById([FromServices] DataContext context, int id)
        {
            var worker = await context.Workers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id ==id);
            return worker;
        }
        
    }
}