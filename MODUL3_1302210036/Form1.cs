using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODUL3_1302210036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text[label1.Text.Length - 2] != '+')
            {
                label1.Text = label1.Text + " + ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int digitAwal = 0, intHold1 = 0;
            for(int digitAkhir = 0; digitAkhir < label1.Text.Length; digitAkhir++)
            {
                if (label1.Text[digitAkhir] == ' ')
                {
                    intHold1 += int.Parse(label1.Text.Substring (digitAwal, digitAkhir));
                    digitAwal = digitAkhir + 2;
                    digitAkhir += 2;
                }
            }
            label1.Text = intHold1.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }
    }
}
