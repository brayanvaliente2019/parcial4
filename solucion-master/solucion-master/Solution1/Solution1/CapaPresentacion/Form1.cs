using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        enfermo neg = new enfermo();
        
        enfermo enlc = new enfermo();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(enlc.prueba());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            neg.a = Convert.ToInt32 (textBox1.Text);
            neg.b = textBox2.Text;
            neg.c = textBox3.Text;
            neg.d = textBox4.Text;
            neg.e = textBox5.Text;
            neg.f = Convert.ToInt32 (textBox6.Text);


            neg.insertVendor(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(textBox6.Text));

            limpiar();
            cargar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            neg.a = Convert.ToInt32(textBox1.Text);
            neg.b = textBox2.Text;
            neg.c = textBox3.Text;
            neg.d = textBox4.Text;
            neg.e = textBox5.Text;
            neg.f = Convert.ToInt32(textBox6.Text);

            neg.updateVendor(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(textBox6.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            neg.f =Convert.ToInt32( textBox1.Text);
            neg.deletVendor();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void limpiar() {
           
        }
        public void cargar() { }
           
        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            cargar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
