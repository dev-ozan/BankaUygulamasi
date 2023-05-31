﻿using BankaUygulamasi.Enums;
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
        Musteri m1 = new Musteri(MusteriTipi.GiseMusterisi, 15, 519);
        int SiraNo = 1;
        int Vip = 0;
        int Gise = 0;
        int Bireyse = 0;


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
            List<Musteri> YeniMusteriListesi = new List<Musteri>();
            if (GiseMusterileri.Count % 3 == 0 && yeniMusteri.MusteriTipi != MusteriTipi.Bireysel)
            {
                Console.WriteLine("Hatalı müşteri tipi seçtiniz. Müşteri tiği Bireysel olabilir.");
                return;

            }
            else if (GiseMusterileri.Count % 3 == 0 && yeniMusteri.MusteriTipi == MusteriTipi.Bireysel)
            {
                Console.WriteLine("Başarılı Giriş yaptınız.");
            }

            YeniMusteriListesi.Add(yeniMusteri);
            for (int i = 0; i < YeniMusteriListesi.Count; i++)
            {
                if (YeniMusteriListesi[i].MusteriTipi == MusteriTipi.VIP && YeniMusteriListesi[i+1].MusteriTipi == MusteriTipi.Bireysel || YeniMusteriListesi[i + 1].MusteriTipi == MusteriTipi.Bireysel)
                {
                    int gecici = m1.SiraNumarasi;

                    m1.SiraNumarasi = yeniMusteri.SiraNumarasi;
                    yeniMusteri.SiraNumarasi = gecici;
                }
            }
            



        }



    }
}
