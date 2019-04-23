using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoLab4
{
    class ProductItem
    {

        public Produkt Produkt { get; set; }
        public int Kolicina { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1:0.0} x {2:0.0} = {3:0.00}", Produkt.Ime, Kolicina, Produkt.Cena, Kolicina * Produkt.Cena);
        }
    }
}
