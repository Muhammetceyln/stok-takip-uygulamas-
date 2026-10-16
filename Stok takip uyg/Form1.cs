using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_takip_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=Batuhan; Initial Catalog=Stok_takip; Integrated Security=True");
        DataSet daset = new DataSet();
        bool durum;
        int stokUyariEsigi = 100;
        private void hesapla()
        {
            try
            {
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat)from sepet", bağlantı);
                lblgeneltop.Text = komut.ExecuteScalar() + "₺";


            }
            catch
            {

            }
            bağlantı.Close();
        }
        private void BarkodKontrol()
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("select*from sepet", bağlantı);
            SqlDataReader reader = komut.ExecuteReader();

            durum = true;
            while (reader.Read())
            {
                if (txtBarkod.Text == reader["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            bağlantı.Close();
        }

        private void SepetListele()
        {
            bağlantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from sepet", bağlantı);

            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            bağlantı.Close();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FRMMüşteriEkle ekle = new FRMMüşteriEkle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Müşteri_Listele listele = new Müşteri_Listele();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ÜrünEkle ekle = new ÜrünEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marka marka = new Marka();
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ÜrünListeleme listele = new ÜrünListeleme();
            listele.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SepetListele();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void textTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                txtAd.Text = "";
                txtTel.Text = "";
            }
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("Select *from [Müşteri Bilgileri] where Tc like '" + txtTC.Text + "' ", bağlantı);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                txtAd.Text = reader["adsoyad"].ToString();
                txtTel.Text = reader["telefon"].ToString();
            }
            bağlantı.Close();
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("Select *from urun where barkodno like '" + txtBarkod.Text + "' ", bağlantı);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                txtÜrünad.Text = reader["ürünadı"].ToString();
                txtSatışF.Text = reader["satışfiyatı"].ToString();
            }
            bağlantı.Close();
        }
        private void Temizle()
        {
            if (txtBarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtÜrünMik)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum == true)
            {
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,ürünadı,miktarı,satışfiyatı,toplamfiyat,tarih) Values (@tc,@adsoyad,@telefon,@barkodno,@ürünadı,@miktarı,@satışfiyatı,@toplamfiyat,@tarih)", bağlantı);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
                komut.Parameters.AddWithValue("@telefon", txtTel.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                komut.Parameters.AddWithValue("@ürünadı", txtÜrünad.Text);
                komut.Parameters.AddWithValue("@miktarı", int.Parse(txtÜrünMik.Text));
                komut.Parameters.AddWithValue("@satışfiyatı", decimal.Parse(txtSatışF.Text));
                komut.Parameters.AddWithValue("@toplamfiyat", decimal.Parse(txtToplamF.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                bağlantı.Close();
            }
            else
            {
                bağlantı.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set miktarı = miktarı+'" + int.Parse(txtÜrünMik.Text) + "'where barkodno='" + txtBarkod.Text + "'", bağlantı);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyat = miktarı * satışfiyatı where barkodno = @barkodno", bağlantı);
                komut3.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                komut3.ExecuteNonQuery();
                bağlantı.Close();
            }
            txtÜrünMik.Text = "1";
            daset.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtÜrünMik)
                    {

                        item.Text = "";
                    }
                }

            }
        }

        private void txtÜrünMik_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamF.Text = (double.Parse(txtÜrünMik.Text) * double.Parse(txtSatışF.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatışF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamF.Text = (double.Parse(txtÜrünMik.Text) * double.Parse(txtSatışF.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", bağlantı);
                komut.ExecuteNonQuery();
                bağlantı.Close();
                MessageBox.Show("Ürün Sepetten Çıkartıldı");

                daset.Tables["sepet"].Clear();
                hesapla();
                SepetListele();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız");
            }


        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("delete from sepet", bağlantı);
                komut.ExecuteNonQuery();

                MessageBox.Show("Ürünler Sepetten Çıkartıldı");
                daset.Tables["sepet"].Clear();
                SepetListele();
                hesapla();
                bağlantı.Close();
            }
            else
            {
                MessageBox.Show("İptal Edilecek İşlem Bulunamadı");
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            SatışListele listele = new SatışListele();
            listele.ShowDialog();

        }
        private bool StokKontrol(string barkodno, int miktar)
        {
            bağlantı.Open();
            SqlCommand kontrolKomut = new SqlCommand("SELECT miktarı FROM urun WHERE barkodno = @barkodno", bağlantı);
            kontrolKomut.Parameters.AddWithValue("@barkodno", barkodno);
            int stokMiktar = (int)kontrolKomut.ExecuteScalar();
            bağlantı.Close();

            if (stokMiktar >= miktar)
            {
                return true; // Stok yeterli, satış yapılabilir.
            }
            else
            {
                return false; // Stok yetersiz, satış yapılamaz.
            }
        }
        private void btnsat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bağlantı.Open();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string barkodno = row.Cells["barkodno"].Value.ToString();
                    int miktar = int.Parse(row.Cells["miktarı"].Value.ToString());
                    // Ürünün stok miktarını kontrol et
                    int stokMiktari = 0;
                    SqlCommand stokKomut = new SqlCommand("SELECT miktarı FROM urun WHERE barkodno = @barkodno", bağlantı);
                    stokKomut.Parameters.AddWithValue("@barkodno", barkodno);
                    SqlDataReader stokReader = stokKomut.ExecuteReader();
                    if (stokReader.Read())
                    {
                        stokMiktari = int.Parse(stokReader["miktarı"].ToString());
                    }
                    stokReader.Close();
                    // Eğer stok miktarı uygunsa satış işlemini yap
                    if (stokMiktari >= miktar)
                    {
                        // Stok miktarını güncelle
                        SqlCommand komut2 = new SqlCommand("UPDATE urun SET miktarı = miktarı - @miktarı WHERE barkodno = @barkodno", bağlantı);
                        komut2.Parameters.AddWithValue("@miktarı", miktar);
                        komut2.Parameters.AddWithValue("@barkodno", barkodno);
                        komut2.ExecuteNonQuery();
                        // satış tablosunu veri ekleme
                        SqlCommand komut = new SqlCommand("INSERT INTO satış(tc, adsoyad, telefon, barkodno, ürünadı, miktarı, satışfiyatı, toplamfiyat, tarih) VALUES (@tc, @adsoyad, @telefon, @barkodno, @ürünadı, @miktarı, @satışfiyatı, @toplamfiyat, @tarih)", bağlantı);
                        komut.Parameters.AddWithValue("@tc", txtTC.Text);
                        komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
                        komut.Parameters.AddWithValue("@telefon", txtTel.Text);
                        komut.Parameters.AddWithValue("@barkodno", barkodno);
                        komut.Parameters.AddWithValue("@ürünadı", row.Cells["ürünadı"].Value.ToString());
                        komut.Parameters.AddWithValue("@miktarı", miktar);
                        komut.Parameters.AddWithValue("@satışfiyatı", decimal.Parse(row.Cells["satışfiyatı"].Value.ToString()));
                        komut.Parameters.AddWithValue("@toplamfiyat", decimal.Parse(row.Cells["toplamfiyat"].Value.ToString()));
                        komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                        komut.ExecuteNonQuery();
                        // Sepetten ürünü kaldır
                        SqlCommand komut3 = new SqlCommand("DELETE FROM sepet WHERE barkodno = @barkodno", bağlantı);
                        komut3.Parameters.AddWithValue("@barkodno", barkodno);
                        komut3.ExecuteNonQuery();
                        // Güncellenen stok miktarını kontrol et
                        int güncellenenStokMiktari = 0;
                        SqlCommand güncellenenStokKomut = new SqlCommand("SELECT miktarı FROM urun WHERE barkodno = @barkodno", bağlantı);
                        güncellenenStokKomut.Parameters.AddWithValue("@barkodno", barkodno);
                        SqlDataReader güncellenenStokReader = güncellenenStokKomut.ExecuteReader();
                        if (güncellenenStokReader.Read())
                        {  güncellenenStokMiktari = int.Parse(güncellenenStokReader["miktarı"].ToString());}
                        güncellenenStokReader.Close();
                        // Eğer güncellenen stok miktarı stokUyariEsigi'nden düşükse uyarı mesajı göster
                        if (güncellenenStokMiktari < stokUyariEsigi)
                        { MessageBox.Show($"Ürün stokları {stokUyariEsigi} den daha az kaldı. Güncellenen stok miktarı: {güncellenenStokMiktari}", "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                    }
                    else
                    { MessageBox.Show($"Stokta yeterli ürün bulunmamaktadır. Stok miktarı: {stokMiktari}", "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                bağlantı.Close();
                //sepeti temizle
                daset.Tables["sepet"].Clear();
                SepetListele();
                hesapla();
            }
            else
            {
                MessageBox.Show("Lütfen satış yapılacak ürünü seçin.");
            }
        }


        private void kategorisil_Click(object sender, EventArgs e)
        {

            Kategori_Sil sil = new Kategori_Sil();
            sil.ShowDialog();
        }
    }

}
