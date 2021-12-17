using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interaktivnaya_karta_Anikin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

            label1.Text = "Avendia Rudge";
            label2.Text = "Напитки";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;

            label1.Text = "Theatro Municipal";
            label2.Text = "Напитки";

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true; pictureBox13.Visible = true;
            label3.Visible = true; pictureBox14.Visible = true;
            label4.Visible = false; pictureBox15.Visible = false;
            label5.Visible = false; pictureBox16.Visible = false;
            label6.Visible = true;  pictureBox17.Visible = true;

           
            
            
           
          

            label1.Text = "Parque do Ibirapuera";
            label2.Text = "Напитки";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true; pictureBox13.Visible = true;
            label3.Visible = true; pictureBox14.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;

           
           
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = false;

            label1.Text = "Jardim Luzitania";
            label2.Text = "Напитки";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = true;

            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = false;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;

            label1.Text = "Iguatemi";
            label2.Text = "Напитки";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = false;

            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = false;
            pictureBox16.Visible = true;
            pictureBox17.Visible = false;

            label1.Text = "Rua Lisboa";
            label2.Text = "Напитки";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;

            label1.Text = "Cemitério da Consolação";
            label2.Text = "Напитки";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;

            label1.Text = "Cemitério da Consolação";
            label2.Text = "Напитки";


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false; pictureBox13.Visible = false;
            label4.Visible = false; pictureBox14.Visible = false;
            label5.Visible = false; pictureBox15.Visible = false;
            label6.Visible = false; pictureBox16.Visible = false;

           
          
           
           
            pictureBox17.Visible = false;

            label1.Text = "Race start";
            label2.Text = "Samba Full Marathon";
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

            label1.Text = "Race start";
            label2.Text = "Capoeira 5km Fun Run";
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

            label1.Text = "Race start";
            label2.Text = "Jongo Half Marathon";
            
        }
    }
}
