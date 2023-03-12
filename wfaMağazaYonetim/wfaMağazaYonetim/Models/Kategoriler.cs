using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMağazaYonetim.Models
{
    internal class Kategoriler : ICollection<Kategori>
    {
        private ICollection<Kategori> Kategori { get; set; }

        private Kategoriler()
        {
            Kategori = new List<Kategori>();
        }
        private static Kategoriler _instance;

        public static Kategoriler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Kategoriler();
                }
                return _instance;
            }
        }

        public string Ad { get; set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Kategori item)
        {
            Kategori.Add(item);
        }

        public void Clear()
        {
            Kategori.Clear();
        }

        public bool Contains(Kategori item)
        {
            return Kategori.Contains(item);
        }

        public void CopyTo(Kategori[] array, int arrayIndex)
        {
            Kategori.CopyTo(array, arrayIndex);
        }

        public bool Remove(Kategori item)
        {
            return Kategori.Remove(item);
        }

        public IEnumerator<Kategori> GetEnumerator()
        {
           return Kategori.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
       
    }
}
