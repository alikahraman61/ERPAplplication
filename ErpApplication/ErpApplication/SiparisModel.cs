using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class SiparisModel
    {
        public List<Siparis> Siparisler { get; set; }
        public Siparis Siparis { get; set; }
        public List<Musteri> Musteriler { get; set; }
        public Musteri Musteri { get; set; }
        public List<Urun> Urunler { get; set; }
        public Urun Urun { get; set; }
    }
}
