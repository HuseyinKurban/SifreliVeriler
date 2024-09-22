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

namespace SifreliVeriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-32Q9FH5;Initial Catalog=Test;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        void listele()
        {
            baglanti.Open();
            DataTable dt = new DataTable();

            // Sütunları tanımla
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("Mail");
            dt.Columns.Add("Sifre");
            dt.Columns.Add("HesapNo");

            SqlCommand komut = new SqlCommand("Select AD, SOYAD, MAIL, SIFRE, HESAPNO From TBLVERILER", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                DataRow row = dt.NewRow();

                string adcozum = dr[0].ToString(); // AD sütunu 0. indeks
                byte[] adcozumdizi = Convert.FromBase64String(adcozum);
                row["Ad"] = Encoding.UTF8.GetString(adcozumdizi); // UTF-8 kullanıldı

                string soyadcozum = dr[1].ToString(); // SOYAD sütunu 1. indeks
                byte[] soyadcozumdizi = Convert.FromBase64String(soyadcozum);
                row["Soyad"] = Encoding.UTF8.GetString(soyadcozumdizi); // UTF-8 kullanıldı

                string mailcozum = dr[2].ToString(); // MAIL sütunu 2. indeks
                byte[] mailcozumdizi = Convert.FromBase64String(mailcozum);
                row["Mail"] = Encoding.UTF8.GetString(mailcozumdizi); // UTF-8 kullanıldı

                string sifrecozum = dr[3].ToString(); // SIFRE sütunu 3. indeks
                byte[] sifrecozumdizi = Convert.FromBase64String(sifrecozum);
                row["Sifre"] = Encoding.UTF8.GetString(sifrecozumdizi); // UTF-8 kullanıldı

                string hesapnocozum = dr[4].ToString(); // HESAPNO sütunu 4. indeks
                byte[] hesapnocozumdizi = Convert.FromBase64String(hesapnocozum);
                row["HesapNo"] = Encoding.UTF8.GetString(hesapnocozumdizi); // UTF-8 kullanıldı

                dt.Rows.Add(row);
            }


            dataGridView1.DataSource = dt; // DataGridView'e veri kaynağı atanıyor
            baglanti.Close();
        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {

            //Encoding.UTF8 kullanırsanız türkçe karakterler gözükür
            string ad = txtad.Text;
            byte[] addizi = Encoding.UTF8.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string soyad = txtsoyad.Text;
            byte[] soyaddizi = Encoding.UTF8.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string mail = txtmail.Text;
            byte[] maildizi = Encoding.UTF8.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = txtsifre.Text;
            byte[] sifredizi = Encoding.UTF8.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string hesapno = txthesapno.Text;
            byte[] hesapnodizi = Encoding.UTF8.GetBytes(hesapno);
            string hesapnosifre = Convert.ToBase64String(hesapnodizi);


            // ASCIIEncoding.ASCII kullanırsanız veri okudugunda  türkçe harfler ? işareti cıkar
            //string ad = txtad.Text;
            //byte[] addizi = ASCIIEncoding.ASCII.GetBytes(ad);
            //string adsifre = Convert.ToBase64String(addizi);

            //string soyad = txtsoyad.Text;
            //byte[] soyaddizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            //string soyadsifre = Convert.ToBase64String(soyaddizi);

            //string mail = txtmail.Text;
            //byte[] maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
            //string mailsifre = Convert.ToBase64String(maildizi);

            //string sifre = txtsifre.Text;
            //byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            //string sifresifre = Convert.ToBase64String(sifredizi);

            //string hesapno = txthesapno.Text;
            //byte[] hesapnodizi = ASCIIEncoding.ASCII.GetBytes(hesapno);
            //string hesapnosifre = Convert.ToBase64String(hesapnodizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifresifre);
            komut.Parameters.AddWithValue("@p5", hesapnosifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Eklendi", "Bilgi");

            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnsifrecoz_Click(object sender, EventArgs e)
        {
            //string adcozum = txtad.Text;
            //byte[] adcozumdizi = Convert.FromBase64String(adcozum);
            //string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizi);

            //string soyadcozum = txtsoyad.Text;
            //byte[] soyadcozumdizi = Convert.FromBase64String(soyadcozum);
            //string soyadverisi = ASCIIEncoding.ASCII.GetString(soyadcozumdizi);

            //string mailcozum = txtmail.Text;
            //byte[] mailcozumdizi = Convert.FromBase64String(mailcozum);
            //string mailverisi = ASCIIEncoding.ASCII.GetString(mailcozumdizi);

            //string sifrecozum = txtsifre.Text;
            //byte[] sifrecozumdizi = Convert.FromBase64String(sifrecozum);
            //string sifreverisi = ASCIIEncoding.ASCII.GetString(sifrecozumdizi);

            //string hesapnocozum = txtmail.Text;
            //byte[] hesapnocozumdizi = Convert.FromBase64String(hesapnocozum);
            //string hesapnoverisi = ASCIIEncoding.ASCII.GetString(hesapnocozumdizi);


            //// Ad çözümleme
            //string adcozum = txtad.Text;
            //byte[] adcozumdizi = Convert.FromBase64String(adcozum);
            //string adverisi = Encoding.UTF8.GetString(adcozumdizi);

            //// Soyad çözümleme
            //string soyadcozum = txtsoyad.Text;
            //byte[] soyadcozumdizi = Convert.FromBase64String(soyadcozum);
            //string soyadverisi = Encoding.UTF8.GetString(soyadcozumdizi);

            //// Mail çözümleme
            //string mailcozum = txtmail.Text;
            //byte[] mailcozumdizi = Convert.FromBase64String(mailcozum);
            //string mailverisi = Encoding.UTF8.GetString(mailcozumdizi);

            //// Şifre çözümleme
            //string sifrecozum = txtsifre.Text;
            //byte[] sifrecozumdizi = Convert.FromBase64String(sifrecozum);
            //string sifreverisi = Encoding.UTF8.GetString(sifrecozumdizi);

            //// Hesap No çözümleme
            //string hesapnocozum = txthesapno.Text; // Doğru kontrol edin
            //byte[] hesapnocozumdizi = Convert.FromBase64String(hesapnocozum);
            //string hesapnoverisi = Encoding.UTF8.GetString(hesapnocozumdizi);

            //çözmek istediğin
            string cozum = txtcozum.Text;
            byte[] cozumdizi = Convert.FromBase64String(cozum);
            string cozumverisi = Encoding.UTF8.GetString(cozumdizi);
            txtcozulmusveri.Text = cozumverisi;

        }
    }
}
