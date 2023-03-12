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
        public int StokDurum { get; set; }
        public DateTime UretimTarihi { get; set; }
        private static int _urunID=100001;

        public int UrunID { get;private set; }


        public Urun()
        {
            UrunID = _urunID++;
            
        }
        private Kategori _kategori;

        public Kategori Kategori
        {
            get { return _kategori; }
            set { _kategori = value; value.Add(this); }
        }

    }
}
