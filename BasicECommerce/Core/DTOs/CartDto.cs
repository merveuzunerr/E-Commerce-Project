

namespace Core.DTOs
{
    public class CartDto
    {
        public int Number { get; set; }
        public int UserAccountId { get; set; }
        public int ProductId { get; set; }
        public ProductNameDto Product { get; set; }
    }
}
