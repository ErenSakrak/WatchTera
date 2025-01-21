using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchTera.Entity.Entities;

namespace WatchTera.Entity.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public string Method { get; set; }  // PaymentMethod enum'undan string olarak saklanacak değer
        public decimal Amount { get; set; }
        public string Status { get; set; }  // PaymentStatus enum'undan string olarak saklanacak değer

        public DateTime PaymentDate { get; set; }
        public string TransactionId { get; set; }
    }
}
