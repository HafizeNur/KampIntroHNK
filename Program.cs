using System;

namespace KampIntroHNK
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety=tip güvenliği
            //Don not repeat yourself - Kendini tekrarlama 
            //deger tutucu,alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(ogrenciSayisi);
            //Console.WriteLine(faizOrani);
            //Console.WriteLine(sistemeGirisYapmisMi);

            double dolarDun = 6.35;
            double dolarBugun = 7.45;

            //dolar kontrolü bloğu
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            //sistem girişi kontrolü bloğu
            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Giriş Yapıldı ");
            }
            else
            {
                Console.WriteLine("Giriş Yapılmadı");
            }

            Console.ReadKey();
        }
    }
}
