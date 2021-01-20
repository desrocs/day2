using System;

namespace day2
//değer tutucu ,alias
// type safety ,tip güvenliği
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmısMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45,,

            if (dolarDun>dolarBugun)
            {
                Console.writeline("Azalışbutonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.Writeline("Artış butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmısMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
