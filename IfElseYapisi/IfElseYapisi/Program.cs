using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ifelseyapisi
            //string isim = "Meltem";
            //if (isim=="Meltem") 
            //{
            //    Console.WriteLine("Doğru İsim"); 
            //}
            //else
            //{
            //    Console.WriteLine("Doğru İsim Değil");
            //}

            //int sayi = 5;
            //if (sayi == 5)
            //{
            //    Console.WriteLine("Doğru Sayı");
            //}
            //else
            //{
            //    Console.WriteLine("Doğru Sayı Değil");
            //}

            // Console.Read();

            //Console.WriteLine("Lütfen Pozitif Sayı Olup Olmadığını Öğrenmek İstediğniz Sayıyı Giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı Pozitif");
            //}
            //else
            //{
            //    Console.WriteLine("sayı negatif");
            //}

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Pozitiftir");
            //}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("0 Nötr Bi Sayıdır");
            // }
            //else 
            //{
            //    Console.WriteLine("Girdiğniz Sayı Negatiftir");
            //}
            //konsoldan 1. sınav notunu 2. sınav notunu alın ortalamasını bulun ortalama 35 den küçükse BERBAT 35 - 50 arasındaysa VASAT 50-75 arasındaysa İDARE EDER 75-90 arasındaysa ÇOK İYİ 90-100 arasındaysa MÜKEMMEL
            #endregion

            #region AED 
            // Console.WriteLine("Lütfen Birinci Notu Giriniz");
            // int sayi1 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Lütfen İkinci Notu Giriniz");
            // int sayi2 = Convert.ToInt32(Console.ReadLine());

            // int ortalama = (sayi1 + sayi2) / 2;

            // if (ortalama  < 35)
            // {
            //     Console.WriteLine("BERBAT" );
            // }
            //else if (ortalama < 50)
            // {
            //     Console.WriteLine("VASAT");
            // }
            // else if (ortalama < 75)
            // {
            //     Console.WriteLine("İDARE EDER");

            // }
            // else if (ortalama < 90)
            // {
            //     Console.WriteLine("ÇOK İYİ");
            // }
            // else
            // {
            //     Console.WriteLine("MÜKEMMEL");
            // }

            // Console.WriteLine($"Ortalamanız: {ortalama}");

            //DÖNEM SONU NOTU

            //Console.WriteLine("Lütfen Birinci Notu Giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen İkinci Notu Giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int ortalama = (sayi1%40 + sayi2%60) ;

            //if (ortalama < 35)
            //{
            //    Console.WriteLine("BERBAT");
            //}
            //else if (ortalama < 50)
            //{
            //    Console.WriteLine("VASAT");
            //}
            //else if (ortalama < 75)
            //{
            //    Console.WriteLine("İDARE EDER");

            //}
            //else if (ortalama < 90)
            //{
            //    Console.WriteLine("ÇOK İYİ");
            //}
            //else
            //{
            //    Console.WriteLine("MÜKEMMEL");
            //}

            //Console.WriteLine($"Ortalamanız: {ortalama}");

            //plakaya göre il
            //Console.WriteLine("Girmek İstediğiniz plaka kodunu Giriniz");
            //int plaka = Convert.ToInt32(Console.ReadLine());

            //if (plaka == 01)
            //{
            //    Console.WriteLine("Bu plaka kodu Adana ilinindir");
            //}
            //else if (plaka == 06)
            //{
            //    Console.WriteLine("Bu plaka kodu Ankara ilinindir");
            //}
            //else if (plaka == 34)
            //{
            //    Console.WriteLine("Bu plaka kodu İstanbul ilinindir");
            //}
            //else
            //{
            //    Console.WriteLine("Bu plaka kodu farklı ilindir");
            //}

            #endregion

            #region hoca
            //konsoldan 1. sınav notunu 2. sınav notunu alın ortalamasını bulun ortalama 35 den küçükse BERBAT 35 - 50 arasındaysa VASAT 50-75 arasındaysa İDARE EDER 75-90 arasındaysa ÇOK İYİ 90-100 arasındaysa MÜKEMMEL

            //Console.WriteLine("Lütfen Birinci Notu Giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen İkinci Notu Giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //double ortalama = (sayi1 + sayi2) / 2;

            //if (ortalama < 35)
            //{
            //    Console.WriteLine("Berbat");
            //}
            //else if (ortalama >= 35 && ortalama < 50)
            //{
            //    Console.WriteLine("Vasat");
            //}
            //else if (ortalama >= 50 && ortalama < 75)
            //{
            //    Console.WriteLine("İdare Eder");
            //}
            //else if (ortalama >= 75 && ortalama < 90)
            //{
            //    Console.WriteLine("Çok İyi");
            //}
            //else
            //{
            //    Console.WriteLine("Mükemmel");
            //}

            //dönem sonu 

            //Console.WriteLine("Lütfen Birinci Notu Giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen İkinci Notu Giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //double donemsonu = (sayi1*0.4 + sayi2*0.6);

            //if (donemsonu < 35)
            //{
            //    Console.WriteLine("Berbat");
            //}
            //else if (donemsonu >= 35 && donemsonu < 50)
            //{
            //    Console.WriteLine("Vasat");
            //}
            //else if (donemsonu >= 50 && donemsonu < 75)
            //{
            //    Console.WriteLine("İdare Eder");
            //}
            //else if (donemsonu >= 75 && donemsonu < 90)
            //{
            //    Console.WriteLine("Çok İyi");
            //}
            //else
            //{
            //    Console.WriteLine("Mükemmel");
            //}
            //

            //ankara adana istanbul için plaka kodu bu desin (ile göre plaka)


            Console.WriteLine("Girmek İstediğiniz İli Giriniz");
            string il = (Console.ReadLine());

            if (il == "Adana")
            {
                Console.WriteLine("Bu plaka kodu 01'dir");
            }
            else if (il == "Ankara")
            {
                Console.WriteLine("Bu plaka kodu 06'dır");
            }
            else if (il == "İstanbul")
            {
                Console.WriteLine("Bu plaka kodu 34'dür");
            }
            else if (il == "Eskişehir")
            {
                Console.WriteLine("Bu plaka kodu 26'dır");
            }
            else
            {
                Console.WriteLine("Bu plaka kodu farklı ilindir");
            }

            #endregion

            #region deneme




            #endregion
        }
    }
}
