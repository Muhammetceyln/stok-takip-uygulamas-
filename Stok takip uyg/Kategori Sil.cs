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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Stok_takip_uyg
{
    public partial class Kategori_Sil : Form
    {
        public Kategori_Sil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Batuhan; Initial Catalog=Stok_takip; Integrated Security=True");

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            combomarka.Items.Clear();
            combomarka.Text = "";

            SqlCommand komut = new SqlCommand("SELECT * FROM markabilgileri WHERE kategori = @kategori", baglanti);
            komut.Parameters.AddWithValue("@kategori", combokategori.SelectedItem.ToString());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combomarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void Kategori_Sil_Load(object sender, EventArgs e)
        {
            kategorigetir();
            markagetir();
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
        private void markagetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combomarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void kategorisil_Click(object sender, EventArgs e)
        {
            
            if (combokategori.SelectedItem != null) // Seçili bir kategori var mı kontrolü
            {
                string secilenKategori = combokategori.SelectedItem.ToString(); // Silinen kategoriyi al
                baglanti.Open();
                // Kategori silme işlemi yap
                SqlCommand komut2 = new SqlCommand("DELETE FROM kategoribilgileri WHERE kategori=@kategori", baglanti);
                komut2.Parameters.AddWithValue("@kategori", secilenKategori);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                // Kategori ComboBox'ını güncelle
                combokategori.Items.Remove(secilenKategori);
                combokategori.SelectedIndex = -1; // Seçili kategoriyi temizle
                MessageBox.Show("Kayıt Silindi");
            }
        }

        private void markasil_Click(object sender, EventArgs e)
        {
            markagetir();
            if (combomarka.SelectedItem != null) // Seçili bir kategori var mı kontrolü
            {

                string secilenmarka = combomarka.SelectedItem.ToString(); // Silinen kategoriyi al
                baglanti.Open();
                // Kategori silme işlemi yap
                SqlCommand komut = new SqlCommand("DELETE FROM markabilgileri WHERE marka=@marka", baglanti);
                komut.Parameters.AddWithValue("@marka", secilenmarka);
                komut.ExecuteNonQuery();
                baglanti.Close();


                // Marka ComboBox'ını güncelle
                combomarka.Items.Clear();
                combomarka.Text = "";

                MessageBox.Show("Kayıt Silindi");
            }
            markagetir();
        }
    }
    
}
