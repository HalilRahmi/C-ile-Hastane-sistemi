using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=kayit.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        void ilEkle()
        {
            DataTable dt = new DataTable();
            da = new OleDbDataAdapter("select * from iller ", baglanti);
            da.Fill(dt);
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "ilAdi";
            comboBox1.DataSource = dt;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select ilceAdi From ilceler Where ilid=" + comboBox1.SelectedValue;
            OleDbDataReader oku;
            oku = komut.ExecuteReader();
            comboBox2.Items.Clear();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }

        // Kişileri listelemek için metot oluşturuyoruz.
        void KisiListele()
        {

            baglanti.Open();
            da = new OleDbDataAdapter("Select *From poli", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }



        //For yüklendiğinde metodu çağırıyoruz.
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kayitDataSet.poli' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.poliTableAdapter.Fill(this.kayitDataSet.poli);
            // TODO: Bu kod satırı 'kayitDataSet.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.kayitDataSet.ilceler);

            KisiListele();
            ilEkle();
        }

        

        


       
       

        //Datagrid' de tıklanan satıra ait değerlerin textBox' larda görüntülenmesini sağlıyoruz.
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                int kayitSayisi;
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT COUNT(*) FROM poli";
                kayitSayisi = (int)
                komut.ExecuteScalar();
                baglanti.Close();
                MessageBox.Show(kayitSayisi.ToString());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                string sorgu = "Update Personel Set il=@il,ilce=@ilce,hast_ad=@ad Where h_no=@no";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@il", comboBox1.Text);
                komut.Parameters.AddWithValue("@ilce", comboBox2.Text);
                komut.Parameters.AddWithValue("@ad", textBox4.Text);
                komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox1.Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KisiListele();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Silme işlemi
           
                string sorgu = "Delete From poli Where Numara=@no";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.CommandText = "delete from hasta where h_no=" + textBox1.Text + "";
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KisiListele();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into poli (h_no,il,ilce,hast_ad) values (@no,@il,@ilce,@ad)";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@il", comboBox1.Text);
            komut.Parameters.AddWithValue("@ilce", comboBox2.Text);
            komut.Parameters.AddWithValue("@ad", textBox4.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }
    }
}
