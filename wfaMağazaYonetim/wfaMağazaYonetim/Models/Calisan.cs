using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaMağazaYonetim.Models;

namespace wfaMağazaYonetim
{
    abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        private static int ID { get; set; }
        public Calisan()
        {
            
            ID++;
        }
    }
}
