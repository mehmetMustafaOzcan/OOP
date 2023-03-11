using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMağazaYonetim.Models
{
    internal class Kategoriler:ICollection<Urun>
    {
        private ICollection<Urun> Kategori { get; set; }
        public static Kategoriler Instance { get; set; }
        private Kategoriler()
        {
            Kategori = new List<Urun>();
        }
        public string Ad { get; set; }


        public int Count => Kategori.Count();

        public bool IsReadOnly => Kategori.IsReadOnly;

        public void Add(Urun item)
        {
            Kategori.Add(item);
        }

        public void Clear()
        {
            Kategori.Clear();
        }

        public bool Contains(Urun item)
        {
            return Kategori.Contains(item);
        }

        public void CopyTo(Urun[] array, int arrayIndex)
        {
            Kategori.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Urun> GetEnumerator()
        {
            return Kategori.GetEnumerator();
        }

        public bool Remove(Urun item)
        {
            return Kategori.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
