using BankaUygulamasi.Concrets;
using BankaUygulamasi.Enums;

namespace BankaFormKismi

{
    public partial class Form1 : Form
    {
        Musteri m1;
        Siralandirma s1 = new Siralandirma();
        List<Musteri> YeniMusteriListesi = new List<Musteri>();




        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(MusteriTipi)));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out MusteriTipi tipi);
            m1 = new CustomMusteri(tipi, Convert.ToInt32(txtTc.Text));
            s1.MusterileriSiralandir(m1);
            listBox1.Items.AddRange(MusterilerListesi.TumMusteriler.ToArray());




        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            MusterilerListesi.TumMusteriler=MusterilerListesi.TumMusteriler.OrderBy(x => x.SiraNumarasi).ToList();
            listBox1.Items.AddRange(MusterilerListesi.TumMusteriler.ToArray());
            listBox1.Update();
            listBox1.Refresh();

        }
    }
}