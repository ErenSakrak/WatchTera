using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // İlişkili kullanıcı
        public string Street { get; set; } // Sokak
        public string City { get; set; } // Şehir
        public string ZipCode { get; set; } // Posta kodu
        public string Country { get; set; } // Ülke
    }

}
