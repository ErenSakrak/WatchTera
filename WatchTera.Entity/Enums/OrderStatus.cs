using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Enums
{
    public enum OrderStatus
    {
        Pending = 1,    // Sipariş beklemede
        Shipped = 2,    // Kargoya verilmiş
        Delivered = 3,  // Teslim edilmiş
        Canceled = 4    // İptal edilmiş
    }
}

