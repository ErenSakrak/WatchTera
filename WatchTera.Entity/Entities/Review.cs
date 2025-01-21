using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // İlişkili kullanıcı
        public int ProductId { get; set; }
        public Product Product { get; set; } // İlişkili ürün
        public int Rating { get; set; } // Yorum puanı (1-5 arası)
        public string Comment { get; set; } // Yorum metni
        public DateTime ReviewDate { get; set; } // Yorum tarihi
    }


}
