using projeto.Data;
using projeto.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace projeto.Controllers
{
    [Route("v1/products")]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get([FromServices] DataContext context)
        {
            var products = await context.Products.ToListAsync();
            return products;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Product>> Post([FromServices] DataContext context, [FromBody] Product model)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPut]
        [Route("updateProduct/{id:int}")]
        public async Task<ActionResult<Product>> Update(int id, [FromServices] DataContext context, [FromBody]Product model)
        {
            if (ModelState.IsValid)
            {
                var productToUpdate = await context.Products.FirstOrDefaultAsync(x => x.Id == id);
                productToUpdate.Name = model.Name;
                productToUpdate.Price = model.Price;
                productToUpdate.Supplier = model.Supplier;
                Supplier supplier = await context.Suppliers.SingleAsync(a => a.Id == model.SupplierId);
                productToUpdate.Supplier = supplier;

                productToUpdate.Supplier = supplier;


                return productToUpdate;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Product>> FindById([FromServices] DataContext context, int id)
        {
            var product = await context.Products.Include(x => x.Category)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id ==id);
            return product;
        }
        [HttpGet]
        [Route("categories/{id:int}")]
        public async Task<ActionResult<List<Product>>> GetByCategory([FromServices] DataContext context, int id)
        {
            var product = await context.Products
                .Include(x => x.Category)
                .AsNoTracking()
                .Where(x => x.CategoryId == id)
                .ToListAsync();
            return product;
        }
        
    }
}