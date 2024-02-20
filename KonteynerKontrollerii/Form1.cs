using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonteynerKontrollerii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            // İşlemci fiyat hesaplaması
            decimal cpuFiyat = 0;
            if (rbCpuI7.Checked)
                cpuFiyat = 300;
            else if (rbCpuI5.Checked)
                cpuFiyat = 200;
            else if (rbCpuI3.Checked)
                cpuFiyat = 100;
            else if (rbCpuR5.Checked)
                cpuFiyat = 250;
            else if (rbCpuR3.Checked)
                cpuFiyat= 150;
            tabanFiyat += cpuFiyat;
            // Ram bellek fiyat hesaplaması
            decimal ramFiyat = 0;
            if (rbRam16.Checked)
                ramFiyat = 125;
            else if (rbRam8.Checked)
                ramFiyat = 75;
            else if (rbRam4.Checked)
                ramFiyat = 45;
            tabanFiyat += ramFiyat;
            decimal hddFiyat = 0;
            if (rbHdd1000.Checked)
                hddFiyat = 900;
            if (rbHdd500.Checked)
                hddFiyat = 750;
            if (rbHdd320.Checked)
                hddFiyat = 450;
            tabanFiyat += hddFiyat;
            decimal lddFiyat = 0;
            if (cbDvd.Checked)
                lddFiyat+= 1200;
            if (cbWebCam.Checked)
                lddFiyat += 975;
            if (cbWifi.Checked)
                lddFiyat += 2500;
            tabanFiyat += lddFiyat;
            MessageBox.Show(string.Format("Toplam Fiyat ={0:C}", tabanFiyat));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
