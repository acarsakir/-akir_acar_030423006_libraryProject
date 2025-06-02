using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class kitaplar
    {
        [Key]
        public int id { get; set; }
        [StringLength(15)]
        public string kitapAdi { get; set; }
        [StringLength(25)]
        public string yazar { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public ICollection<odüncVerilenKitaplar> odüncVerilenKitaplars { get; set; }
    }
}
