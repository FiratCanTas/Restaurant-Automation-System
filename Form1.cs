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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void tsmSiparisOlustur_Click_1(object sender, EventArgs e)
        {

            ChildFromAc(new SiparisOlustur());
           
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildFromAc(new Form5());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildFromAc(new Form3());
        }

        private void tsmEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildFromAc(new Form4());
        }

        void ChildFromAc(Form childFrom)
        {
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childFrom.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childFrom.MdiParent = this;
                childFrom.Show();
            }
        }

    }
}
