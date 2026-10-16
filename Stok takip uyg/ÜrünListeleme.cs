using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_takip_uyg
{
    public partial class ÜrünListeleme : Form
    {
        public ÜrünListeleme()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=Batuhan; Initial Catalog=Stok_takip; Integrated Security=True");
       DataSet daset = new DataSet();
        bool durum = true;
        
        private void kategorigetir()
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kategoribilgileri", bağlantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combokategori.Items.Add(read["kategori"].ToString());
            }
            bağlantı.Close();
        }
        private void ÜrünListeleme_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            kategorigetir();
        }

        private void ÜrünListele()
        {
            bağlantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT *from urun ", bağlantı);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            bağlantı.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodtxt.Text =dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            kategoritxt.Text =dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            markatxt.Text =dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ürünadıtxt.Text =dataGridView1.CurrentRow.Cells["ürünadı"].Value.ToString();
            miktartxt.Text =dataGridView1.CurrentRow.Cells["miktarı"].Value.ToString();
            alıştxt.Text =dataGridView1.CurrentRow.Cells["alışfiyatı"].Value.ToString();
            satıştxt.Text =dataGridView1.CurrentRow.Cells["satışfiyatı"].Value.ToString();
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            if (barkodtxt.Text=="")
            {
                durum = false;
                MessageBox.Show("Lütfen Geçerli Bir Barkod Giriniz");
            }
            if (durum==true)
            {
                bağlantı.Open();
            SqlCommand komut = new SqlCommand("update urun set kategori=@kategori, marka=@marka, ürünadı=@ürünadı, miktarı=@miktarı, alışfiyatı=@alışfiyatı, satışfiyatı=@satışfiyatı where barkodno=@barkodno", bağlantı);
            komut.Parameters.AddWithValue("@barkodno", barkodtxt.Text);
            komut.Parameters.AddWithValue("@kategori", kategoritxt.Text);
            komut.Parameters.AddWithValue("@marka", markatxt.Text);
            komut.Parameters.AddWithValue("@ürünadı", ürünadıtxt.Text);
            komut.Parameters.AddWithValue("@miktarı", int.Parse(miktartxt.Text));
            komut.Parameters.AddWithValue("@alışfiyatı", double.Parse(alıştxt.Text));
            komut.Parameters.AddWithValue("@satışfiyatı", double.Parse(satıştxt.Text));
            komut.ExecuteNonQuery();
            bağlantı.Close();

            MessageBox.Show("Güncelleme Başarılı");
            daset.Tables["urun"].Clear();
            ÜrünListele();
            

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            }
            
        }


        private void btnMarkaGüncelle_Click(object sender, EventArgs e)
        {
            if (barkodtxt.Text != "")
            {
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,ürünadı=@ürünadı, marka=@marka where barkodno=@barkodno", bağlantı);
                komut.Parameters.AddWithValue("@kategori", combokategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@barkodno", barkodtxt.Text);
                komut.Parameters.AddWithValue("@ürünadı", ürünadıtxt.Text);
                komut.ExecuteNonQuery();
                bağlantı.Close();
                MessageBox.Show("Güncelleme Başarılı");
                daset.Tables["urun"].Clear();
                ÜrünListele();
            }
            else
            {
                MessageBox.Show("BarkodNo Seçili DEĞİL");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM markabilgileri WHERE kategori = @kategori", bağlantı);
            komut.Parameters.AddWithValue("@kategori", combokategori.SelectedItem.ToString());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            bağlantı.Close();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            string barkod = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();

            bağlantı.Open();
            SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM urun WHERE barkodno = @barkod", bağlantı);
            kontrolKomut.Parameters.AddWithValue("@barkod", barkod);
            int urunSayisi = (int)kontrolKomut.ExecuteScalar();
            bağlantı.Close();

            if (urunSayisi > 0)
            {
                DialogResult result = MessageBox.Show("Bu ürünü silmek istediğinizden emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bağlantı.Open();
                    SqlCommand silKomut = new SqlCommand("DELETE FROM urun WHERE barkodno = @barkod", bağlantı);
                    silKomut.Parameters.AddWithValue("@barkod", barkod);
                    silKomut.ExecuteNonQuery();
                    bağlantı.Close();

                    daset.Tables["urun"].Clear();
                    ÜrünListele();
                    MessageBox.Show("Ürün Silindi");
                }
            }
            else
            {
                MessageBox.Show("Silinecek Veri Bulunamadı!");
            }
        }

        private void txtbarkodnoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            bağlantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where barkodno like '%" + txtbarkodnoAra.Text + "%'", bağlantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();
        }

        private void barkodtxt_TextChanged(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno LIKE @barkodno", bağlantı);
            komut.Parameters.AddWithValue("@barkodno", "%" + barkodtxt.Text + "%");
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoritxt.Text = read["kategori"].ToString();
                markatxt.Text = read["marka"].ToString();
                ürünadıtxt.Text = read["ürünadı"].ToString();
                miktartxt.Text = read["miktarı"].ToString();
                alıştxt.Text = read["alışfiyatı"].ToString();
                satıştxt.Text = read["satışfiyatı"].ToString();
            }
            if (barkodtxt.Text == "")
            {
                miktartxt.Text = "";
                foreach (Control item in ÜrünList.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }
            bağlantı.Close();
        }
    }  
}
