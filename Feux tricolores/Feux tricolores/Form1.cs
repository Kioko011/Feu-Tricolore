using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feux_tricolores
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
            ovalShape1.BackColor = Color.Red;
            ovalShape2.BackColor = Color.Gray;
            ovalShape3.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ovalShape1.BackColor = Color.Gray;
            ovalShape2.BackColor = Color.Orange;
            ovalShape3.BackColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ovalShape1.BackColor = Color.Gray;
            ovalShape2.BackColor = Color.Gray;
            ovalShape3.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ovalShape1.BackColor = Color.Gray;
            ovalShape2.BackColor = Color.Gray;
            ovalShape3.BackColor = Color.Gray;
        }
    }
}
