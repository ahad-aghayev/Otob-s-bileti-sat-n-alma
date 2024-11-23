using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcretHesapla_Click(object sender, EventArgs e)
        {
            OtobusBileti o = new OtobusBileti();
            if (chcIndirim.Checked)
            {
                MessageBox.Show("Toplam Ücretiniz: " + o.indirim(int.Parse(txtKisiSayisi.Text)));
            }
            else
            {
                MessageBox.Show("Toplam Ücretiniz: " + o.fiyat(int.Parse(txtKisiSayisi.Text)));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
