using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projeto.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        public string Brand { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        public string Phone { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}