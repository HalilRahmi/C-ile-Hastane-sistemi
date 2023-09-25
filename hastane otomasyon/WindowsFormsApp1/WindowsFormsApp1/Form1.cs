using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            Form2 frm = new Form2();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanici;


            string sifre;





            Kullanici = textBox1.Text;


            sifre = textBox2.Text;





            if (Kullanici == "halil" && sifre == "11111")

            {
                
                Form2 ff = new Form2();
                ff.Show();

                

                
            }



            else

            {
                MessageBox.Show("Hatalı Giriş!...");
            }
        }
    }
}
