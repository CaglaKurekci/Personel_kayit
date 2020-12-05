using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_kayit
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        public void Temizle()
        {
       
            txtAd.Text = "";
            txtSoyad.Text = "";
            CmbSehir.Text = "";
            Mskmaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMeslek.Text = "";
            txtAd.Focus();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CAGLA\\SQLEXPRESS;Initial Catalog=Personelveritabani;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelveritabaniDataSet.Tbl_Personel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel(PerAd,PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", Mskmaas.Text);
            komut.Parameters.AddWithValue("@p5", label8.Text);
            komut.Parameters.AddWithValue("@p6", txtMeslek.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Başarıyla eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", CmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", Mskmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", Txtid.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla güncellennmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Personel where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi!");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
              label8.Text = "false";
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelveritabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelveritabaniDataSet.Tbl_Personel);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Mskmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
               label8.Text = "true";
            }
          
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "true")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "false") 
            
            {
                radioButton2.Checked = true;

            }
        }

        private void btnist_Click(object sender, EventArgs e)
        {
            Frmistatistik frm = new Frmistatistik();

            frm.Show();
            
        }

        private void btnGraf_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm1 = new FrmGrafikler();
            frm1.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
