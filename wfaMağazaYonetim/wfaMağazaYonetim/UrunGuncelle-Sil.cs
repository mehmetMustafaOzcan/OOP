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
    public partial class UrunGuncelle_Sil : Form
    {
        public UrunGuncelle_Sil()
        {
            InitializeComponent();
        }

        private void UrunGuncelle_Sil_Load(object sender, EventArgs e)
        {
            foreach (var item in Kategoriler.Instance)
            {
                cbKategori.Items.Add(item);
                foreach (var urun in item)
                {
                    lst_Urunler.Items.Add(urun);

                }
            }
        }

        private void lst_Urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUrunAd.Text = ((Urun)lst_Urunler.SelectedItem).Ad.ToString();
           nupFiyat.Value = ((Urun)lst_Urunler.SelectedItem).Fiyat;
            txtTedarikci.Text = ((Urun)lst_Urunler.SelectedItem).Tedarikci.ToString();
            nupStokDurum.Value = ((Urun)lst_Urunler.SelectedItem).StokDurum;
            dtpUretimTAr.Value = ((Urun)lst_Urunler.SelectedItem).UretimTarihi;
            cbKategori.SelectedItem = ((Urun)lst_Urunler.SelectedItem).Kategori;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ((Urun)lst_Urunler.SelectedItem).UrunSet(txtUrunAd.Text, nupFiyat.Value, txtTedarikci.Text, (int)nupStokDurum.Value, dtpUretimTAr.Value, (Kategori)cbKategori.SelectedItem);

        }
    }
}