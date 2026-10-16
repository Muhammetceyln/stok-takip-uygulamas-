using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stok_takip_uyg
{
    public partial class SatışListele : Form
    {
        public SatışListele()
        {
            InitializeComponent();
        }

        SqlConnection bağlantı = new SqlConnection("Data Source=Batuhan; Initial Catalog=Stok_takip; Integrated Security=True");
        DataSet daset = new DataSet();

        
        private void SatışListeleme()
        {
            bağlantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from satış", bağlantı);

            adtr.Fill(daset, "satış");
            ekran.DataSource = daset.Tables["satış"];
            ekran.Columns[0].HeaderText = "TC";
            ekran.Columns[1].HeaderText = "Ad Soyad";
            ekran.Columns[2].HeaderText = "Telefon";
            ekran.Columns[3].HeaderText = "Adres";
            ekran.Columns[4].HeaderText = "Ürünün Adı";
            ekran.Columns[5].HeaderText = "Miktar";
            ekran.Columns[6].HeaderText = "Satış Fiyatı";
            ekran.Columns[7].HeaderText = "Toplam Fİyat";
            ekran.Columns[8].HeaderText = "Tarih";


            bağlantı.Close();
        }
        private void SatışListele_Load(object sender, EventArgs e)
        {
            SatışListeleme();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            SatışListeleme();
            // Seçili satırın bilgilerini al
            if (ekran.SelectedRows.Count > 0)
            {
                string barkodno = ekran.SelectedRows[0].Cells["barkodno"].Value.ToString();

                // Veritabanından aynı barkod numarasına sahip satışları sil
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM satış WHERE barkodno = @barkodno", bağlantı);
                komut.Parameters.AddWithValue("@barkodno", barkodno);
                komut.ExecuteNonQuery();
                bağlantı.Close();

                // DataGridView'de satışları güncelle
                daset.Tables["satış"].Clear();
                SatışListeleme();
                MessageBox.Show("Satışlar silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satışı seçin.");
            }
        }
    }
}

