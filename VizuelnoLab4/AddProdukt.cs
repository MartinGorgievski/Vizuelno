using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizuelnoLab4
{
    public partial class AddProdukt : Form
    {
        public Produkt Produkt { get; set; }

        public AddProdukt()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double cena = 0.00d;
            Produkt = new Produkt();
            Produkt.Ime = txtIme.Text;
            Produkt.Kategorija = txtKategorija.Text;
            if(double.TryParse(txtCena.Text, out cena))
            {
                Produkt.Cena = cena;

                DialogResult = DialogResult.OK;
            }
           
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(txtIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorName.SetError(txtIme, "Внесете име !");
            }
            else
            {
                errorName.SetError(txtIme, null);
            }
        }
    }
}
