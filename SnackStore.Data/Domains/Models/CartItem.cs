using System.ComponentModel.DataAnnotations.Schema;

namespace SnackStore.Data.Domains.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Items MenuItem { get; set; } = new();
        public int Quantity { get; set; }
        public int ShoppingCartId { get; set; }
    }
}
