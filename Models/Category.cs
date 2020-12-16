using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projeto.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Name { get; set; }
        public ICollection<Product> Products  { get; set; }
    }
}