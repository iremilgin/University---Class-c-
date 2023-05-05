using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteUygulamasi.Abstract;
using UniversiteUygulamasi.Enums;
using UniversiteUygulamasi.Interface;

namespace UniversiteUygulamasi.Classes
{
    public class Ogretmen : Kisi, ICalisan, IAlan

    {
        public DateTime IseGirisTarihi { get; set; }
        public decimal Maas { get; set; }
      
        public Alan Alan { get; set; }

        public Durum Durum { get; set; }    

        public bool DersAnlat(Ders ders)
        {
            if (ders.Alan == this.Alan)
            {
                this.Durum = Durum.Meşgul;
                return true;
            }
            return false;
        }

        public void DersiBitir()
        {
            if (this.Durum == Durum.Meşgul)
            {
                this.Durum = Durum.Müsait;
            }
            else throw new Exception("Ben hangi dersi bitireyim? Zaten derste değilim.");
        }
    }
}
