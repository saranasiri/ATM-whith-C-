using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeh_payan_term
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
     
        public static int numbr_send = 0; 

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Form3.n);
            int b = int.Parse(textBox1.Text);
           // int  your_account_num =int.Parse( Form3.SetValueForText1);
            if (a>=b)
            {
                MessageBox.Show("عملیات موفق آمیز بود ");
            }
            else
            {
                MessageBox.Show("موجودی کافی نیست  ");
            }
            

            numbr_send = int.Parse(textBox1.Text);
        }
    }
}
