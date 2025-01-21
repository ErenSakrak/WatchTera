using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; } // İlişkili sepet
        public int ProductId { get; set; }
        public Product Product { get; set; } // İlişkili ürün
        public int Quantity { get; set; } // Ürün adedi
        public decimal TotalPrice { get; set; } // Toplam fiyat
    }


}
