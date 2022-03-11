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

        private void button3_Click(object sender, EventArgs e)
        {
            string nejdesislovo, nejkratsislovo;
            string a = textBox3.Text;
            if (Cifry.obsahujeSlovo(a, out nejkratsislovo, out nejdesislovo)) 
            {
                MessageBox.Show("obsahuje slovo");
                MessageBox.Show("nejdelsi slovo " + nejdesislovo);
                MessageBox.Show("nejkratsi slovo " + nejkratsislovo);
            }
            else
            {
                MessageBox.Show("neobsahuje slovo");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text;
            int pocetSlov1 = Cifry.pocetSlov2(ref a);
            MessageBox.Show("pocet slov ve vete " + pocetSlov1);
            MessageBox.Show("veta bez cislis " + a);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = textBox8.Text;
            int pocetvelkych, pocetmalych, pocetjinych;
            if (Cifry.jeAlfanum(s, out pocetmalych, out pocetvelkych, out pocetjinych))
            {
                MessageBox.Show("je alfanumerický");
                MessageBox.Show("počet malých: " + pocetmalych);
                MessageBox.Show("počet velkých: " + pocetvelkych);
                MessageBox.Show("počet jiných " + pocetjinych);
            }
            else
            {
                MessageBox.Show("není alfanumerický");
                MessageBox.Show("počet malých: " + pocetmalych);
                MessageBox.Show("počet velkých: " + pocetvelkych);
                MessageBox.Show("počet jiných " + pocetjinych);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s1 = textBox4.Text;
            string s2 = textBox5.Text;
            int pocetOdlisnosti, indexOdlisnosti;
            if(Cifry.identicke(s1, s2, out pocetOdlisnosti, out indexOdlisnosti))
            {
                MessageBox.Show("jsou identické");
            }
            else
            {
                MessageBox.Show("nejsou identické");
                MessageBox.Show("pocet odlisnosti " + pocetOdlisnosti);
                MessageBox.Show("index odlisnosti " + indexOdlisnosti);
            }
        }
    }
}
