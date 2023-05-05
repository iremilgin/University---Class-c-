using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteUygulamasi.Abstract;

namespace UniversiteUygulamasi.Classes
{
    public class Ogrenci: Kisi
    {
        public Ogrenci()
        {
            AlinanDersler = new List<Ders>();
        }
        public int OkulNo { get; set; }
        public List<Ders> AlinanDersler { get; set; }

        /// <summary>
        /// Bu method ogrencinin ders almasını saglar ve alıp almadıgını kontro eder.
        /// </summary>
        /// <param name="ders"></param>
        /// <exception cref="Exception"></exception>
        public void DersAl(Ders ders)
        {
            bool dersiAldiMi = ders.OgrenciEkle(this);
            if (dersiAldiMi)
            {
                this.AlinanDersler.Add(ders);
            }
            else throw new Exception("Dersi Alamadık");
        }

        public void DersiPuanla(Ders ders, int puan)
        {
            ders.ZorlukPuaniHesapla(puan);
        }
    }
}
