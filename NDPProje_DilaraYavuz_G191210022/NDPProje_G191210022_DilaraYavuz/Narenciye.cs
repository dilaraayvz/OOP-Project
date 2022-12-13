using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje_G191210022_DilaraYavuz
{
    public abstract class Narenciye:IMeyve
    {
        protected string _ad;
        protected string _dosyaYolu;
        protected double _avitOrani;
        protected double _cvitOrani;
        protected double _verim;
        protected double _agirlik;

        public abstract string Ad { get; }
        public abstract string DosyaYolu { get; }
        public double Agirlik { get { Random rnd = new Random(); _agirlik = rnd.Next(70, 121); return _agirlik; } }// ağırlık bütün sıkılabilir meyvelerde aynı şekilde hesaplanır.
        public abstract double AvitMiktari { get; }
        public abstract double CvitMiktari { get; }
        public double Miktar { get { Random rnd = new Random(); _verim = rnd.Next(30, 71); return (_verim * Agirlik) / 100; } } // miktar bütün sıkılabilir meyvelerde aynı şekild 
        public bool KatiMeyveMi()
        {
            return false;
        }
    }
}
