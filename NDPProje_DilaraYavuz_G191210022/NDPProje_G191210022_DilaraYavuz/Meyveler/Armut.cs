using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje_G191210022_DilaraYavuz.Meyveler
{
    public class Armut:KatiMeyve
    {

        public override string Ad { get { _ad = "Armut"; return _ad; }  }
        public override string DosyaYolu { get { _dosyaYolu = "armut.jpg"; return _dosyaYolu; } }
        public override double AvitMiktari { get { _avitOrani = 0.25; return _avitOrani * Agirlik; }  }
        public override double CvitMiktari { get { _cvitOrani = 0.05; return _cvitOrani * Agirlik; }  }
        
    }
}
