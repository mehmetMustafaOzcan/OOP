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
    public partial class UrunKontrol : Form
    {
        public UrunKontrol()
        {
            InitializeComponent();
        }
        UrunStok urun_Stok = new UrunStok();
        public void UrunKontrol_Load(object sender, EventArgs e)
        {
            foreach (var item in Kategoriler.Instance)
            {
                ToolStripMenuItem kategori1 = new ToolStripMenuItem(item.Ad);
              
                kategorilerToolStripMenuItem.DropDownItems.Add(kategori1);
               
                kategori1.Click += Kategori1_Click;                    
            }
        }

        public void Kategori1_Click(object sender, EventArgs e)
        {
            urun_Stok.MdiParent = this;
            urun_Stok.Show();
        }

        private void tümÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumUrunStok urunStok = new TumUrunStok();
            urunStok.MdiParent = this;
            urunStok.Show();
            
        }

      
    }
}
