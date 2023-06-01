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
        List<Musteri> YeniMusteriListesi = new List<Musteri>();
        int index;
        int index2;
        int VipAdet;
        int kontrol = 0;


        //Musteri m1 = new Musteri(MusteriTipi.GiseMusterisi, 15, 519);
        int SiraNo = 1;



        public void MusterileriSiralandir(Musteri yeniMusteri)
        {
            if (yeniMusteri.MusteriTipi == MusteriTipi.VIP && VipMusteriler.Count == 0)
            {
                yeniMusteri.SiraNumarasi = SiraNo;
                VipMusteriler.Add(yeniMusteri);
                TumMusteriler.Add(yeniMusteri);

                SiraNo++;
            }
            else if (yeniMusteri.MusteriTipi == MusteriTipi.VIP && VipMusteriler.Count != 0)
            {
                yeniMusteri.SiraNumarasi = SiraNo;
                VipMusteriler.Add(yeniMusteri);
                TumMusteriler.Add(yeniMusteri);
                SiraNo++;
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


            KontrolEt(yeniMusteri);

        }
        public void KontrolEt(Musteri yeniMusteri)
        {
            //if (GiseMusterileri.Count % 3 == 0 && yeniMusteri.MusteriTipi != MusteriTipi.Bireysel)
            //{
            //    Console.WriteLine("Hatalı müşteri tipi seçtiniz. Müşteri tiği Bireysel olabilir.");
            //    return;

            //}
            //else if (GiseMusterileri.Count % 3 == 0 && yeniMusteri.MusteriTipi == MusteriTipi.Bireysel)
            //{
            //    Console.WriteLine("Başarılı Giriş yaptınız.");
            //}




            YeniMusteriListesi.Add(yeniMusteri);

            if (yeniMusteri.MusteriTipi == MusteriTipi.VIP)





                index = YeniMusteriListesi.LastIndexOf(yeniMusteri);

            VipAdet = YeniMusteriListesi.Count(x => x.MusteriTipi == MusteriTipi.VIP);


            for (int i = YeniMusteriListesi.Count - 1; i >= 0; i--)
            {


                //if (YeniMusteriListesi[i].MusteriTipi == MusteriTipi.VIP)
                //{
                //    kontrol++;
                //}


                if ( yeniMusteri.MusteriTipi == MusteriTipi.VIP && i != index)
                {
                    index2 = i;
                    break;
                }



            }




            for (int i = 1; i < YeniMusteriListesi.Count; i++)
            {

                //int index = YeniMusteriListesi.FindLastIndex(x => x.MusteriTipi == MusteriTipi.VIP);

                if (YeniMusteriListesi[i].MusteriTipi == MusteriTipi.VIP && (YeniMusteriListesi[i - 1].MusteriTipi == MusteriTipi.Bireysel || YeniMusteriListesi[i - 1].MusteriTipi == MusteriTipi.GiseMusterisi))
                {
                    Musteri temp = YeniMusteriListesi[i];
                    YeniMusteriListesi.RemoveAt(i);
                    YeniMusteriListesi.Insert(index2 + 1, temp);
                }
            }


            for (int i = 0; i < YeniMusteriListesi.Count; i++)
            {
                YeniMusteriListesi[i].SiraNumarasi = i + 1;
            }




        }



    }
}
