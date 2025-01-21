using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTera.Entity.Entities
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Platform { get; set; }  // Örneğin: Facebook, Twitter, Instagram vb.
        public string Link { get; set; }
    }
}
