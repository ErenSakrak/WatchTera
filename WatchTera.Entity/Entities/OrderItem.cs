﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } // İlişkili sipariş
        public int ProductId { get; set; }
        public Product Product { get; set; } // İlişkili ürün
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Ürünün birim fiyatı
        public decimal TotalPrice { get; set; } // Toplam fiyat (Birim fiyat * Miktar)
    }


}
