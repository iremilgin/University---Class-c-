using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteUygulamasi.Enums;
using UniversiteUygulamasi.Interface;

namespace UniversiteUygulamasi.Classes
{
    public class Ders : IAlan
    {
        public Ders()
        {
            Ogretmen = new Ogretmen();
            Ogrenciler = new List<Ogrenci>();
        }

        private List<Ogrenci> Ogrenciler { get; set;  }
        public Ogretmen Ogretmen { get; set; }
        private double toplamPuan;
        private int puanlayanOgrenciSayisi;

        private double zorlukPuani;
        public double ZorlukPuani
        {
            get { return zorlukPuani; }
        }
        public Alan Alan { get; set; }


        // En fazla 10 Öğrenci
        /// <summary>
        /// Bu method gelen ogrenciyi ogrenci listesine ekler.
        /// </summary>
        /// <param name="ogrenci"></param>
        /// <returns></returns>
        public bool OgrenciEkle(Ogrenci ogrenci)
        {
            if (this.Ogrenciler.Count < 10)
            {
                this.Ogrenciler.Add(ogrenci); 
            return true;
            }
            return false;
        }

        /// <summary>
        /// bu method aldıgı parametreye gore zorluk puanını gonceller
        /// </summary>
        /// <param name="puan">ogrencinin gonderdigi puan</param>
        public void ZorlukPuaniHesapla(int puan)
        {
            toplamPuan += puan;
            puanlayanOgrenciSayisi++;
            zorlukPuani = toplamPuan / puanlayanOgrenciSayisi;
        }

        /// <summary>
        /// Bu method dersi baslatir ve ogretmene ders anlattirir.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void DersBasla()
        {
            bool dersAnlatildiMi = this.Ogretmen.DersAnlat(this);
            if (dersAnlatildiMi)
            {
                Ogretmen.DersiBitir();
            }
            else throw new Exception("Bu hoca da hiçbir şey bilmiyor. Bir dersi anlattıramadık.");
        }
    }
}
