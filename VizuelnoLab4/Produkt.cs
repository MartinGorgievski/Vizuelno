using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoLab4
{
    public class Produkt
    {
        public string Ime { get; set; }
        public string Kategorija { get; set; }
        public double Cena { get; set; }


        public override string ToString()
        {
            return string.Format("{0}", Ime);
        }
    }
}
