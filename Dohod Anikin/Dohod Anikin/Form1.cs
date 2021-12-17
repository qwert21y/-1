using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dohod_Anikin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int summa = Convert.ToInt32(textBox1.Text);
            int sv = Convert.ToInt32(textBox2.Text);
            int pv = Convert.ToInt32(textBox3.Text);
            double t = summa / 100;
            double u = t * pv;
            double r = u * sv;
            double vivod = (summa + r);
            textBox4.Text = Convert.ToString(vivod);
        }
    }
}
