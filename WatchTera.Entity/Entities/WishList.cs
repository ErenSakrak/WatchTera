using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class Wishlist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // İlişkili kullanıcı
        public List<WishlistItem> WishlistItems { get; set; }
    }

}
