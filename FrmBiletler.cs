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

namespace SinemaOtomasyon
{
    public partial class FrmBiletler : Form
    {
        public FrmBiletler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BiletId, AdetSayısı,Filmler.FilmAdı,Salonlar.SalonAdı,Seans.Saat,Bilet.Tarih,KoltukNo from Bilet inner join Filmler on Bilet.FilmlerID=Filmler.ID inner join Salonlar on Bilet.SalonlarID=Salonlar.ID inner join Seans on Bilet.SeansID=Seans.ID", bgl.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
       
        void filmListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,FilmAdı From Filmler", bgl.Baglanti());
            da.Fill(dt);
            lookFilm.Properties.NullText = "Lütfen bir Film adı seçiniz";
            lookFilm.Properties.ValueMember = "ID";
            lookFilm.Properties.DisplayMember = "FilmAdı";
            lookFilm.Properties.DataSource = dt;
        }
        void salonListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,SalonAdı,SinemaAdı From Salonlar", bgl.Baglanti());
            da.Fill(dt);
            lookSalon.Properties.NullText = "Lütfen bir Salon adı seçiniz";
            lookSalon.Properties.ValueMember = "ID";
            lookSalon.Properties.DisplayMember = "SalonAdı";
            lookSalon.Properties.DataSource = dt;
        }
        void seansListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,Saat From Seans", bgl.Baglanti());
            da.Fill(dt);
            lookSeans.Properties.NullText = "Lütfen bir Saat seçiniz";
            lookSeans.Properties.ValueMember = "ID";
            lookSeans.Properties.DisplayMember = "Saat";
            lookSeans.Properties.DataSource = dt;
        }
        private void FrmBiletler_Load(object sender, EventArgs e)
        {
            filmListele();
            salonListele();
            seansListele();
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            SqlCommand kmtekle = new SqlCommand("insert into Bilet (AdetSayısı,FilmlerID,SalonlarID,SeansID,Tarih,KoltukNo) values (@a1,@a2,@a3,@a4,@a5,@a6)", bgl.Baglanti());
            kmtekle.Parameters.AddWithValue("@a1", txtAdetsayisi.Text);
            kmtekle.Parameters.AddWithValue("@a2", lookFilm.EditValue);
            kmtekle.Parameters.AddWithValue("@a3", lookSalon.EditValue);
            kmtekle.Parameters.AddWithValue("@a4", lookSeans.EditValue);
            kmtekle.Parameters.AddWithValue("@a5", mskTarih.Text);
            kmtekle.Parameters.AddWithValue("@a6", txtKoltuk.Text);
            kmtekle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Yeni Bilet Bilgisi Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmtsil = new SqlCommand("Delete From Bilet where BiletId=@b1", bgl.Baglanti());
            kmtsil.Parameters.AddWithValue("@b1", txtId.Text);
            kmtsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Bilet Bilgileri Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["BiletId"].ToString();
                txtAdetsayisi.Text = dr["AdetSayısı"].ToString();
                lookFilm.Text = dr["FilmAdı"].ToString();
                lookSalon.Text = dr["SalonAdı"].ToString();
                lookSeans.Text = dr["Saat"].ToString();
                mskTarih.Text = dr["Tarih"].ToString();
                txtKoltuk.Text = dr["KoltukNo"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtAdetsayisi.Text = "";
            lookFilm.EditValue = "";
            lookSalon.EditValue = "";
            lookSeans.EditValue = "";
            mskTarih.Text = "";
            txtKoltuk.Text = "";
            txtAdetsayisi.Focus();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtguncelle = new SqlCommand("Update Bilet set AdetSayısı=@c1,FilmlerID=@c2,SalonlarID=@c3,SeansID=@c4,Tarih=@c5,KoltukNo=@c6 where BiletId=@c7", bgl.Baglanti());
            kmtguncelle.Parameters.AddWithValue("@c1", txtAdetsayisi.Text);
            kmtguncelle.Parameters.AddWithValue("@c2", lookFilm.EditValue);
            kmtguncelle.Parameters.AddWithValue("@c3", lookSalon.EditValue);
            kmtguncelle.Parameters.AddWithValue("@c4", lookSeans.EditValue);
            kmtguncelle.Parameters.AddWithValue("@c5", mskTarih.Text);
            kmtguncelle.Parameters.AddWithValue("@c6", txtKoltuk.Text);
            kmtguncelle.Parameters.AddWithValue("@c7", txtId.Text);
            kmtguncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Bilet Bilgileri Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
