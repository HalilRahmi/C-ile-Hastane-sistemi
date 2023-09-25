using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  // Access bağlantısı kurabilmek için.
using System.Collections; //ArrayList kullanabilmek için.
namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbDataReader dr;
        DataSet ds;

        public Form3()
        {
            InitializeComponent();
        }
        void griddoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kayit.accdb");
            da = new OleDbDataAdapter("SElect *from hasta", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "hasta");
            dataGridView1.DataSource = ds.Tables["hasta"];
            con.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kayitDataSet.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter.Fill(this.kayitDataSet.hasta);

            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into hasta (h_no,h_ad,h_soyad,h_tel) values ('" + hno.Text + "','" + had.Text + "','" + hsoyad.Text + "','" + htel.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update hasta set h_ad='" + had.Text + "',h_soyad='" + hsoyad.Text + "',h_tel='" + htel.Text + "' where h_no=" + hno.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from hasta where h_no=" + hno.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            hno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            had.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            hsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            htel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM hasta";
            dr = cmd.ExecuteReader();

            ArrayList Isimler = new ArrayList();


            while (dr.Read())
            {
                Isimler.Add(dr["h_ad"]); // istersek arraylist'e atabiliriz.
                listBox1.Items.Add(dr["h_no"]);
                listBox2.Items.Add(dr["h_ad"]);
                listBox3.Items.Add(dr["h_soyad"]);
                listBox4.Items.Add(dr["h_tel"]);
            }
            foreach (string eleman in Isimler)
            {
                listBox5.Items.Add(eleman);
            }

            dr.Close();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int kayitSayisi;
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM hasta";
            kayitSayisi = (int)cmd.ExecuteScalar();
            con.Close();
            MessageBox.Show(kayitSayisi.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kayit.accdb");
                da = new OleDbDataAdapter("SElect *from hasta where h_ad like '" + textBox5.Text + "%'", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "hasta");
                dataGridView1.DataSource = ds.Tables["hasta"];
                con.Close();
            
        }
    }
}
