using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public List<Siparis> Siparis { get; set; }
    }
}
