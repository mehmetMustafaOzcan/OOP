using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMağazaYonetim.Models
{
    public class Kategori : ICollection<Urun>
   {
        public string Ad { get; set; }
        public int KategoriID { get; }
        private ICollection<Urun> Uruns { get; set; }
        public Kategori()
        {
            Uruns = new List<Urun>();
            KategoriID++;
        }
        public int Count => Uruns.Count();

        public bool IsReadOnly => Uruns.IsReadOnly;

        public void Add(Urun item)
        {
            Uruns.Add(item);
        }

        public void Clear()
        {
            Uruns.Clear();
        }

        public bool Contains(Urun item)
        {
            return Uruns.Contains(item);
        }

        public void CopyTo(Urun[] array, int arrayIndex)
        {
            Uruns.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Urun> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Urun item)
        {
           return Uruns.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
