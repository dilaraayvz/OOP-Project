using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje_G191210022_DilaraYavuz
{
    public interface IMeyve
    {
        // Butun meyvelerde bulunan ortak özellik ve metodlar.
        string Ad { get; }
        string DosyaYolu { get; }
        double Agirlik { get; }
        double AvitMiktari { get; }
        double CvitMiktari { get; }
        double Miktar { get; }
        bool KatiMeyveMi();
    }

    
}
