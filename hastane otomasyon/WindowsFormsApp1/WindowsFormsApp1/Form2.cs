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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form3 frm = new Form3();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ff = new Form4();
            ff.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 ff = new Form5();
            ff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 ff = new Form6();
            ff.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 ff = new Form7();
            ff.Show();
        }
    }
    }

