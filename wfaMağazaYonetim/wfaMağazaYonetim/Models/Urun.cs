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
        public string Tedarikci { get; set; } = "Tedarikçi bilgisi Girilmedi";
        public int StokDurum { get; set; }
        public DateTime UretimTarihi { get; set; } = DateTime.Now;
        private Kategori _kategori;
        private static int _urunID = 100001;

        public int UrunID { get; private set; }


        public Urun()
        {
            UrunID = _urunID++;

        }

        public Kategori Kategori
        {
            get { return _kategori; }
            set { _kategori = value; value.Add(this); }
        }
        public void UrunSet(string ad, decimal fiyat, string tedarikçi, int stokSayısı, DateTime UretimTar, Kategori kategori)
        {
            Ad = ad;
            Fiyat = fiyat;
            Tedarikci = tedarikçi;
            StokDurum = stokSayısı;
            UretimTarihi = UretimTar;
            Kategori = kategori;
        }

        public override string ToString()
        {
            return $"{Ad} ";
        }
    }
}
