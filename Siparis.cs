using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciOdevi
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemes = new List<EkstraMalzeme>();
        }
        public Menu SecilenMenu { get; set; }//Zaten kullanici combobox tan cektiği için 1 tane cekebiliyor

        public List<EkstraMalzeme> EkstraMalzemes { get; set; }

        public Boyut Boyut { get; set; }

        public int Adet { get; set; }

        public double ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SecilenMenu.Fiyati;
            //Kucuk boy seçimde hiçbirsey yapma orta ise 0.10 ile çarp büyük ise 0.30 le çarp

            switch (Boyut)
            {
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.10;
                    break;
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.30;
                    break;
               
            }


            foreach (var ekstra in EkstraMalzemes)
            {
                ToplamTutar += ekstra.Fiyati;
            }

            ToplamTutar = ToplamTutar * Adet; 
        }

        //ListBox a seçilen siparişi ekrana düzgün formatta yazmak için tostring metodu override edip metot gövdesi değiştirilmiştir.
        public override string ToString()
        {
            if (EkstraMalzemes.Count < 1)
            {
                return $"Menu : {SecilenMenu}, Adet : {Adet}, Boy : {Boyut}, Toplam Tutar : {ToplamTutar}";
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (EkstraMalzeme ekstra in EkstraMalzemes)
                {
                    ekstraMalzemeler = ekstra.EkstraAdi + ",";//Ranch,Ketcap,Mayonez
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');//En son eklenen virgülü temizler
                return $"Menu : {SecilenMenu}, Adet : {Adet}, Boy : {Boyut}, Toplam Tutar : {ToplamTutar}, Ekstra : {ekstraMalzemeler}";
            }
        }
    }
}
