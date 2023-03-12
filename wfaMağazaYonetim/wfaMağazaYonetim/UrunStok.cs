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
    public partial class UrunStok : Form
    {
        public UrunStok()
        {
            InitializeComponent();
        }
        public string Name { get; set; }
        private void UrunStok_Load(object sender, EventArgs e)
        {
            
            foreach (var item in Kategoriler.Instance)
            {
                cbKategori.Items.Add(item);
            }
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_Urunler.Rows.Clear();
            foreach (var item in Kategoriler.Instance)
            {
                if (cbKategori.SelectedItem ==item)
                {
                    foreach (var urun in item)
                    {
                        dgv_Urunler.Rows.Add(urun.UrunID, urun.Ad, urun.StokDurum);
                    }
                }
            }
           
        }
    }
}
