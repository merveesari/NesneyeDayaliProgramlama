/****************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2018-2019 BAHAR DÖNEMİ
**	
**				    ÖDEV NUMARASI..........:2
**				    ÖĞRENCİ ADI............:Merve Sarı
**				    ÖĞRENCİ NUMARASI.......:B181210074
**                  DERSİN ALINDIĞI GRUP...:1C
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        class Futbolcu
        {
            public string adSoyad;
            public int formaNo;
            public int hiz;
            public int dayaniklilik;
            public int pas;
            public int sut;
            public int yetenek;
            public int kararlilik;
            public int dogalForm;
            public int sans;
            public double pasSkor;
            public double golSkor;

            public Futbolcu()
            {
                Random rastgele = new Random();

                hiz = rastgele.Next(50, 100);
                dayaniklilik = rastgele.Next(50, 100);
                pas = rastgele.Next(50, 100);
                sut = rastgele.Next(50, 100);
                yetenek = rastgele.Next(50, 100);
                kararlilik = rastgele.Next(50, 100);
                dogalForm = rastgele.Next(50, 100);
                sans = rastgele.Next(50, 100);
            }

            public Futbolcu(string AdSoyad, int FormaNo)
            {
                adSoyad = AdSoyad;
                formaNo = FormaNo;
            }

            public bool PasVer()
            {
                pasSkor = pas * 0.3 + yetenek * 0.3 + dayaniklilik * 0.1 + dogalForm * 0.1 + sans * 0.2;
                if (Convert.ToInt32(pasSkor) > 60) //Pas skoru 60'tan büyükse doğru değilse yanlış döndürür
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool GolVurusu()
            {
                golSkor = yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + hiz * 0.1 + sans * 0.2;
                if (Convert.ToInt32(golSkor) > 70) //Gol skoru 70'ten büyükse doğru değilse yanlış döndürür
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        class Defans : Futbolcu
        {
            public int pozisyonAlma;
            public int kafa;
            public int sicrama;

            public Defans()
            {
                Random rastgele = new Random();

                pozisyonAlma = rastgele.Next(50, 90);
                kafa = rastgele.Next(50, 90);
                sicrama = rastgele.Next(50, 90);

                if (hiz < 50 || hiz > 90) //Temel sınıfın kurucu fonksiyonda atanan hız değeri 50-90 arasında değilse 50-90 arasından değer atama
                {
                    hiz = rastgele.Next(50, 90);
                }
                if (dayaniklilik < 50 || dayaniklilik > 90) //Temel sınıfın kurucu fonksiyonda atanan dayaniklilik değeri 50-90 arasında değilse 50-90 arasından değer atama
                {
                    dayaniklilik = rastgele.Next(50, 90);
                }
                if (pas < 50 || pas > 90) //Temel sınıfın kurucu fonksiyonda atanan pas değeri 50-90 arasında değilse 50-90 arasından değer atama
                {
                    pas = rastgele.Next(50, 90);
                }
                if (sut < 50 || sut > 90) //Temel sınıfın kurucu fonksiyonda atanan sut değeri 50-90 arasında değilse 50-90 arasından değer atama
                {
                    sut = rastgele.Next(50, 90);
                }
                if (yetenek < 50 || yetenek > 90) //Temel sınıfın kurucu fonksiyonda atanan yetenek değeri 50-90 arasında değilse 50-90 arasından değer atama
                {
                    yetenek = rastgele.Next(50, 90);
                }
                if (kararlilik < 50 || kararlilik > 90) //Temel sınıfın kurucu fonksiyonda atanan kararlilik değeri 50-90 arasında değilse 50-90 arasından değer atama
                {
                    kararlilik = rastgele.Next(50, 90);
                }
                if (dogalForm < 50 || dogalForm > 90) //Temel sınıfın kurucu fonksiyonda atanan dogalForm değeri 50-90 arasında değilse 50-90 arasından değer atama
                {
                    dogalForm = rastgele.Next(50, 90);
                }
                if (sans < 50 || sans > 90) //Temel sınıfın kurucu fonksiyonda atanan sans değeri 50-90 arasında değilse 50-90 arasından değer atama
                {
                    sans = rastgele.Next(50, 90);
                }
            }

            public Defans(string AdSoyad, int FormaNo)
            {
                adSoyad = AdSoyad;
                formaNo = FormaNo;
            }

            public bool PasVer()
            {
                pasSkor = pas * 0.3 + yetenek * 0.3 + dayaniklilik * 0.1 + dogalForm * 0.1 + pozisyonAlma * 0.1 + sans * 0.2;
                if (Convert.ToInt32(pasSkor) > 60) //Pas skoru 60'tan büyükse doğru değilse yanlış döndürür
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool GolVurusu()
            {
                golSkor = yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + kafa * 0.1 + sicrama * 0.1 + sans * 0.1;
                if (Convert.ToInt32(golSkor) > 70) //Gol skoru 70'ten büyükse doğru değilse yanlış döndürür
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        class OrtaSaha : Futbolcu
        {
            public int uzunTop;
            public int ilkDokunus;
            public int uretkenlik;
            public int topSurme;
            public int ozelYetenek;

            public OrtaSaha()
            {
                Random rastgele = new Random();

                uzunTop = rastgele.Next(60, 100);
                ilkDokunus = rastgele.Next(60, 100);
                uretkenlik = rastgele.Next(60, 100);
                topSurme = rastgele.Next(60, 100);
                ozelYetenek = rastgele.Next(60, 100);

                if (hiz < 60 || hiz > 100) //Temel sınıfın kurucu fonksiyonda atanan hız değeri 60-100 arasında değilse 60-100 arasından değer atama
                {
                    hiz = rastgele.Next(60, 100);
                }
                if (dayaniklilik < 60 || dayaniklilik > 100) //Temel sınıfın kurucu fonksiyonda atanan dayaniklilik değeri 60-100 arasında değilse 60-100 arasından değer atama
                {
                    dayaniklilik = rastgele.Next(60, 100);
                }
                if (pas < 60 || pas > 100) //Temel sınıfın kurucu fonksiyonda atanan pas değeri 60-100 arasında değilse 60-100 arasından değer atama
                {
                    pas = rastgele.Next(60, 100);
                }
                if (sut < 60 || sut > 100) //Temel sınıfın kurucu fonksiyonda atanan sut değeri 60-100 arasında değilse 60-100 arasından değer atama
                {
                    sut = rastgele.Next(60, 100);
                }
                if (yetenek < 60 || yetenek > 100) //Temel sınıfın kurucu fonksiyonda atanan yetenek değeri 60-100 arasında değilse 60-100 arasından değer atama
                {
                    yetenek = rastgele.Next(60, 100);
                }
                if (kararlilik < 60 || kararlilik > 100) //Temel sınıfın kurucu fonksiyonda atanan kararlilik değeri 60-100 arasında değilse 60-100 arasından değer atama
                {
                    kararlilik = rastgele.Next(60, 100);
                }
                if (dogalForm < 60 || dogalForm > 100) //Temel sınıfın kurucu fonksiyonda atanan dogalForm değeri 60-100 arasında değilse 60-100 arasından değer atama
                {
                    dogalForm = rastgele.Next(60, 100);
                }
                if (sans < 600 || sans > 100) //Temel sınıfın kurucu fonksiyonda atanan sans değeri 60-100 arasında değilse 60-100 arasından değer atama
                {
                    sans = rastgele.Next(60, 100);
                }
            }

            public OrtaSaha(string AdSoyad, int FormaNo)
            {
                adSoyad = AdSoyad;
                formaNo = FormaNo;
            }

            public bool PasVer()
            {
                pasSkor = pas * 0.3 + yetenek * 0.2 + ozelYetenek * 0.2 + dayaniklilik * 0.1 + dogalForm * 0.1 + uzunTop * 0.1 + topSurme * 0.1 + sans * 0.1;
                if (Convert.ToInt32(pasSkor) > 60) //Pas skoru 60'tan büyükse doğru değilse yanlış döndürür
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool GolVurusu()
            {
                golSkor = yetenek * 0.3 + ozelYetenek * 0.2 + sut * 0.2 + ilkDokunus * 0.1 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.1;
                if (Convert.ToInt32(golSkor) > 70) //Gol skoru 70'ten büyükse doğru değilse yanlış döndürür
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        class Forvet : Futbolcu
        {
            public int bitiricilik;
            public int ilkDokunus;
            public int kafa;
            public int ozelYetenek;
            public int sogukkanlilik;

            public Forvet()
            {
                Random rastgele = new Random();

                bitiricilik = rastgele.Next(70, 100);
                ilkDokunus = rastgele.Next(70, 100);
                kafa = rastgele.Next(70, 100);
                ozelYetenek = rastgele.Next(70, 100);
                sogukkanlilik = rastgele.Next(70, 100);

                if (hiz < 70 || hiz > 100) //Temel sınıfın kurucu fonksiyonda atanan hız değeri 70-100 arasında değilse 70-100 arasından değer atama
                {
                    hiz = rastgele.Next(70, 100);
                }
                if (dayaniklilik < 70 || dayaniklilik > 100) //Temel sınıfın kurucu fonksiyonda atanan dayaniklilik değeri 70-100 arasında değilse 70-100 arasından değer atama
                {
                    dayaniklilik = rastgele.Next(70, 100);
                }
                if (pas < 70 || pas > 100) //Temel sınıfın kurucu fonksiyonda atanan pas değeri 70-100 arasında değilse 70-100 arasından değer atama
                {
                    pas = rastgele.Next(70, 100);
                }
                if (sut < 70 || sut > 100) //Temel sınıfın kurucu fonksiyonda atanan sut değeri 70-100 arasında değilse 70-100 arasından değer atama
                {
                    sut = rastgele.Next(70, 100);
                }
                if (yetenek < 70 || yetenek > 100) //Temel sınıfın kurucu fonksiyonda atanan yetenek değeri 70-100 arasında değilse 70-100 arasından değer atama
                {
                    yetenek = rastgele.Next(70, 100);
                }
                if (kararlilik < 70 || kararlilik > 100) //Temel sınıfın kurucu fonksiyonda atanan kararlilik değeri 70-100 arasında değilse 70-100 arasından değer atama
                {
                    kararlilik = rastgele.Next(70, 100);
                }
                if (dogalForm < 70 || dogalForm > 100) //Temel sınıfın kurucu fonksiyonda atanan dogalForm değeri 70-100 arasında değilse 70-100 arasından değer atama
                {
                    dogalForm = rastgele.Next(70, 100);
                }
                if (sans < 70 || sans > 100) //Temel sınıfın kurucu fonksiyonda atanan sans değeri 70-100 arasında değilse 70-100 arasından değer atama
                {
                    sans = rastgele.Next(70, 100);
                }
            }

            public Forvet(string AdSoyad, int FormaNo)
            {
                adSoyad = AdSoyad;
                formaNo = FormaNo;
            }

            public bool PasVer()
            {
                pasSkor = pas * 0.3 + yetenek * 0.2 + ozelYetenek * 0.2 + dayaniklilik * 0.1 + dogalForm * 0.1 + sans * 0.1;
                if (Convert.ToInt32(pasSkor) > 60) //Pas skoru 60'tan büyükse doğru değilse yanlış döndürür
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool GolVurusu()
            {
                golSkor = yetenek * 0.2 + ozelYetenek * 0.2 + sut * 0.1 + kafa * 0.1 + ilkDokunus * 0.1 + bitiricilik * 0.1 + sogukkanlilik * 0.1 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.1;
                if (Convert.ToInt32(golSkor) > 70) //Gol skoru 70'ten büyükse doğru değilse yanlış döndürür
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            List<Futbolcu> takim = new List<Futbolcu>();

            takim.Add(new Futbolcu("Oğuz Çalışkan", 1));
            takim.Add(new Defans("Ferhat Yazgan", 2));
            takim.Add(new Defans("Ümit Yasin Arslan", 3));
            takim.Add(new Defans("Hakkı Can Aksu", 4));
            takim.Add(new Defans("Alper Tursun", 5));
            takim.Add(new OrtaSaha("Dilaver Güçlü", 6));
            takim.Add(new OrtaSaha("Oğuz Kocabal", 7));
            takim.Add(new OrtaSaha("Savas Taga", 8));
            takim.Add(new OrtaSaha("Serkan Odabaşoğlu", 9));
            takim.Add(new Forvet("Tevfik Köse", 10));
            takim.Add(new Forvet("Berk İsmail Ünsal", 11));

            int FormaNo;
            int secilmisFormaNo;
            Boolean golOlabilir = true;
            Random Rastgele = new Random();
            FormaNo = Rastgele.Next(1, 11);
            Console.WriteLine(takim[FormaNo].formaNo + " numaralı futbolcu seçildi.");
            secilmisFormaNo = FormaNo;

            for (int i = 1; i <= 3; i++) //Oyuncu seçip pas verdirmek için döngü
            {
                FormaNo = Rastgele.Next(1, 11);
                while (secilmisFormaNo == FormaNo) //Rastgele üretilen formaNo değeri önceki formaNo değerine eşitse yeniden rastgele formaNo değeri üretme
                {
                    FormaNo = Rastgele.Next(1, 11);
                }

                Console.WriteLine(takim[FormaNo].formaNo + " numaralı oyuncuya pas verildi.");

                if (!takim[FormaNo].PasVer()) //Oyuncunun verdiği pas başarısız ise oyunu bitsin
                {
                    Console.WriteLine("Pas başarısız! :( ");
                    golOlabilir = false;
                    break;
                }
                if (i == 3) //3 pas yapıldıysa GolVurusu metodunu çalıştır
                {
                    if (takim[FormaNo].GolVurusu()) //GolVurusu başarılı ise ekrana yazdır
                    {
                        Console.WriteLine();
                        Console.WriteLine("*******GOOLLL*******");
                        Console.Write(takim[FormaNo].adSoyad);
                        Console.WriteLine("  " + takim[FormaNo].formaNo + " numara");
                    }
                    else //GolVurusu başarılı değil ise ekrana yazdır
                    {
                        Console.WriteLine("Gol başarısız! :( ");
                    }
                }
                secilmisFormaNo = FormaNo;
            }
            Console.ReadKey();
        }
    }
}
