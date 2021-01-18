 using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Han";
            musteri1.Yas = 34;
            musteri1.EPosta = "ahmet@han.com";
            musteri1.CepTelefonu = 053300000;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Han";
            musteri2.Yas = 35;
            musteri2.EPosta = "mehmet@han.com";
            musteri2.CepTelefonu = 053300001;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ceren";
            musteri3.Soyadi = "Han";
            musteri3.Yas = 28;
            musteri3.EPosta = "ceren@han.com";
            musteri3.CepTelefonu = 053300002;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Zeynep";
            musteri4.Soyadi = "Han";
            musteri4.Yas = 44;
            musteri4.EPosta = "zeynep@han.com";
            musteri4.CepTelefonu = 053300003;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);

            musteriManager.Listele(musteri1, musteri2, musteri3, musteri4);

            musteriManager.Sil(musteri2);

           



        }
    }
}
