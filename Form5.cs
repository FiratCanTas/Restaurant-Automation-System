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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            double ciro = 0;
            double ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in SiparisOlustur.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;

                foreach (EkstraMalzeme ekstra in siparis.EkstraMalzemes)
                {
                    ekstraMalzemeGeliri += ekstra.Fiyati;
                }

                satisAdedi += siparis.Adet;
                lbxTumSiparisler.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString();
            lblEkstraMalzeme.Text = ekstraMalzemeGeliri.ToString();
            lblSatilanUrunAdedi.Text = satisAdedi.ToString();
            lblToplamSiparis.Text = lbxTumSiparisler.Items.Count.ToString();
        }
    }
}
