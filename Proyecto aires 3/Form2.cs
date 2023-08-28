using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_aires_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("0");
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1");
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("2");
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("3");
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }
    }
}
