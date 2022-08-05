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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            EkstraMalzeme yeniEkstraMalzeme = new EkstraMalzeme();
            yeniEkstraMalzeme.EkstraAdi = txtEkstraMalzemeAdi.Text;
            yeniEkstraMalzeme.Fiyati = Convert.ToDouble( nmrEkstraMalzemeFiyat.Value);

            SiparisOlustur.ekstraMalzemes.Add(yeniEkstraMalzeme);

            MessageBox.Show("Ekstra malzeme başarı ile eklendi");
        }
    }
}
