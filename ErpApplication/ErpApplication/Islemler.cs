using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class Islemler
    {
        public static void Kategori()
        {
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("Kategori İşlemleri Seçiniz");
                Console.WriteLine("Kategori Ekle     (1)");
                Console.WriteLine("Kategori Listele  (2)");
                Console.WriteLine("Kategori Sil      (3)");
                Console.WriteLine("Ana Menü          (4)");
                Console.Write("İşleminiz: ");
                char islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '1':
                        KategoriIslem.Ekle();
                        break;
                    case '2':
                        KategoriIslem.Listele();
                        break;
                    case '3':
                        KategoriIslem.Sil();
                        break;
                    case '4':
                        durum = false;

                        break;
                    default:
                        Console.WriteLine("Geçersiz İşlem");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            }

        }
        public static void Urun()
        {
            bool durum = true;
            while (durum)
            {

                Console.WriteLine("Ürün İşlemleri Seçiniz");
                Console.WriteLine("Ürün Ekle     (1)");
                Console.WriteLine("Ürün Listele  (2)");
                Console.WriteLine("Ürün Sil      (3)");
                Console.Write("İşleminiz: ");
                char islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '1':
                        UrunIslem.Ekle();
                        break;
                    case '2':
                        UrunIslem.Listele();
                        break;
                    case '3':
                        UrunIslem.Sil();
                        break;
                    case '4':
                        durum = false;

                        break;
                    default:
                        Console.WriteLine("Geçersiz İşlem");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            }
        }
        public static void Musteri()
        {
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("Müşteri İşlemleri Seçiniz");
                Console.WriteLine("Müşteri Ekle     (1)");
                Console.WriteLine("Müşteri Listele  (2)");
                Console.WriteLine("Müşteri Sil      (3)");
                Console.Write("İşleminiz: ");
                char islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '1':
                        MusteriIslem.Ekle();
                        break;
                    case '2':
                        MusteriIslem.Listele();
                        break;
                    case '3':
                        MusteriIslem.Sil();
                        break;
                    case '4':
                        durum = false;

                        break;
                    default:
                        Console.WriteLine("Geçersiz İşlem");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            }
        }
        public static void Siparis()
        {
            bool durum = true;
            while (durum)
            {

                Console.WriteLine("Sipariş İşlemleri Seçiniz");
                Console.WriteLine("Sipariş Ekle     (1)");
                Console.WriteLine("Sipariş Listele  (2)");
                Console.WriteLine("Sipariş Sil      (3)");
                Console.Write("İşleminiz: ");
                char islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '1':
                        SiparisIslem.Ekle();
                        break;
                    case '2':
                        SiparisIslem.Listele();
                        break;
                    case '3':
                        SiparisIslem.Sil();
                        break;
                    case '4':
                        durum = false;

                        break;
                    default:
                        Console.WriteLine("Geçersiz İşlem");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            }
        }

    }
}
