using System;
using System.Collections.Generic;
using WatchTera.Entity.Enums;

namespace WatchTera.Entity.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // İlişkili kullanıcı
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } // Sipariş durumu (Ödeme, Kargo, vb.)
        public List<OrderItem> OrderItems { get; set; } // Siparişteki ürünler
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
    }
}
