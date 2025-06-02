using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Practice.Models
{
    public class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(double genislik, double yukseklik) 
        {
            Genislik = genislik; // Genislik ozelligini base class'tan aliyorum.
            Yukseklik = yukseklik; // Yukseklik ozelligini base class'tan aliyorum.
        }

        

    }
}
