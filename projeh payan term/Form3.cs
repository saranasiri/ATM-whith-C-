using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;




namespace projeh_payan_term
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
          public static string SetValueForText1 = "";
          public static string n = "";
          public static string nam = "";
          public static string f = "";
          public static string c= "";
          public static string list_of_name = "";
          public static string second_num = "";


        private void button1_Click(object sender, EventArgs e)
        {
            
            List <Class1> persons = new List<Class1>();



            try

            {
                string filename;
                
                DialogResult result;
                using (OpenFileDialog filechooser = new OpenFileDialog())
                {
                    filechooser.CheckFileExists = false;
                    result = filechooser.ShowDialog();
                    filename = filechooser.FileName;
                }
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
               // reader = new StreamReader(fs);
               // FileStream fs = new FileStream(@"C:\Users\LENOVO\Documents\Apowersoft\New folder\s.text", FileMode.Open, FileAccess.Read);



                StreamReader reader = new StreamReader(fs);
               




                while (!reader.EndOfStream)

                {

                    string line = reader.ReadLine();
                    

                    string[] fields = line.Split(',');

                    Class1 newPerson = new Class1();

                    newPerson.FirstName = fields[0];

                    newPerson.LastName = fields[1];

                    newPerson.Age = int.Parse(fields[2]);

                    newPerson.city = fields[3];

                    newPerson.sexuality = fields[4];

                    newPerson.education = fields[5];

                    newPerson.account = fields[6];

                    newPerson.number = fields[7];


                    persons.Add(newPerson);

                }

            }

            catch (IOException ex)

            {

                Console.WriteLine(ex.Message);

            }
            foreach (Class1 p in persons)

                {


                    string a = textBox1.Text;
                
                    if (a == p.account)
                    {

                        Form4 form4 = new Form4();
                        form4.Show();
                        n = p.number;
                        nam = p.FirstName;
                        f = p.LastName;
                        c = p.city;

                     } 

                    else
                    {
                        MessageBox.Show("try again");
                         int counter = 0;
                    if (counter >= 3)
                    {
                        Form2 form2 = new Form2();
                        
                        this.Hide();
                        form2.Show();

                    }
                    else { counter++; }
                        
                    }
               // string b = Form5.send_account_num.ToString();
               // if (p.account == b)
                //{
                //    second_num = p.number;
               // }
                list_of_name += p.FirstName + p.LastName;

            }
            SetValueForText1 = textBox1.Text;
           
          


        }

            //Show each person's details

            // foreach (Class1 p in persons)

            //{

            //  Console.WriteLine("Name: {0} {1}nAge: {2}",

            // p.FirstName, p.LastName, p.Age);

            //}

        



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(n);
              a -= Form5.numbr_send;
            second_num += Form5.numbr_send;
           


            }
    }
}
