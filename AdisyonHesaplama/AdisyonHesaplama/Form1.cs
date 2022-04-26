using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdisyonHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tutar=Convert.ToInt32(textBox1.Text);
            double kdv = 0.08;
            double küver = 0.15;
            double total = tutar + tutar * kdv + tutar * küver;
            listBox1.Items.Add("Yemek: " + tutar.ToString("C"));
            listBox1.Items.Add("KDV: " + kdv.ToString("P"));
            listBox1.Items.Add("Küver: " + küver.ToString("P"));
            listBox1.Items.Add("Toplam ödenecek tutar: " +total.ToString("C"));
        }
    }
}
