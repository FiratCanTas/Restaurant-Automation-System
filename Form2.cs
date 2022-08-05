using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciOdevi
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu(){MenuAdi = "BigMac", Fiyati=76 },
            new Menu(){MenuAdi = "Cheeseburger", Fiyati=50 },
            new Menu(){MenuAdi = "KöfteBurger", Fiyati=88 },
            new Menu(){MenuAdi = "McChicken", Fiyati=150 }


        };

        public static List<EkstraMalzeme> ekstraMalzemes = new List<EkstraMalzeme>()
        {
            
            new EkstraMalzeme() {EkstraAdi = "Ranch", Fiyati=2.5},
            new EkstraMalzeme() {EkstraAdi = "Ketçap", Fiyati=1.5},
            new EkstraMalzeme() {EkstraAdi = "Mayonez", Fiyati=1.5},
            new EkstraMalzeme() {EkstraAdi = "Barbekü", Fiyati=3.5},
            new EkstraMalzeme() {EkstraAdi = "Buffalo", Fiyati=3.5}
        };

        public static List<Siparis> mevcutSiparisleri = new List<Siparis>();
        public static List<Siparis> tumSiparisler = new List<Siparis>();

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (var item in menuler)
            {
                cmbMenu.Items.Add(item);
            }

            foreach (var item in ekstraMalzemes)
            {
                object x = 5;
                flpExtraMalzemeSecimi.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });
            }
            foreach (var item in mevcutSiparisleri)
            {
                lbxSiparisSepeti.Items.Add(item);
            }

            TutarHesapla();

            rdbKucuk.Checked = true;//Baştan secili olması için
            cmbMenu.SelectedIndex = 0;//Baştan secili olması için
        }

        private double TutarHesapla()
        {
            double toplamTutar = 0;
            for (int i = 0; i < lbxSiparisSepeti.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisSepeti.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString();

            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SecilenMenu = (Menu)cmbMenu.SelectedItem;

            if (rdbKucuk.Checked)
            {
                yeniSiparis.Boyut = Boyut.Kucuk;
            }
            else if (rdbOrta.Checked)
            {
                yeniSiparis.Boyut = Boyut.Orta;
            }
            else
                yeniSiparis.Boyut = Boyut.Buyuk;


            foreach (CheckBox item in flpExtraMalzemeSecimi.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.EkstraMalzemes.Add((EkstraMalzeme)item.Tag);
                }

            }

            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla();

            mevcutSiparisleri.Add(yeniSiparis);
            tumSiparisler.Add(yeniSiparis);
            lbxSiparisSepeti.Items.Add(yeniSiparis);

            TutarHesapla();
            //Temizleme metodunu çağır
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı : " + TutarHesapla().ToString() + "\n Satın almayı tamamlamak ister misin ?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lbxSiparisSepeti.Items.Clear();
                mevcutSiparisleri.Clear();
                TutarHesapla(); //0 a çekiyoruz kırmızı yazılan toplam tutarı
                MessageBox.Show("Siparişiniz Tamamlandı");
            }
            else
            {
                MessageBox.Show("Sipariş İptal Edildi!");
            }
        }
    }
}

