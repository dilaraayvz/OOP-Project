using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje_G191210022_DilaraYavuz
{
    public class Portakal : Narenciye
    {
        
        public override string Ad { get { _ad = "Portakal"; return _ad; }  }
        public override string DosyaYolu { get {_dosyaYolu = "portakal.jpg"; return _dosyaYolu; } }
        public override double AvitMiktari { get {_avitOrani = 2.25; return _avitOrani*Agirlik; }  }
        public override double CvitMiktari { get {_cvitOrani = 0.45; return _cvitOrani * Agirlik; }  }

      

    }
}
