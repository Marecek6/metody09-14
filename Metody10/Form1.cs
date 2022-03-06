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
            string idk = textBox1.Text;
            int cifSoucet = 0, lichSoucet = 0, sudSoucet = 0;
            if (Cifry.obsahujeCif(idk, out cifSoucet, out lichSoucet, out sudSoucet))
            {
                MessageBox.Show("Obsahuje číslici");
                MessageBox.Show("Ciferný součet je " + cifSoucet);
                MessageBox.Show("Ciferný součet lichých čísel je " + lichSoucet);
                MessageBox.Show("Ciferný součet sudých čísel je " + sudSoucet);
            }
            else MessageBox.Show("Neobsahuje cifry");
        }
    }
}
