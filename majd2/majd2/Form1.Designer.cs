namespace majd2
{
    partial class Form1
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cihaz = new TabControl();
            tabPage1 = new TabPage();
            label19 = new Label();
            label18 = new Label();
            lstCihazArizaKayitNo = new ListBox();
            lstCihazDegisenParcalar = new ListBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnYeniCihazEkle = new Button();
            txtUretimTarihi = new TextBox();
            txtModel = new TextBox();
            txtMarka = new TextBox();
            txtSeriNo = new TextBox();
            tabPage2 = new TabPage();
            btnYeniYedekParcaEkle = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtParcaStokAdedi = new TextBox();
            txtParcaUretimTarihi = new TextBox();
            txtParcaMarkaUyum = new TextBox();
            txtParcaAd = new TextBox();
            txtParcaSeriNo = new TextBox();
            tabPage3 = new TabPage();
            label17 = new Label();
            label16 = new Label();
            lstArizaTamirciYorumlari = new ListBox();
            lstArizaDegisenParcalar = new ListBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtYorumlar = new TextBox();
            txtCihazSeriNo = new TextBox();
            txtArizaKayitNo = new TextBox();
            btnArizaKaydiOlustur = new Button();
            tabPage4 = new TabPage();
            TamirModel = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            btnTamirTamam = new Button();
            txtTamirYorumlar = new TextBox();
            txtTamirModel = new TextBox();
            txtTamirMarka = new TextBox();
            txtTamirCihazSeriNo = new TextBox();
            btnYedekParcaEkle = new Button();
            btnTamirIslemiEkle = new Button();
            btnAra = new Button();
            label21 = new Label();
            label20 = new Label();
            txtTamirYorum = new TextBox();
            txtArizaKayitNoAra = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            lstTamirDegisenParcalar = new ListBox();
            lstTamirYedekParcalar = new ListBox();
            lstTamirIslemleri = new ListBox();
            Cihaz.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // Cihaz
            // 
            Cihaz.Controls.Add(tabPage1);
            Cihaz.Controls.Add(tabPage2);
            Cihaz.Controls.Add(tabPage3);
            Cihaz.Controls.Add(tabPage4);
            Cihaz.Location = new Point(0, 0);
            Cihaz.Name = "Cihaz";
            Cihaz.SelectedIndex = 0;
            Cihaz.Size = new Size(1150, 672);
            Cihaz.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(lstCihazArizaKayitNo);
            tabPage1.Controls.Add(lstCihazDegisenParcalar);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnYeniCihazEkle);
            tabPage1.Controls.Add(txtUretimTarihi);
            tabPage1.Controls.Add(txtModel);
            tabPage1.Controls.Add(txtMarka);
            tabPage1.Controls.Add(txtSeriNo);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1142, 639);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cihaz";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(379, 413);
            label19.Name = "label19";
            label19.Size = new Size(163, 20);
            label19.TabIndex = 12;
            label19.Text = "Değişen Parçalar Listesi";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(97, 424);
            label18.Name = "label18";
            label18.Size = new Size(148, 20);
            label18.TabIndex = 11;
            label18.Text = "Arıza Kayıt No Listesi";
            // 
            // lstCihazArizaKayitNo
            // 
            lstCihazArizaKayitNo.FormattingEnabled = true;
            lstCihazArizaKayitNo.Location = new Point(97, 462);
            lstCihazArizaKayitNo.Name = "lstCihazArizaKayitNo";
            lstCihazArizaKayitNo.Size = new Size(150, 104);
            lstCihazArizaKayitNo.TabIndex = 10;
            // 
            // lstCihazDegisenParcalar
            // 
            lstCihazDegisenParcalar.FormattingEnabled = true;
            lstCihazDegisenParcalar.Location = new Point(379, 462);
            lstCihazDegisenParcalar.Name = "lstCihazDegisenParcalar";
            lstCihazDegisenParcalar.Size = new Size(150, 104);
            lstCihazDegisenParcalar.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 262);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 8;
            label4.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 352);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 7;
            label3.Text = "UretimTarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 153);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Marka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 62);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "SeriNo";
            // 
            // btnYeniCihazEkle
            // 
            btnYeniCihazEkle.Location = new Point(519, 99);
            btnYeniCihazEkle.Name = "btnYeniCihazEkle";
            btnYeniCihazEkle.Size = new Size(94, 29);
            btnYeniCihazEkle.TabIndex = 4;
            btnYeniCihazEkle.Text = "Yeni Cihaz Ekle";
            btnYeniCihazEkle.UseVisualStyleBackColor = true;
            // 
            // txtUretimTarihi
            // 
            txtUretimTarihi.Location = new Point(108, 345);
            txtUretimTarihi.Name = "txtUretimTarihi";
            txtUretimTarihi.Size = new Size(198, 27);
            txtUretimTarihi.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(108, 255);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(198, 27);
            txtModel.TabIndex = 2;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(108, 146);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(198, 27);
            txtMarka.TabIndex = 1;
            // 
            // txtSeriNo
            // 
            txtSeriNo.Location = new Point(108, 59);
            txtSeriNo.Name = "txtSeriNo";
            txtSeriNo.Size = new Size(198, 27);
            txtSeriNo.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnYeniYedekParcaEkle);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtParcaStokAdedi);
            tabPage2.Controls.Add(txtParcaUretimTarihi);
            tabPage2.Controls.Add(txtParcaMarkaUyum);
            tabPage2.Controls.Add(txtParcaAd);
            tabPage2.Controls.Add(txtParcaSeriNo);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1142, 639);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Yedek Parça";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnYeniYedekParcaEkle
            // 
            btnYeniYedekParcaEkle.Location = new Point(439, 94);
            btnYeniYedekParcaEkle.Name = "btnYeniYedekParcaEkle";
            btnYeniYedekParcaEkle.Size = new Size(94, 29);
            btnYeniYedekParcaEkle.TabIndex = 10;
            btnYeniYedekParcaEkle.Text = "Yeni Yedek Parça Ekle";
            btnYeniYedekParcaEkle.UseVisualStyleBackColor = true;
            btnYeniYedekParcaEkle.Click += btnYeniYedekParcaEkle_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 296);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 9;
            label9.Text = "StokAdedi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 230);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 8;
            label8.Text = "UretimTarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 174);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 7;
            label7.Text = "Marka Uyum";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 115);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 6;
            label6.Text = "Ad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 47);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 5;
            label5.Text = "Seri No";
            // 
            // txtParcaStokAdedi
            // 
            txtParcaStokAdedi.Location = new Point(132, 289);
            txtParcaStokAdedi.Name = "txtParcaStokAdedi";
            txtParcaStokAdedi.Size = new Size(164, 27);
            txtParcaStokAdedi.TabIndex = 4;
            // 
            // txtParcaUretimTarihi
            // 
            txtParcaUretimTarihi.Location = new Point(132, 223);
            txtParcaUretimTarihi.Name = "txtParcaUretimTarihi";
            txtParcaUretimTarihi.Size = new Size(164, 27);
            txtParcaUretimTarihi.TabIndex = 3;
            // 
            // txtParcaMarkaUyum
            // 
            txtParcaMarkaUyum.Location = new Point(132, 171);
            txtParcaMarkaUyum.Name = "txtParcaMarkaUyum";
            txtParcaMarkaUyum.Size = new Size(164, 27);
            txtParcaMarkaUyum.TabIndex = 2;
            // 
            // txtParcaAd
            // 
            txtParcaAd.Location = new Point(132, 115);
            txtParcaAd.Name = "txtParcaAd";
            txtParcaAd.Size = new Size(164, 27);
            txtParcaAd.TabIndex = 1;
            // 
            // txtParcaSeriNo
            // 
            txtParcaSeriNo.Location = new Point(132, 44);
            txtParcaSeriNo.Name = "txtParcaSeriNo";
            txtParcaSeriNo.Size = new Size(164, 27);
            txtParcaSeriNo.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(lstArizaTamirciYorumlari);
            tabPage3.Controls.Add(lstArizaDegisenParcalar);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(txtYorumlar);
            tabPage3.Controls.Add(txtCihazSeriNo);
            tabPage3.Controls.Add(txtArizaKayitNo);
            tabPage3.Controls.Add(btnArizaKaydiOlustur);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1142, 639);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ariza Kayıt";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(398, 329);
            label17.Name = "label17";
            label17.Size = new Size(163, 20);
            label17.TabIndex = 10;
            label17.Text = "Değişen Parçalar Listesi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(129, 329);
            label16.Name = "label16";
            label16.Size = new Size(163, 20);
            label16.TabIndex = 9;
            label16.Text = "Tamirci Yorumları Listes";
            // 
            // lstArizaTamirciYorumlari
            // 
            lstArizaTamirciYorumlari.BackColor = Color.White;
            lstArizaTamirciYorumlari.FormattingEnabled = true;
            lstArizaTamirciYorumlari.Location = new Point(129, 362);
            lstArizaTamirciYorumlari.Name = "lstArizaTamirciYorumlari";
            lstArizaTamirciYorumlari.Size = new Size(150, 104);
            lstArizaTamirciYorumlari.TabIndex = 8;
            // 
            // lstArizaDegisenParcalar
            // 
            lstArizaDegisenParcalar.FormattingEnabled = true;
            lstArizaDegisenParcalar.Location = new Point(411, 362);
            lstArizaDegisenParcalar.Name = "lstArizaDegisenParcalar";
            lstArizaDegisenParcalar.Size = new Size(150, 104);
            lstArizaDegisenParcalar.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 271);
            label12.Name = "label12";
            label12.Size = new Size(68, 20);
            label12.TabIndex = 6;
            label12.Text = "Yorumlar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 182);
            label11.Name = "label11";
            label11.Size = new Size(98, 20);
            label11.TabIndex = 5;
            label11.Text = "Cihaz Seri No";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 109);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 4;
            label10.Text = "Ariza Kayit No";
            // 
            // txtYorumlar
            // 
            txtYorumlar.Location = new Point(96, 264);
            txtYorumlar.Name = "txtYorumlar";
            txtYorumlar.Size = new Size(249, 27);
            txtYorumlar.TabIndex = 3;
            // 
            // txtCihazSeriNo
            // 
            txtCihazSeriNo.Location = new Point(96, 175);
            txtCihazSeriNo.Name = "txtCihazSeriNo";
            txtCihazSeriNo.Size = new Size(249, 27);
            txtCihazSeriNo.TabIndex = 2;
            // 
            // txtArizaKayitNo
            // 
            txtArizaKayitNo.Location = new Point(96, 102);
            txtArizaKayitNo.Name = "txtArizaKayitNo";
            txtArizaKayitNo.Size = new Size(249, 27);
            txtArizaKayitNo.TabIndex = 1;
            // 
            // btnArizaKaydiOlustur
            // 
            btnArizaKaydiOlustur.Location = new Point(487, 131);
            btnArizaKaydiOlustur.Name = "btnArizaKaydiOlustur";
            btnArizaKaydiOlustur.Size = new Size(94, 29);
            btnArizaKaydiOlustur.TabIndex = 0;
            btnArizaKaydiOlustur.Text = "Arıza Kaydı Oluştur";
            btnArizaKaydiOlustur.UseVisualStyleBackColor = true;
            btnArizaKaydiOlustur.Click += btnArizaKaydiOlustur_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(TamirModel);
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(btnTamirTamam);
            tabPage4.Controls.Add(txtTamirYorumlar);
            tabPage4.Controls.Add(txtTamirModel);
            tabPage4.Controls.Add(txtTamirMarka);
            tabPage4.Controls.Add(txtTamirCihazSeriNo);
            tabPage4.Controls.Add(btnYedekParcaEkle);
            tabPage4.Controls.Add(btnTamirIslemiEkle);
            tabPage4.Controls.Add(btnAra);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(txtTamirYorum);
            tabPage4.Controls.Add(txtArizaKayitNoAra);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(lstTamirDegisenParcalar);
            tabPage4.Controls.Add(lstTamirYedekParcalar);
            tabPage4.Controls.Add(lstTamirIslemleri);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1142, 639);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tamir Etma";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // TamirModel
            // 
            TamirModel.AutoSize = true;
            TamirModel.Location = new Point(339, 480);
            TamirModel.Name = "TamirModel";
            TamirModel.Size = new Size(88, 20);
            TamirModel.TabIndex = 22;
            TamirModel.Text = "TamirModel";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(319, 384);
            label24.Name = "label24";
            label24.Size = new Size(86, 20);
            label24.TabIndex = 21;
            label24.Text = "TamirMarka";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(109, 470);
            label23.Name = "label23";
            label23.Size = new Size(105, 20);
            label23.TabIndex = 20;
            label23.Text = "TamirYoromlar";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(109, 384);
            label22.Name = "label22";
            label22.Size = new Size(121, 20);
            label22.TabIndex = 19;
            label22.Text = "TamirCihazserino";
            // 
            // btnTamirTamam
            // 
            btnTamirTamam.Location = new Point(669, 39);
            btnTamirTamam.Name = "btnTamirTamam";
            btnTamirTamam.Size = new Size(94, 29);
            btnTamirTamam.TabIndex = 18;
            btnTamirTamam.Text = "button1";
            btnTamirTamam.UseVisualStyleBackColor = true;
            btnTamirTamam.Click += btnTamirTamam_Click_1;
            // 
            // txtTamirYorumlar
            // 
            txtTamirYorumlar.Location = new Point(109, 503);
            txtTamirYorumlar.Name = "txtTamirYorumlar";
            txtTamirYorumlar.Size = new Size(125, 27);
            txtTamirYorumlar.TabIndex = 17;
            // 
            // txtTamirModel
            // 
            txtTamirModel.Location = new Point(319, 503);
            txtTamirModel.Name = "txtTamirModel";
            txtTamirModel.Size = new Size(125, 27);
            txtTamirModel.TabIndex = 16;
            txtTamirModel.TextChanged += textBox3_TextChanged;
            // 
            // txtTamirMarka
            // 
            txtTamirMarka.Location = new Point(319, 417);
            txtTamirMarka.Name = "txtTamirMarka";
            txtTamirMarka.Size = new Size(125, 27);
            txtTamirMarka.TabIndex = 15;
            // 
            // txtTamirCihazSeriNo
            // 
            txtTamirCihazSeriNo.Location = new Point(109, 417);
            txtTamirCihazSeriNo.Name = "txtTamirCihazSeriNo";
            txtTamirCihazSeriNo.Size = new Size(125, 27);
            txtTamirCihazSeriNo.TabIndex = 14;
            // 
            // btnYedekParcaEkle
            // 
            btnYedekParcaEkle.Location = new Point(432, 277);
            btnYedekParcaEkle.Name = "btnYedekParcaEkle";
            btnYedekParcaEkle.Size = new Size(158, 29);
            btnYedekParcaEkle.TabIndex = 12;
            btnYedekParcaEkle.Text = "Yedek Parça Ekle";
            btnYedekParcaEkle.UseVisualStyleBackColor = true;
            btnYedekParcaEkle.Click += btnYedekParcaEkle_Click;
            // 
            // btnTamirIslemiEkle
            // 
            btnTamirIslemiEkle.Location = new Point(432, 186);
            btnTamirIslemiEkle.Name = "btnTamirIslemiEkle";
            btnTamirIslemiEkle.Size = new Size(156, 29);
            btnTamirIslemiEkle.TabIndex = 11;
            btnTamirIslemiEkle.Text = "Tamir İşlemi Ekle";
            btnTamirIslemiEkle.UseVisualStyleBackColor = true;
            btnTamirIslemiEkle.Click += btnTamirIslemiEkle_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(397, 30);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 10;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(25, 281);
            label21.Name = "label21";
            label21.Size = new Size(51, 20);
            label21.TabIndex = 9;
            label21.Text = "Yorum";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 39);
            label20.Name = "label20";
            label20.Size = new Size(104, 20);
            label20.TabIndex = 8;
            label20.Text = "Ariza Kayit No";
            // 
            // txtTamirYorum
            // 
            txtTamirYorum.Location = new Point(109, 204);
            txtTamirYorum.Multiline = true;
            txtTamirYorum.Name = "txtTamirYorum";
            txtTamirYorum.Size = new Size(215, 97);
            txtTamirYorum.TabIndex = 7;
            // 
            // txtArizaKayitNoAra
            // 
            txtArizaKayitNoAra.Location = new Point(109, 32);
            txtArizaKayitNoAra.Name = "txtArizaKayitNoAra";
            txtArizaKayitNoAra.Size = new Size(125, 27);
            txtArizaKayitNoAra.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(801, 19);
            label15.Name = "label15";
            label15.Size = new Size(163, 20);
            label15.TabIndex = 5;
            label15.Text = "Değişen Parçalar Listesi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(801, 349);
            label14.Name = "label14";
            label14.Size = new Size(148, 20);
            label14.TabIndex = 4;
            label14.Text = "Yedek Parçalar Listesi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(499, 349);
            label13.Name = "label13";
            label13.Size = new Size(149, 20);
            label13.TabIndex = 3;
            label13.Text = "Tamir İşlemleri Listesi";
            // 
            // lstTamirDegisenParcalar
            // 
            lstTamirDegisenParcalar.FormattingEnabled = true;
            lstTamirDegisenParcalar.Location = new Point(801, 42);
            lstTamirDegisenParcalar.Name = "lstTamirDegisenParcalar";
            lstTamirDegisenParcalar.Size = new Size(224, 264);
            lstTamirDegisenParcalar.TabIndex = 2;
            // 
            // lstTamirYedekParcalar
            // 
            lstTamirYedekParcalar.FormattingEnabled = true;
            lstTamirYedekParcalar.Location = new Point(801, 384);
            lstTamirYedekParcalar.Name = "lstTamirYedekParcalar";
            lstTamirYedekParcalar.Size = new Size(224, 224);
            lstTamirYedekParcalar.TabIndex = 1;
            // 
            // lstTamirIslemleri
            // 
            lstTamirIslemleri.FormattingEnabled = true;
            lstTamirIslemleri.Location = new Point(499, 384);
            lstTamirIslemleri.Name = "lstTamirIslemleri";
            lstTamirIslemleri.Size = new Size(264, 224);
            lstTamirIslemleri.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 669);
            Controls.Add(Cihaz);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Cihaz.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Cihaz;
        private TabPage tabPage1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnYeniCihazEkle;
        private TextBox txtUretimTarihi;
        private TextBox txtModel;
        private TextBox txtMarka;
        private TextBox txtSeriNo;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ListBox lstCihazArizaKayitNo;
        private ListBox lstCihazDegisenParcalar;
        private Button btnYeniYedekParcaEkle;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtParcaStokAdedi;
        private TextBox txtParcaUretimTarihi;
        private TextBox txtParcaMarkaUyum;
        private TextBox txtParcaAd;
        private TextBox txtParcaSeriNo;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtYorumlar;
        private TextBox txtCihazSeriNo;
        private TextBox txtArizaKayitNo;
        private Button btnArizaKaydiOlustur;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private ListBox lstArizaTamirciYorumlari;
        private ListBox lstArizaDegisenParcalar;
        private Label label15;
        private Label label14;
        private Label label13;
        private ListBox lstTamirDegisenParcalar;
        private ListBox lstTamirYedekParcalar;
        private ListBox lstTamirIslemleri;
        private Button btnYedekParcaEkle;
        private Button btnTamirIslemiEkle;
        private Button btnAra;
        private Label label21;
        private Label label20;
        private TextBox txtTamirYorum;
        private TextBox txtArizaKayitNoAra;
        private TextBox txtTamirYorumlar;
        private TextBox txtTamirModel;
        private TextBox txtTamirMarka;
        private TextBox txtTamirCihazSeriNo;
        private Button btnTamirTamam;
        private Label TamirModel;
        private Label label24;
        private Label label23;
        private Label label22;
    }
}
