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
    public partial class Müşteri_Listele : Form
    {
        public Müşteri_Listele()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=Batuhan;Initial Catalog=Stok_takip;Integrated Security=True");
        DataSet daset=new DataSet();
        private void Müşteri_Listele_Load(object sender, EventArgs e)
        {
            Kayıtları_Göster();
        }

        private void Kayıtları_Göster()//Kayıtları ekrana yükleme kısmı
        {
            bağlantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from [Müşteri Bilgileri]", bağlantı);
            adtr.Fill(daset, "Müşteri Bilgileri");
            dataGridView1.DataSource = daset.Tables["Müşteri Bilgileri"];
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Telefon";
            dataGridView1.Columns[3].HeaderText = "Adres";
            dataGridView1.Columns[4].HeaderText = "E-mail";
            bağlantı.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//Ekrana Çift tıklama kısmı
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)//Güncelleme yapılan alan
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("update [Müşteri Bilgileri] set adsoyad=@adsoyad, telefon=@telefon, adres=@adres, email=@email where TC=@TC", bağlantı);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@email", txtemail.Text);
            komut.ExecuteNonQuery();
            bağlantı.Close();
            daset.Tables["Müşteri Bilgileri"].Clear();
            Kayıtları_Göster();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("delete from [Müşteri Bilgileri] where TC='" + dataGridView1.CurrentRow.Cells["TC"].Value.ToString() + "'", bağlantı);
            komut.ExecuteNonQuery();
            bağlantı.Close();
            daset.Tables["Müşteri Bilgileri"].Clear(); 
            Kayıtları_Göster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            bağlantı.Open();
            SqlDataAdapter adtr=new SqlDataAdapter("select *from [Müşteri Bilgileri] where tc like '%"+txttcara.Text+"%'",bağlantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();
        }
    }

}
