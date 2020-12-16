using System.ComponentModel.DataAnnotations;

namespace projeto.Models
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Cargo { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Phone { get; set; }
    }
}