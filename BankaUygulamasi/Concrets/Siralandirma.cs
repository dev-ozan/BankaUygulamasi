using BankaUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Concrets
{
    public class Siralandirma : MusterilerListesi
    {

  
        int SiraNo = 1000;
        int VipSiraNo = 1;

        public void MusterileriSiralandir(Musteri yeniMusteri)
        {
            if (yeniMusteri.MusteriTipi == MusteriTipi.VIP && VipMusteriler.Count == 0)
            {
                yeniMusteri.SiraNumarasi = VipSiraNo;
                VipMusteriler.Add(yeniMusteri);
                TumMusteriler.Add(yeniMusteri);

                VipSiraNo++;
            }
            else if (yeniMusteri.MusteriTipi == MusteriTipi.VIP && VipMusteriler.Count != 0)
            {
                yeniMusteri.SiraNumarasi = VipSiraNo;
                VipMusteriler.Add(yeniMusteri);
                TumMusteriler.Add(yeniMusteri);
                VipSiraNo++;
            }
            else if (yeniMusteri.MusteriTipi == MusteriTipi.Bireysel)
            {

                yeniMusteri.SiraNumarasi = SiraNo;
                BireyselMusteriler.Add(yeniMusteri);
                TumMusteriler.Add(yeniMusteri);
                SiraNo++;

            }
            else if (yeniMusteri.MusteriTipi == MusteriTipi.GiseMusterisi)
            {

                yeniMusteri.SiraNumarasi = SiraNo;
                GiseMusterileri.Add(yeniMusteri);
                TumMusteriler.Add(yeniMusteri);
                SiraNo++;

            }


        }


    }
}
