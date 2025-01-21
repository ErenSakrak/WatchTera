using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class AdminLog
    {
        public int Id { get; set; }
        public int AdminUserId { get; set; }
        public User AdminUser { get; set; } // Admin kullanıcı
        public string Action { get; set; } // Örneğin: "Ürün Ekleme"
        public DateTime ActionTime { get; set; } // İşlem zamanı
        public string Description { get; set; } // İşlem açıklaması
    }


}
