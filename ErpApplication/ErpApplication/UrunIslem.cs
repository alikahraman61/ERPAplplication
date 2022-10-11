using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class UrunIslem
    {
        public static DataContext db = new DataContext();
        public static void Ekle()
        {
            Console.WriteLine("Ürün Ekle");
            Console.Write("Ürün Adı: ");
            string urunAdi = Console.ReadLine();

            Console.Write("Ürün Fiyatı: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kategori Id: ");
            int kategoriId = Convert.ToInt32(Console.ReadLine());
            Urun urun = new Urun();
            urun.UrunAdi = urunAdi;
            urun.Fiyat = fiyat;
            urun.KategoriId = kategoriId;
            db.Urun.Add(urun);
            db.SaveChanges();

            Console.WriteLine("Ürün Ekleme Başlarılı");
        }
        public static void Listele()
        {
            var urun = db.Urun.ToList();
            Console.WriteLine("Ürün Listesi");
            Console.WriteLine("ID\t\tÜrün Adi\t\tKategori Id\t\tFiyat");
            foreach (var item in urun)
            {
                Console.WriteLine(item.Id + "\t" + item.UrunAdi + "\t\t" + item.KategoriId + "\t\t" + item.Fiyat);
            }
        }
        public static void Sil()
        {
            Console.WriteLine("Ürün Sil");
            Console.Write("Ürün Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var urun = db.Urun.Find(id);
            db.Urun.Remove(urun);
            Console.WriteLine("Ürün Silme Başarılı");
        }
    }
}

