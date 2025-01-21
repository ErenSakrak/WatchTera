using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Phone { get; set; } // Telefon numarası
        public string Email { get; set; } // İletişim e-posta
        public string Address { get; set; } // Adres
        public string SocialMediaLinks { get; set; } // Sosyal medya bağlantıları
    }

}
