using BankaUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Concrets
{
    public class Musteri
    {
        public MusteriTipi MusteriTipi { get; set; }
        public int SiraNumarasi { get; set; }
        public int TCNumarasi { get; set; }

        public Musteri(MusteriTipi musteriTipi,  int tcNumarasi)
        {
            MusteriTipi = musteriTipi;
            
            TCNumarasi = tcNumarasi;
        }

        

    }
}
