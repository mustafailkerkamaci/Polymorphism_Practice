using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Practice.Models
{
    public class Kare : BaseGeometrikSekil
    {
        // karenin kenar uzunlugu icin bir alan
        private double _kenar;

        public Kare(double kenar) // kare nesnesi olusturdugumda  bir kenar uzunlugu vermem gerekiyor.
        {
            _kenar = kenar;

        }

        public override double Genislik // base classtaki genislik ozelligini override ediyorum
        {
            get { return _kenar; } // Genislik istendiiginde kenar uzunlugunu donduruyor.
            set { _kenar = value; } // kenar uzunlugunu degistirebiliyorum.
        }
        public override double Yukseklik // base classtaki yukseklik ozelligini override ediyorum
        {
            get { return _kenar; } // Yukseklik istendiginde kenar uzunlugunu donduruyor.
            set { _kenar = value; } // kenar uzunlugunu degistirebiliyorum.
        }




    }
}
