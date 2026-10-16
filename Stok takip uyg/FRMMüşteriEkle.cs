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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stok_takip_uyg
{
    public partial class FRMMüşteriEkle : Form
    {
        public FRMMüşteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=Batuhan;Initial Catalog=Stok_takip;Integrated Security=True");

        bool durum = true;
        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlara izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Karakter sayısı 11'i geçmesin
            if (txtTC.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TCengelle()
        {
            
                durum = true;
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM [Müşteri Bilgileri]", bağlantı);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    if (txtTC.Text == reader["tc"].ToString()  )
                    {
                        durum = false;
                      MessageBox.Show("Böyle Bir Müşteri Zaten Var", "Uyarı");
                    }
                }
                if (durum == string.IsNullOrEmpty(txtadsoyad.Text) || string.IsNullOrEmpty(txttelefon.Text) ||
                        string.IsNullOrEmpty(txtadres.Text) || string.IsNullOrEmpty(txtemail.Text)||txtTC.Text=="")
                {
                    durum=false;
                    MessageBox.Show("Bilgileri Eksiksiz Girdiğinizden Emin Olun");
                }
                bağlantı.Close();
        }
        
        private void eklebtn_Click(object sender, EventArgs e)
        {
            TCengelle();
            if (txtTC.Text.Length != 11)
            {
                MessageBox.Show("TC numarası 11 haneli olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txttelefon.Text.Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 haneli olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                 if (durum==true)
                 {
                    bağlantı.Open();
                    SqlCommand komut = new SqlCommand("insert into [Müşteri Bilgileri] (tc,adsoyad,telefon,adres,email)values(@tc,@adsoyad,@telefon,@adres,@email)", bağlantı);
                    komut.Parameters.AddWithValue("@tc", txtTC.Text);
                    txtadsoyad.Focus();
                    komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                    txttelefon.Focus();
                    komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                    komut.Parameters.AddWithValue("@adres", txtadres.Text);
                    komut.Parameters.AddWithValue("@email", txtemail.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Bilgileri Kayıt Edildi.");
                    bağlantı.Close();
                    txtTC.Text = "";
                    txtemail.Text = "";
                    txtadres.Text = "";
                    txtadsoyad.Text = "";
                    txttelefon.Text = "";
                 }
            }
        }
    }   
}
