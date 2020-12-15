using projeto.Data;
using projeto.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
//using projeto.Service;

namespace projeto.Controllers
{
    [Route("v1/suppliers")]
    public class SupplierController : Controller
    {
        /*private readonly IProductService service;
        public SupplierController(IProductService service)
        {
            this.service = service;
        }*/

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Supplier>>> Get([FromServices] DataContext context)
        {
            var suppliers = await context.Suppliers.ToListAsync();
            return suppliers;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<Supplier>> Post([FromServices] DataContext context, [FromBody] Supplier model)
        {
            if (ModelState.IsValid)
            {
                context.Suppliers.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpGet]
        [Route("getSupplier/{id:int}")]
        public async Task<ActionResult<Supplier>> FindById([FromServices] DataContext context, int id)
        {
            var supplier = await context.Suppliers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id ==id);
            return supplier;
        }
        
    }
}