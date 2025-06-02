using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Practice.Models
{
    public class DikUcgen : BaseGeometrikSekil
    {
        public DikUcgen(double genislik, double yukseklik) 
        {
            Yukseklik = yukseklik;
            Genislik = genislik;


        }

        // alanhesapla metotunu dikucgen icin override ediyorum

        public override double AlanHesapla()
        {
            return Genislik * Yukseklik / 2; // Dik ucgenin alanini genislik ve yuksekligin carpimini 2'ye bolerek hesapliyorum.
        }




    }
}
