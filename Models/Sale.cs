using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace projeto.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public string SaleType { get; set; }
        public int ProductId {get; set;}
        public Product Product { get; set; }
    }
}