using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Practice.Models
{
    public class BaseGeometrikSekil
    {
        public virtual double  Genislik { get; set; }
        public virtual double Yukseklik { get; set; }

        
        
        

        // Alani hesaplayan metot virtual olarak tanimladim ki deger classlarda istedigim gibi degistirebileyim.
        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik; // Genislik ve yuksekligi carpip alan hesapliyorum.
        }

    }
}
