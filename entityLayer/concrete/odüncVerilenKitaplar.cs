using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class odüncVerilenKitaplar
    {
        [Key]
        public int id { get; set; }

        public int kitapId { get; set; } // Foreign key
        [ForeignKey("kitapId")]
        public kitaplar Kitaps { get; set; }
        public int uyeId { get; set; } // Foreign key
        [ForeignKey("uyeId")]
        public uyeler uyelers { get; set; }
    }
}
