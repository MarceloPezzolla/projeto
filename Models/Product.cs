using System.ComponentModel.DataAnnotations;

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
        [MaxLength(1024, ErrorMessage = "Este campo deve conter no maximo 1024 caracteres")]
        public string Description { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Inválida")]
        public decimal Price { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Inválida")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Estoque { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Inválida")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}