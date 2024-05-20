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

namespace Otomasyon
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\SporDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || TelefonTb.Text == "" || OdemeTb.Text == "" || YasTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into UyeTbl values('" + AdSoyadTb.Text + "','" + TelefonTb.Text + "','" + CinsiyetCb.SelectedItem.ToString() + "','" + YasTb.Text + "','" + OdemeTb.Text + "','" + ZamanlamaCb.SelectedItem.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Eklendi");
                    baglanti.Close();
                    AdSoyadTb.Text = "";
                    TelefonTb.Text = "";
                    CinsiyetCb.Text = "";
                    YasTb.Text = "";
                    OdemeTb.Text = "";
                    ZamanlamaCb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            CinsiyetCb.Text = "";
            YasTb.Text = "";
            OdemeTb.Text = "";
            ZamanlamaCb.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa= new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
