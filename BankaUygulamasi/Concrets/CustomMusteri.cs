using BankaUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Concrets
{
    public class CustomMusteri : Musteri
    {
        public CustomMusteri(MusteriTipi musteriTipi, int tcNumarasi) : base(musteriTipi, tcNumarasi)
        {

        }
        public override string ToString()
        {
            return $" Tc Numarası : {TCNumarasi} Sıra Numarası : {SiraNumarasi}  {MusteriTipi}";
        }
    }
}
