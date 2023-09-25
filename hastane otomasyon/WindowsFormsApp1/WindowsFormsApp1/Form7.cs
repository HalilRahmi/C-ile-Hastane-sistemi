using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;

        DataSet ds;
        public Form7()
        {
            InitializeComponent();
        }

        void griddoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kayit.accdb");
            da = new OleDbDataAdapter("SElect *from ecz", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ecz");
            dataGridView1.DataSource = ds.Tables["ecz"];
            con.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ecz (h_no,ilac1,ilac2,ilac3) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update ecz set ilac1='" + textBox2.Text + "',ilac2='" + textBox3.Text + "',ilac3='" + textBox4.Text + "' where h_no=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from ecz where h_no=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kayitSayisi;
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM ecz";
            kayitSayisi = (int)cmd.ExecuteScalar();
            con.Close();
            MessageBox.Show(kayitSayisi.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.aeo.org.tr/NobetModulu/Nobet?AspxAutoDetectCookieSupport=1");
        }
    }
}
