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
    public partial class Form1 : Form
    {
        public Form1()
        {
                InitializeComponent();
        }

        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            UrunKontrol urunKontrol = new UrunKontrol();
            urunKontrol.ShowDialog();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Kategori Gıda = new Kategori();
            Gıda.Ad = "Gıda";
            Kategori Bebek = new Kategori();
            Bebek.Ad = "Bebek";
            Kategori Kıyafet = new Kategori();
            Kıyafet.Ad = "Kıyafet";
           
            Urun Ekmek = new Urun();
            Ekmek.Ad = "Ekmek";
            Ekmek.Kategori = Gıda;          
            Ekmek.Fiyat = 5;
            Ekmek.StokDurum = 50;

            Urun Etek = new Urun();
            Etek.Ad = "İthal Etek";
            Etek.Fiyat = 100;
            Etek.Kategori = Kıyafet;
            Etek.StokDurum = 10;

            Urun BebekBezi = new Urun();
            BebekBezi.Ad = "Baby Turco 6";
            BebekBezi.Fiyat = 150;
            BebekBezi.Kategori = Bebek;
            BebekBezi.StokDurum = 10;
           


        }
    }
}
