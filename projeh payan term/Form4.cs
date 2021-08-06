using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeh_payan_term
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {



            
            Form5 form5 = new Form5();
            form5.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form3.n);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           textBox1.Text=( Form3.nam)+"   "+(Form3.f)+"       "+(Form3.c)+"      :   موجودی   "+(Form3.n)+"  ";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        
    }
}
