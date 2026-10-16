using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stok_takip_uyg
{
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Batuhan; Initial Catalog=Stok_takip; Integrated Security=True");
        bool durum = true;

        private void BarkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (txtbarkodno.Text == reader["barkodno"].ToString() || txtbarkodno.Text == "")
                    {
                        durum = false;
                    }
                }
            }
            baglanti.Close();
        }

        private void kategorigetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combokategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void ÜrünEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            
            SqlCommand komut = new SqlCommand("SELECT * FROM markabilgileri WHERE kategori = @kategori", baglanti);
            komut.Parameters.AddWithValue("@kategori", combokategori.SelectedItem.ToString());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void yeniekle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO urun (barkodno, kategori, marka, ürünadı, miktarı, alışfiyatı, satışfiyatı, tarih) VALUES (@barkodno, @kategori, @marka, @ürünadı, @miktarı, @alışfiyatı, @satışfiyatı, @tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@kategori", combokategori.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@marka", comboMarka.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@ürünadı", txtÜrünadı.Text);
                komut.Parameters.AddWithValue("@miktarı", int.Parse(txtmiktar.Text));
                komut.Parameters.AddWithValue("@alışfiyatı", double.Parse(txtalış.Text));
                komut.Parameters.AddWithValue("@satışfiyatı", double.Parse(txtsatış.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();               
                MessageBox.Show("Ürün Eklendi");
                comboMarka.Text = "";
                combokategori.Text = "";
                txtÜrünadı.Text = "";
                txtmiktar.Text = "";
                txtalış.Text = "";
                txtsatış.Text = "";
            }
            else
            {
                MessageBox.Show("Böyle Bir BarkodNO Zaten Var Yenisi Girin");
            }   txtbarkodno.Text = "";
            baglanti.Close();
        }

        private void barkodtxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno LIKE @barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", "%" + barkodtxt.Text + "%");
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoritxt.Text = read["kategori"].ToString();
                markatxt.Text = read["marka"].ToString();
                ürünadıtxt.Text = read["ürünadı"].ToString();
                lblmiktar.Text = read["miktarı"].ToString();
                alıştxt.Text = read["alışfiyatı"].ToString();
                satıştxt.Text = read["satışfiyatı"].ToString();
            }
            if (barkodtxt.Text == "")
            {
                lblmiktar.Text = "";
                Temizle();
            }baglanti.Close();
        }

        private void VarolanaEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE urun SET miktarı = miktarı+ '" + int.Parse(miktartxt.Text) + "'where barkodno='" + barkodtxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Temizle();
            MessageBox.Show("Var Olana Ekleme Yapıldı");
        }

        private void Temizle()
        {
            foreach (Control item in grpOlan.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
