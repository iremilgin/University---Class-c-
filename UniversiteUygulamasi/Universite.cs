using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteUygulamasi.Classes;

namespace UniversiteUygulamasi
{
    internal class Universite
    {

        public Universite()
        {
            Ogretmen = new Ogretmen();
            Ogrenci = new Ogrenci();
            Guvenlik = new Guvenlik();  
        }
        public Ogretmen Ogretmen { get; set; }  
        public Ogrenci Ogrenci { get; set; }    
        public Guvenlik Guvenlik { get; set; }  

    }
}
