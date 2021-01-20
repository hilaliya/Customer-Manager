using System;

namespace Eticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Musteri musteri1 = new Musteri();
            musteri1.ID = 12345;
            musteri1.Name = "Hilal YILMAZ";
            musteri1.Mail = "hilalyilmaz@mail.com";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 12349;
            musteri2.Name = "Bilal YILMAZ";
            musteri2.Mail = "bilalyilmaz@mail.com";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 72343;
            musteri3.Name = "Bekir YILMAZ";
            musteri3.Mail = "bekiryilmaz@mail.com";


            MusteriManager Manager = new MusteriManager();

            Manager.Add(musteri3);


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri x in musteriler) // ilk Urun (yeşil olan) veri tipini ifade eder. Class ismi de bir veri tipidir. var yazsan da olur
            {
                Console.WriteLine(x.Name);
                Console.WriteLine(x.ID);
                Console.WriteLine(x.Mail);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("Musteriler:");
            Manager.Listele(musteriler);

        }
    }
}
