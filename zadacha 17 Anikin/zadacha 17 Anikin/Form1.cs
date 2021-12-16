using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha_17_Anikin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mes = 0;

            if (radioButton1.Checked == true)
            { mes = 3500; }
            if (radioButton2.Checked == true)
            { mes = 2500; }
            if (radioButton3.Checked == true)
            { mes = 1500; }

            string dota1 = textBox1.Text;

            int dota2 = Convert.ToInt32(dota1);

            int itog = dota2 * 200 + mes;

            textBox2.Text = Convert.ToString(itog);
        }
    }
}
