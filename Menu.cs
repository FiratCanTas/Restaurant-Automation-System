using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciOdevi
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public double Fiyati { get; set; }

        //Tostring metodunnu ezdiğim için artık bana nesne oluşturup ekrana batığın zaman harburgerciodevi.menu gibi bir ifade cıkarmayacak.
        public override string ToString()
        {
            return $"Menu : {MenuAdi}, Fiyat : {Fiyati}";
        }
    }
}
