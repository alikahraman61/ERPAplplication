using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public List<Urun> Urun { get; set; }
    }
}
