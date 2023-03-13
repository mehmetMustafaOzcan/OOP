using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaMağazaYonetim.Models;

namespace wfaMağazaYonetim
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Ad = txtUrunAd.Text;
            urun.Fiyat = nupFiyat.Value;
            urun.StokDurum = Convert.ToInt32(nupStokDurum.Value);
            urun.UretimTarihi = dtpUretimTAr.Value;
            urun.Kategori = (Kategori)cbKategori.SelectedItem;
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            foreach (var item in Kategoriler.Instance)
            {
                cbKategori.Items.Add(item);
            }
        }
    }
}
