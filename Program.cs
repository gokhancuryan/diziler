using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi","köpek","kuş","Maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere erişim ve değer atama

            renkler[0] = "Mavi";
            renkler[1] ="Kırmızı";
            renkler[2] = "Yeşil";
            renkler[3] = "Mor";
            renkler[4] = "Sarı";

            Console.WriteLine(hayvanlar[0]);

            dizi[3] = 15;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı 
            // klavyeden girilen n tane sayının ortalamasını alan program.
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu]; 
            

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
                Console.WriteLine("Ortalama : " + toplam/diziUzunlugu);
            }




        }
    }
}