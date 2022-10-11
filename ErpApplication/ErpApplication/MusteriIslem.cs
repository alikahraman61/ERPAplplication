using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class MusteriIslem
    {
        public static DataContext db = new DataContext();
        public static void Ekle()
        {
            Console.WriteLine("Müşteri Ekle");
            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();


            Musteri musteri = new Musteri();
            musteri.Ad = ad;
            musteri.Soyad = soyad;
            db.Musteri.Add(musteri);
            db.SaveChanges();

            Console.WriteLine("Müşteri Ekleme Başlarılı");
        }
        public static void Listele()
        {
            var musteri = db.Musteri.ToList();
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine("ID\t\t Ad Soyad");
            foreach (var item in musteri)
            {
                Console.WriteLine(item.Id + "\t" + item.Ad + " " + item.Soyad);
            }
        }
        public static void Sil()
        {
            Console.WriteLine("Müşteri Sil");
            Console.Write("Müşteri Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var musteri = db.Musteri.Find(id);
            db.Musteri.Remove(musteri);
            Console.WriteLine("Müşteri Silme Başarılı");
        }
    }
}

