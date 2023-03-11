using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMağazaYonetim.Models
{
    public class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public string Tedarikci { get; set; }
        public DateTime UretimTarihi { get; set; }
        
        private Kategori _kategori;

        public Kategori Kategori
        {
            get { return _kategori; }
            set { _kategori = value; value.Add(this); }
        }

    }
}
