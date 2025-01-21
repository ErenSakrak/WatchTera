using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class AdminRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; } // Örneğin: "Super Admin", "Product Manager"
        public List<User> Users { get; set; } // Bu rolü taşıyan admin kullanıcıları
    }


}
