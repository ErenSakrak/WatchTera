using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.DTO.DTOs.BannerDtos
{
    public class UpdateBannerDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } // Banner görseli
        public string Link { get; set; } // Tıklanabilir link
        public string AltText { get; set; } // Görsel alt metni
        public DateTime CreatedAt { get; set; } // Banner oluşturulma tarihi
    }
}
