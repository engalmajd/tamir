namespace majd2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            lstTamirYedekParcalar.DisplayMember = "Ad";
            lstTamirDegisenParcalar.DisplayMember = "Ad";
             lstCihazArizaKayitNo.DisplayMember = "ArizaKayitNo";
            lstArizaTamirciYorumlari.DisplayMember = "TamirciYorumlari";
            lstArizaDegisenParcalar.DisplayMember = "DegisenParcalar";
        }

        List<Cihaz1> cihazListesi = new List<Cihaz1>();
        List<YedekParca> yedekParcaListesi = new List<YedekParca>();
        List<ArizaKaydi> arizaKayitListesi = new List<ArizaKaydi>();
        public class Cihaz1
        {

            public string SeriNo { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public int UretimTarihi { get; set; }
            public List<string> DegisenParcalar { get; set; }
            public List<int> ArizaKayitNoListesi { get; set; }

            public Cihaz1()
            {
                DegisenParcalar = new List<string>();
                ArizaKayitNoListesi = new List<int>();
            }
        }

        public class YedekParca
        {
            public string SeriNo { get; set; }
            public string Ad { get; set; }
            public string MarkaUyum { get; set; }
            public int UretimTarihi { get; set; }
            public int StokAdedi { get; set; }
        }

        public class ArizaKaydi
        {
            public int ArizaKayitNo { get; set; }
            public string CihazSeriNo { get; set; }
            public string Yorumlar { get; set; }
            public List<string> DegisenParcalar { get; set; }
            public List<string> TamirciYorumlari { get; set; }

            public ArizaKaydi()
            {
                DegisenParcalar = new List<string>();
                TamirciYorumlari = new List<string>();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniCihazEkle_Click(object sender, EventArgs e)
        {
            string seriNo = txtSeriNo.Text;
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            int uretimTarihi = int.Parse(txtUretimTarihi.Text);

            Cihaz1 yeniCihaz = new Cihaz1
            {
                SeriNo = seriNo,
                Marka = marka,
                Model = model,
                UretimTarihi = uretimTarihi,
                DegisenParcalar = new List<string>(),
                ArizaKayitNoListesi = new List<int>()
            };

            cihazListesi.Add(yeniCihaz);
            MessageBox.Show("Yeni cihaz başarıyla eklendi!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnYeniYedekParcaEkle_Click(object sender, EventArgs e)
        {
            string seriNo = txtParcaSeriNo.Text;
            string ad = txtParcaAd.Text;
            string markaUyum = txtParcaMarkaUyum.Text;
            int uretimTarihi = int.Parse(txtParcaUretimTarihi.Text);
            int stokAdedi = int.Parse(txtParcaStokAdedi.Text);

            YedekParca yeniParca = new YedekParca
            {
                SeriNo = seriNo,
                Ad = ad,
                MarkaUyum = markaUyum,
                UretimTarihi = uretimTarihi,
                StokAdedi = stokAdedi
            };

            yedekParcaListesi.Add(yeniParca);
            MessageBox.Show("Yeni yedek parça başarıyla eklendi!");

            lstTamirYedekParcalar.Items.Clear();
            foreach (var parca in yedekParcaListesi)
            {
                lstTamirYedekParcalar.Items.Add(parca);
            }
        }


        private void btnArizaKaydiOlustur_Click(object sender, EventArgs e)
        {
            int arizaKayitNo = int.Parse(txtArizaKayitNo.Text);
            string cihazSeriNo = txtCihazSeriNo.Text;
            string yorumlar = txtYorumlar.Text;

            ArizaKaydi yeniArizaKaydi = new ArizaKaydi
            {
                ArizaKayitNo = arizaKayitNo,
                CihazSeriNo = cihazSeriNo,
                Yorumlar = yorumlar,
                DegisenParcalar = new List<string>(),
                TamirciYorumlari = new List<string>()
            };

            arizaKayitListesi.Add(yeniArizaKaydi);
            MessageBox.Show("Arıza kaydı başarıyla oluşturuldu!");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int arizaKayitNo = int.Parse(txtArizaKayitNoAra.Text);
            var arizaKaydi = arizaKayitListesi.FirstOrDefault(a => a.ArizaKayitNo == arizaKayitNo);

            if (arizaKaydi != null)
            {
                txtTamirCihazSeriNo.Text = arizaKaydi.CihazSeriNo;
                txtTamirYorumlar.Text = arizaKaydi.Yorumlar;

                lstTamirDegisenParcalar.Items.Clear();
                lstTamirDegisenParcalar.Items.AddRange(arizaKaydi.DegisenParcalar.ToArray());

            
                lstArizaTamirciYorumlari.Items.Clear();
                lstArizaTamirciYorumlari.Items.AddRange(arizaKaydi.TamirciYorumlari.ToArray());

              
                btnTamirTamam.Enabled = true;
            }
            else
            {
                MessageBox.Show("ÖNCE ARIZA KAYIT ET TABINA GIDIN");
                btnTamirTamam.Enabled = false;
            }
        }

        private void btnTamirIslemiEkle_Click(object sender, EventArgs e)
        {
            int arizaKayitNo = int.Parse(txtArizaKayitNoAra.Text);
            var arizaKaydi = arizaKayitListesi.FirstOrDefault(a => a.ArizaKayitNo == arizaKayitNo);

            if (arizaKaydi != null)
            {
                arizaKaydi.TamirciYorumlari.Add(txtTamirYorum.Text);

                lstArizaTamirciYorumlari.Items.Clear();
                lstArizaTamirciYorumlari.Items.AddRange(arizaKaydi.TamirciYorumlari.ToArray());
                foreach (var yorum in arizaKaydi.TamirciYorumlari)
                {
                    lstTamirIslemleri.Items.Add(yorum);
                }
                txtTamirYorum.Clear();
                MessageBox.Show("Tamir İşlemi Eklendi.");
            }
            else
            {
                MessageBox.Show("Geçerli bir arıza kayıt numarası giriniz.");
            }

        }

        private void btnYedekParcaEkle_Click(object sender, EventArgs e)
        {
            var selectedParca = (YedekParca)lstTamirYedekParcalar.SelectedItem;
            int arizaKayitNo = int.Parse(txtArizaKayitNoAra.Text);
            var arizaKaydi = arizaKayitListesi.FirstOrDefault(a => a.ArizaKayitNo == arizaKayitNo);

            if (selectedParca != null && arizaKaydi != null)
            {
                arizaKaydi.DegisenParcalar.Add(selectedParca.Ad);
                selectedParca.StokAdedi--;

                lstTamirDegisenParcalar.Items.Clear();
                lstTamirDegisenParcalar.Items.AddRange(arizaKaydi.DegisenParcalar.ToArray());

                MessageBox.Show("Yedek parça başarıyla eklendi ve stok adedi güncellendi.");
            }
            else
            {
                MessageBox.Show("Geçerli bir yedek parça ve arıza kayıt numarası seçiniz.");
            }
        }

        private void btnTamirTamam_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTamirTamam_Click_1(object sender, EventArgs e)
        {
            int arizaKayitNo = int.Parse(txtArizaKayitNoAra.Text);
            var arizaKaydi = arizaKayitListesi.FirstOrDefault(a => a.ArizaKayitNo == arizaKayitNo);

            if (arizaKaydi != null)
            {
                MessageBox.Show("Tamir işlemi başarıyla tamamlandı!");
            }
            else
            {
                MessageBox.Show("Geçerli bir arıza kayıt numarası giriniz.");
            }
        }
    }
}
