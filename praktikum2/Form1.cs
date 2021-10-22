using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string Luaspersegi()
        {
            int p, l, luas;
            p = int.Parse(txtpanjang.Text);
            l = int.Parse(txtlebar.Text);
            luas =p * l;

            return luas.ToString();
        }


        private void hitungluas()
        {
            int p, l, luas;
            p = int.Parse(txtpanjang.Text);
            l = int.Parse(txtlebar.Text);
            luas = p * l;
            txthasilvoid.Text = luas.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hitungluas();
            }
            catch
            {
                MessageBox.Show("Masukan angka dulu !");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                txthasilfungsi.Text = Luaspersegi();
            }
            catch
            {
                MessageBox.Show("Masukan angka dulu !");
            }
            
        }
    }
}
