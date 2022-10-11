using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class Siparis
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }
        public int Adet { get; set; }
    }
}
