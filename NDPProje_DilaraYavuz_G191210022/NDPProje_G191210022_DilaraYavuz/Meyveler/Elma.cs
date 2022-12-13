using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje_G191210022_DilaraYavuz.Meyveler
{
    public class Elma:KatiMeyve
    {

        public override string Ad { get {_ad = "Elma";  return _ad; }}
        public override string DosyaYolu { get {_dosyaYolu = "elma.jpg"; return _dosyaYolu; } }
        public override double AvitMiktari { get {_avitOrani = 0.54; return _avitOrani * Agirlik; }  }
        public override double CvitMiktari { get {_cvitOrani = 0.05; return _cvitOrani * Agirlik; } }
    }
}
