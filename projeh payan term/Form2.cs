using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeh_payan_term
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form3 F = new Form3();

            //F.MdiParent = this;

            //F.Show();
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }
    }
}
