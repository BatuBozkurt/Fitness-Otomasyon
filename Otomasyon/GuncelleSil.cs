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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Otomasyon
{
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\SporDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;

        private void UyeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(UyeDGV.SelectedRows[0].Cells[0].Value.ToString());
            AdSoyadTb.Text = UyeDGV.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = UyeDGV.SelectedRows[0].Cells[2].Value.ToString();
            YasTb.Text = UyeDGV.SelectedRows[0].Cells[3].Value.ToString();
            OdemeTb.Text = UyeDGV.SelectedRows[0].Cells[4].Value.ToString();
            ZamanlamaCb.Text = UyeDGV.SelectedRows[0].Cells[5].Value.ToString();
            CinsiyetCb.Text = UyeDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Üyeyi Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from where UId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla silindi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || AdSoyadTb.Text == "" || TelefonTb.Text == "" || OdemeTb.Text == "" || YasTb.Text == "" || ZamanlamaCb.Text== "" || CinsiyetCb.Text=="")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update UyeTbl set UAdSoyad='" + AdSoyadTb.Text + "',UTelefon='" + TelefonTb.Text + "',UOdeme ='" + OdemeTb.Text + "',UCinsiyet='" + CinsiyetCb.Text + "',UYas='" + YasTb.Text + "',UZamanlama='" + ZamanlamaCb.Text + "' where UId=+"+ key +";";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
