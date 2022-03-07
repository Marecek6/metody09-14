using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int cifSoucet = 0, lichSoucet = 0, sudSoucet = 0;
            if (Cifry.obsahujeCif(a, out cifSoucet, out lichSoucet, out sudSoucet))
            {
                MessageBox.Show("Obsahuje číslici");
                MessageBox.Show("Ciferný součet je " + cifSoucet);
                MessageBox.Show("Ciferný součet lichých čísel je " + lichSoucet);
                MessageBox.Show("Ciferný součet sudých čísel je " + sudSoucet);
            }
            else MessageBox.Show("Neobsahuje cifry");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text;
            string b;
            int pocetSlov1 = Cifry.pocetSlov(a,out b);
            MessageBox.Show("pocet slov ve vete " + pocetSlov1);
            MessageBox.Show("veta bez cislis " + b);
        }
    }
}
