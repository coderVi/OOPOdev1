using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SatilikEv> sList = new List<SatilikEv>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SatilikEv se = new SatilikEv
                {
                    Ilce = txtIlce.Text,
                    Adres = txtAdres.Text,
                    Alan = Convert.ToInt32(txtAlan.Text),
                    OdaSayisi = Convert.ToInt32(txtOda.Text),
                    Isinma = txtIsinma.Text,
                    Telefon = txtTel.Text,
                    Fiyat = Convert.ToInt32(txtFiyat.Text),

                };
                sList.Add(se);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sList;
        }
        List<KiralikEv> kList = new List<KiralikEv>();
        private void btnEkleKira_Click(object sender, EventArgs e)
        {
            try
            {
                KiralikEv ke = new KiralikEv
                {
                    Ilce = txtKitaIlce.Text,
                    Adres = txtKiraAdres.Text,
                    Alan = Convert.ToInt32(txtKiraAlan.Text),
                    OdaSayisi = Convert.ToInt32(txtKiraOda.Text),
                    Isinma = txtKiraIsinma.Text,
                    Telefon = txtKiraTel.Text,
                    Fiyat = int.Parse(txtKiraFiyat.Text),
                    Depozito = Convert.ToInt32(txtDepozito.Text),
                    Tarih = dateTimePicker1.Value
                };
                kList.Add(ke);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }  
        }

        private void btnListeKira_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = kList;
        }
    }
}
