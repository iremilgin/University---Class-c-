using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteUygulamasi.Abstract;
using UniversiteUygulamasi.Interface;

namespace UniversiteUygulamasi.Classes
{
    public class Guvenlik : Kisi, ICalisan
    {
        public DateTime IseGirisTarihi { get; set; }
        public decimal Maas { get; set; }

        
        public void Koru()
        {
                Console.WriteLine($" Ben {Ad} {Soyad} isimli güvenlik görevlisi olarak üniversitenin güvenliğini sağlıyorum.");  
        }
    }
}
