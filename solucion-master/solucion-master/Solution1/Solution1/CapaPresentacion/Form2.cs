using capaNegocio;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        hospital neq = new hospital();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            neq.a = Convert.ToInt32(textBox1.Text);
            neq.b = textBox2.Text;
            neq.c = textBox3.Text;
            neq.d = textBox4.Text;
            neq.e = Convert.ToInt32(textBox5.Text);
            


            neq.insertVendor(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));

           
        }
    }
}
