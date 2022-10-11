using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sipariş Yöneyim Sistemi");
            bool sistemdurum = true;
            while (sistemdurum)
            {
                Console.WriteLine("Bir İşlem Seçiniz");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Kategori İşlemleri (1)");
                Console.WriteLine("Ürün İşlemleri     (2)");
                Console.WriteLine("Müşteri İşlemleri  (3)");
                Console.WriteLine("Sipariş İşlemleri  (4)");
                Console.WriteLine("Sitemi Kapat       (x)");
                Console.Write("İşleminiz: ");
                char islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '1':
                        Islemler.Kategori();

                        break;
                    case '2':
                        Islemler.Urun();
                        break;
                    case '3':
                        Islemler.Musteri();
                        break;
                    case '4':
                        Islemler.Siparis();
                        break;
                    case 'x':
                        sistemdurum = false;
                        Console.WriteLine("Sistem Kapatılıyor");
                        break;
                    default:
                        Console.WriteLine("Geçersiz İşlem");
                        break;
                }
                Console.Clear();
            }

        }
    }
}

