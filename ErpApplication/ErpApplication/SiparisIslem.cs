using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class SiparisIslem
    {
        public static DataContext db = new DataContext();
        public static void Ekle()
        {
            Console.WriteLine("Sipariş Oluştur");
            Console.Write("Müşteri Id: ");
            int musteriId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürün Id: ");
            int urunId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürün Adet: ");
            int adet = Convert.ToInt32(Console.ReadLine());


            Siparis siparis = new Siparis();
            siparis.MusteriId = musteriId;
            siparis.UrunId = urunId;
            siparis.Adet = adet;
            db.Siparis.Add(siparis);
            db.SaveChanges();

            Console.WriteLine("Sipariş Oluşturma Başlarılı");
        }
        public static void Listele()
        {
            SiparisModel model = new SiparisModel();
            model.Siparisler = db.Siparis.ToList();
            model.Musteriler = db.Musteri.ToList();
            model.Urunler = db.Urun.ToList();
            Console.WriteLine("Sipariş Listesi");
            foreach (var item in model.Siparisler)
            {
                Console.WriteLine(item.Id + " \t" + item.Musteri.Ad + "\t " + item.Musteri.Soyad + " \t" + item.Adet + " Adet" + "\tToplam Tutar: " + (item.Adet * item.Urun.Fiyat));
            }
        }
        public static void Sil()
        {
            Console.WriteLine("Sipariş Sil");
            Console.Write("Sipariş Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var siparis = db.Siparis.Find(id);
            db.Siparis.Remove(siparis);
            Console.WriteLine("Sipariş Silme Başarılı");
        }
    }
}

