using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Enums
{
    public enum PaymentStatus
    {
        Pending = 1,    // "Pending"
        Completed = 2,  // "Completed"
        Failed = 3,     // "Failed"
        Refunded = 4    // "Refunded"
    }
}
