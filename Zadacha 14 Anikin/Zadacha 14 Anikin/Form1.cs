using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_14_Anikin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rast = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked == true)
            { int sum = 100 * rast; }
            else if (radioButton2.Checked)
            { int sum = 200 * rast; }
            textBox2.Text = Convert.ToString(rast);
        }
    }
}
    

