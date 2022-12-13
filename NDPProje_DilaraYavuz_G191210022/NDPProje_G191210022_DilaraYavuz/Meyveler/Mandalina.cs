using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje_G191210022_DilaraYavuz.Meyveler
{
    public class Mandalina : Narenciye
    {

        public override string Ad { get { _ad = "Mandalina"; return _ad; } }
        public override string DosyaYolu { get {_dosyaYolu = "mandalina.jpg"; return _dosyaYolu; } }
        public override double AvitMiktari { get {_avitOrani = 6.81; return _avitOrani * Agirlik; }  }
        public override double CvitMiktari { get {_cvitOrani = 0.26; return _cvitOrani * Agirlik; }  }
    }
}
