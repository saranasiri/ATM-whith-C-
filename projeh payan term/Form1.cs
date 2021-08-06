using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projeh_payan_term
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private StreamWriter filerider;
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename;
            DialogResult result;
            using (SaveFileDialog filechooser = new SaveFileDialog())
            {
                filechooser.CheckFileExists = false;
                result = filechooser.ShowDialog();
                filename = filechooser.FileName;
            }
            FileStream output = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            filerider = new StreamWriter(output);
            filerider.Write(textBox1.Text + ",");
            filerider.Write(textBox2.Text+ ",");
            filerider.Write(maskedTextBox1.Text + ",");
            filerider.Write(textBox4.Text+",");
            if (radioButton1.Checked == true) { filerider.Write(radioButton1.Text + ","); };
            if (radioButton2.Checked == true) { filerider.Write(radioButton2.Text + ","); };
            if (checkBox1.Checked == true) { filerider.Write(checkBox1.Text + ","); };
            if (checkBox2.Checked == true) { filerider.Write(checkBox2.Text + ","); };
            if (checkBox3.Checked == true) { filerider.Write(checkBox3.Text + ","); };
            if (checkBox4.Checked == true) { filerider.Write(checkBox4.Text + ","); };
            if (checkBox5.Checked == true) { filerider.Write(checkBox5.Text + ","); };
            filerider.Write(maskedTextBox2.Text + ",");
            filerider.Write(textBox6.Text + ",");
            
           
            
            filerider.Close();

            //var result = a.Split(",");
            // foreach (var item in result)
            // {

            // array.arraye[array.num] = item.ToArray();


            // }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

      

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))

            {

             e.Handled = true;

            }
         


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }
        }

       

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))) { e.Handled = true; MessageBox.Show("Enter only digit and decimal point.", "Alert!"); }

            



        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))) { e.Handled = true; MessageBox.Show("Enter only digit and decimal point.", "Alert!"); }

    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            maskedTextBox1.Text = " ";
            textBox4.Text = " ";
            maskedTextBox2.Text = " ";
            textBox6.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }

        }
    }
}
