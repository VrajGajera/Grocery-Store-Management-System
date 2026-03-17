using System.ComponentModel.DataAnnotations;

namespace Grosary_net.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; } 

        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public decimal Subtotal => Price * Quantity;
    }
}
