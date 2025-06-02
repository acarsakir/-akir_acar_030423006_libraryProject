using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class uyeler
    {
        [Key]
        public int id { get; set; }
        [StringLength(15)]
        public string ad { get; set; }
        [StringLength(15)]
        public string soyad { get; set; }
        [StringLength(11)]
        public string telefon { get; set; }
        public ICollection<odüncVerilenKitaplar> OduncKitaplar { get; set; }

    }
}
