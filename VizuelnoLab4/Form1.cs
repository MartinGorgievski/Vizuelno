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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProdukt_Click(object sender, EventArgs e)
        {
            AddProdukt produkt = new AddProdukt();
            DialogResult rez = produkt.ShowDialog();

            if(rez == DialogResult.OK)
            {
                lstProdukti.Items.Add(produkt.Produkt);
            }
        }

        private void lstProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produkt prod = new Produkt();
            if(lstProdukti.SelectedIndex != -1)
            {
                prod = (Produkt)lstProdukti.SelectedItem;

                txtIme.Text = prod.Ime;
                txtCat.Text = prod.Kategorija;
                txtCena.Text = String.Format("{0:0.00}", prod.Cena);
                

            }
            else
            {
                txtIme.Text = "";
                txtCena.Text = "";
                txtCat.Text = "";
            }
        }

        private void btnDelProdukt_Click(object sender, EventArgs e)
        {
          
            if(lstProdukti.SelectedIndex != -1)
            {
                lstProdukti.Items.Remove(lstProdukti.SelectedItem);

                txtIme.Text = "";
                txtCena.Text = "";
                txtCat.Text = "";
            }
        }

        private void btnAddKosnicka_Click(object sender, EventArgs e)
        {
            ProductItem prodItem = new ProductItem();
            if(lstProdukti.SelectedIndex != -1)
            {
                if(txtVkupno.Text.Trim().Length == 0)
                {
                    txtVkupno.Text = "0.00";
                }

                double vk = 0.00d;
                double.TryParse(txtVkupno.Text, out vk);
                prodItem.Produkt = (Produkt)lstProdukti.SelectedItem;
                prodItem.Kolicina = (int)numKolicina.Value;

                lstKosnicka.Items.Add(prodItem);

                
                vk += prodItem.Produkt.Cena * prodItem.Kolicina;

                txtVkupno.Text = string.Format("{0:0.00}", vk);
            }
        }

        private void btnDelKosnicka_Click(object sender, EventArgs e)
        {
            ProductItem prodItem = new ProductItem();
            if (lstKosnicka.SelectedIndex != -1)
            {
                double vk = 0.00d;
                double.TryParse(txtVkupno.Text, out vk);

                prodItem = (ProductItem)lstKosnicka.SelectedItem;
                lstKosnicka.Items.Remove(lstKosnicka.SelectedItem);

                vk -= prodItem.Kolicina * prodItem.Produkt.Cena;

                txtVkupno.Text = String.Format("{0:0.00}", vk);
            }
        }

        private void btnIsprazniProdukt_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Дали сте сигурни дали сакате да ја испразните листата на продукти?",  "Испразни ја листата",  MessageBoxButtons.YesNo);

            if(rez == DialogResult.Yes)
            {
                lstProdukti.Items.Clear();
            }
        }

        private void btnIsprazniKosnicka_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Дали сте сигурни дали сакате да ја испразните кошничката?", "Испразни ја листата", MessageBoxButtons.YesNo);

            if (rez == DialogResult.Yes)
            {
                lstKosnicka.Items.Clear();
            }
        }
    }
}
