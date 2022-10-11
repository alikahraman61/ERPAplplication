using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class KategoriIslem
    {
        public static DataContext db = new DataContext();
        public static void Ekle()
        {

            Console.WriteLine("Kategori Ekle");
            Console.Write("Kategori Adı: ");
            string kategoriAdi = Console.ReadLine();
            Kategori kategori = new Kategori();
            kategori.KategoriAdi = kategoriAdi;
            db.Kategori.Add(kategori);
            db.SaveChanges();
            Console.WriteLine("Kategori Ekleme Başlarılı");
        }
        public static void Listele()
        {
            var kategori = db.Kategori.ToList();
            Console.WriteLine("Kategori Listesi");
            Console.WriteLine("ID\t\tKategori Adi");
            foreach (var item in kategori)
            {
                Console.WriteLine(item.Id + "\t" + item.KategoriAdi);
            }
        }
        public static void Sil()
        {
            Console.WriteLine("Kategori Sil");
            Console.Write("Kategori Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var kategori = db.Kategori.Find(id);
            db.Kategori.Remove(kategori);
            db.SaveChanges();
            Console.WriteLine("Kategori Silme Başarılı");
        }
    }
}

