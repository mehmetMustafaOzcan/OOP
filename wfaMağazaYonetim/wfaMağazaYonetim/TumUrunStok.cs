﻿using System;
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
    public partial class TumUrunStok : Form
    {
        public TumUrunStok()
        {
            InitializeComponent();
        }

        private void TumUrunStok_Load(object sender, EventArgs e)
        {           
            foreach (var item in Kategoriler.Instance)
            {
                foreach (var urun in item)
                {
                    TumUrunler.Rows.Add(item.Ad, urun.Ad, urun.UrunID,urun.StokDurum);
                }
            }
            
                    

        }

        
    }
}
