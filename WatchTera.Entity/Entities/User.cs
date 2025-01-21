using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsAdmin { get; set; } // Admin kontrolü için
        public List<Order> Orders { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Wishlist> Wishlists { get; set; }
        public List<Address> Addresses { get; set; }
    }



}
