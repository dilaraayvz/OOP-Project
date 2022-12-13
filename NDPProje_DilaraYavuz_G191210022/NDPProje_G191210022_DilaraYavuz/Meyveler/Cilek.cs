using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje_G191210022_DilaraYavuz.Meyveler
{
    public class Cilek:KatiMeyve
    {

        public override string Ad { get { _ad = "Çilek"; return _ad; } }
        public override string DosyaYolu { get { _dosyaYolu = "cilek.jpg"; return _dosyaYolu; } }
        public override double AvitMiktari { get { _avitOrani = 0.12; return _avitOrani * Agirlik; } }
        public override double CvitMiktari { get { _cvitOrani = 0.6; return _cvitOrani * Agirlik; } }
    }
}
