using System;
using System.Collections.Generic;
using System.Text;

namespace Eticaret
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.ID + " ID'li " + musteri.Name + " isimli müşteri başarıyla eklendi");
            Console.WriteLine("----------------------");

        }

        public void Del(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + "silindi");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine(item.Name);
            }
            
        }

    }
}
