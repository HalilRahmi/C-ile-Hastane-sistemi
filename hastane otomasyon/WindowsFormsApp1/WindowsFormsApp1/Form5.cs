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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=kayit.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();

        void KisiListele()
        {

            baglanti.Open();
            da = new OleDbDataAdapter("Select *From servis", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }


        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kayitDataSet1.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter.Fill(this.kayitDataSet1.hasta);
            // TODO: Bu kod satırı 'kayitDataSet1.servis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.servisTableAdapter.Fill(this.kayitDataSet1.servis);
            KisiListele();
        }

       

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
       

        

        

        private void button1_Click(object sender, EventArgs e)
        {

            string sorgu = "Insert into servis (h_no,servis,dr,tarih,saat) values (@no,@ser,@dr,@tar,@sat)";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@servis", comboBox1.Text);
            komut.Parameters.AddWithValue("@dr", textBox2.Text);
            komut.Parameters.AddWithValue("@tar", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@sar", textBox3.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From servis Where Numara=@no";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.CommandText = "delete from servis where h_no=" + textBox1.Text + "";
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                string sorgu = "Update Personel Set servis=@ser,dr=@dr,tarih=@tar,saat=@sat Where h_no=@no";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox1.Text));
                komut.Parameters.AddWithValue("@servis", comboBox1.Text);
                komut.Parameters.AddWithValue("@dr", textBox2.Text);
                komut.Parameters.AddWithValue("@tar", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@sat", textBox3.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KisiListele();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                int kayitSayisi;
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT COUNT(*) FROM servis";
                kayitSayisi = (int)
                komut.ExecuteScalar();
                baglanti.Close();
                MessageBox.Show(kayitSayisi.ToString());
            
        }
    }
}
