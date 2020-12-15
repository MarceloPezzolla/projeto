using projeto.Models;
using System.Collections.Generic;
using System.Linq;
/*
namespace projeto.Service
{
    public class ProductService : IProductService
    {
        private readonly List<Product> products;
        public void AddProduct(Product item)
        {
            this.products.Add(item);
        }
        public void DeleteProduct(int id)
        {
            var model = this.products.Where(m => m.Id ==id).FirstOrDefault();
            this.products.Remove(model);
        }
        public bool ProductExists(int id)
        {
            return this.products.Any(m => m.Id == id);
        }
        public Product GetProduct(int id)
        {
            return this.products.Where(m => m.Id == id).FirstOrDefault();
        }
        public List<Product> GetProducts()
        {
            return this.products.ToList();
        }
        public void UpdateProduct(Product item)
        {
            var model = this.products.Where(m => m.Id == item.Id).FirstOrDefault();
            model.Title = item.Title;
            model.Description = item.Description;
            model.Price = item.Price;
        }
        
    }
}*/ 