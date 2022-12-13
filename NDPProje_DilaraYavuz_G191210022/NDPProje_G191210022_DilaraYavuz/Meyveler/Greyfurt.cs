using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje_G191210022_DilaraYavuz.Meyveler
{
    public class Greyfurt:Narenciye
    {

        public override string Ad { get { _ad = "Greyfurt";  return _ad; } }
        public override string DosyaYolu { get {_dosyaYolu = "greyfurt.jpg"; return _dosyaYolu; }  }
        public override double AvitMiktari { get {_avitOrani = 0.03; return _avitOrani * Agirlik; } }
        public override double CvitMiktari { get {_cvitOrani = 0.44; return _cvitOrani * Agirlik; }  }
    }
}
