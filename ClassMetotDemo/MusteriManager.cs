using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Eklendi.. "+musteri.Ad+" "+musteri.Soyad);
        }
        public void MusteriSil()
        {

        }
        public void MusteriListele(Musteri[] musteriList)
        {
            
            foreach (Musteri musteri in musteriList)
            {
                Console.WriteLine(musteri.Id+" "+musteri.Ad+" "+musteri.Soyad+" "+musteri.Yas+" "+musteri.Adres);
            }
        }
    }
}
