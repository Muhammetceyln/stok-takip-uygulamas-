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

namespace Stok_takip_uyg
{
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source = Batuhan; Initial Catalog = Stok_takip; Integrated Security = True");
        bool durum = true;
        private void kategoriengelle()
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", bağlantı);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (textBox1.Text == reader["kategori"].ToString())
                {
                    durum = false;
                    MessageBox.Show("Böyle Bir Kategori Zaten Var");
                }

            }
            if (textBox1.Text == "")
            {
                durum = false;
                MessageBox.Show("Boş Kategori Eklenemez");
            }
            bağlantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum == true)
            {
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) Values('" + textBox1.Text + "')", bağlantı);
                komut.ExecuteNonQuery();
                bağlantı.Close();

                MessageBox.Show("Kategori Eklendi");
            }
            textBox1.Text = "";
        }
    }
}
