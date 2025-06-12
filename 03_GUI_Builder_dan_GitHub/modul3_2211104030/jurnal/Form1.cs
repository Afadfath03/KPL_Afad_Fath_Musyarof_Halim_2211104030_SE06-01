using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal
{
    public partial class Form1 : Form
    {
        private int currentValue = 0;
        private int storedValue = 0;
        private bool isAdding = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void angka(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                label1.Text += btn.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                label1.Text += " " + btn.Text + " ";
            }
        }

        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            try {
                var result = new DataTable().Compute(label1.Text, null);
                label1.Text = result.ToString();
            }
            catch (Exception ex) {
                label1.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            angka(sender, e);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
