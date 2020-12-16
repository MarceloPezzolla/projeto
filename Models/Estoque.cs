
namespace projeto.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int MinQuantity { get; set; }
    }
}