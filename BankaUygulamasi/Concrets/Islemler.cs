using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BankaUygulamasi.Concrets
{
    public static class Islemler
    {
        public static void Kaydet(List<Musteri> musteris)
        {
            var json = JsonSerializer.Serialize(musteris);
            string dosyaYolu = @"C:\Users\edito\Desktop\BilgeAdamProjeHaftasi\BankaUygulamasi\BankaFormKismi\Musteriler.txt";
            File.WriteAllText(dosyaYolu, json);
        }
        public static object VerileriAl(string Directory)
        {
            try
            {

                string okunacakMetin = File.ReadAllText(Directory);
                if (okunacakMetin == string.Empty)
                {
                    return null;

                }
                else
                    return JsonSerializer.Deserialize<List<Musteri>>(okunacakMetin) ?? new();

            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
