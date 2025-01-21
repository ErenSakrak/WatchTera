using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class WishlistItem
    {
        public int Id { get; set; }
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; } // İlişkili favori liste
        public int ProductId { get; set; }
        public Product Product { get; set; } // İlişkili ürün
    }

}
