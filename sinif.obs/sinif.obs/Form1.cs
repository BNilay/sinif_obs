using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinif.obs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci_bilgileri ogr = new ogrenci_bilgileri();

            ogr.ad = "Nilay";
            ogr.soyad = "Yılmaz";
            ogr.no = Convert.ToInt16(273);

            label1.Text="AD: "+ogr.ad;
            label2.Text = "Soyad: "+ogr.soyad;
            label3.Text ="No: "+ ogr.no.ToString();

            not_bilgileri not =  new not_bilgileri();

            not.sinav1 = 45;
            not.sinav2 = 60;
            not.sinav3 = 72;
            not.ort = ((not.sinav1 + not.sinav2 + not.sinav3) / 3);

            label4.Text="sinav1: "+ not.sinav1.ToString();
            label5.Text= "sinav2: " + not.sinav2.ToString();
            label6.Text= "sinav3: " + not.sinav3.ToString();
            label7.Text = "Ort: " + not.ort.ToString();

            pictureBox1.Visible = true;






        }
    }
}
