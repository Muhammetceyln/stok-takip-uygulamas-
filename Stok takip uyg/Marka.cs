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


namespace Stok_takip_uyg
{
    public partial class Marka : Form
    {
        public Marka()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source = Batuhan; Initial Catalog = Stok_takip; Integrated Security = True");
        bool durum = true;
        private void markakontrol()

        {
            durum = true;
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri", bağlantı);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (comboBox1.Text == reader["Kategori"].ToString() && textBox1.Text == reader["marka"].ToString() || textBox1.Text == "" || comboBox1.Text == "")
                {
                    durum = false;
                }
            }
            bağlantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum == true)
            {
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("insert into  markabilgileri (kategori,marka) Values('" + comboBox1.Text + "','" + textBox1.Text + "')", bağlantı);

                komut.ExecuteNonQuery();
                bağlantı.Close();

                MessageBox.Show("Marka Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori ve Marka Zaten Var");
            }
            textBox1.Text = "";
            comboBox1.Text = "";
        }
        private void kategorigetir()
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("Select *from kategoribilgileri", bağlantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            bağlantı.Close();
        }
        private void Marka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

 
    }
}
