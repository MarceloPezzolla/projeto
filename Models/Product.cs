using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace projeto.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        public decimal Price { get; set; }
        public int Estoque { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<Sale> Sale { get; set; }
    }
}