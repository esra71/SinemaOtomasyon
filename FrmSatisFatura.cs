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
    public partial class FrmSatisFatura : Form
    {
        public FrmSatisFatura()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Satis_Fatura.ID,Calisanlar.CalisanAd,Satis_Fatura.Tarih,Musteri.MusteriAd,Bilet.AdetSayısı,Fiyat,Tutar from Satis_Fatura inner join Calisanlar on Satis_Fatura.CalisanlarID=Calisanlar.ID inner join Musteri on Satis_Fatura.MusteriID=Musteri.ID inner join Bilet on Satis_Fatura.BiletID=Bilet.BiletId ", bgl.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void calisanListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,CalisanAd,CalisanSoyad,Görev From Calisanlar", bgl.Baglanti());
            da.Fill(dt);
            lookCalisan.Properties.NullText = "Lütfen bir Çalışan adı seçiniz";
            lookCalisan.Properties.ValueMember = "ID";
            lookCalisan.Properties.DisplayMember = "CalisanAd";
            lookCalisan.Properties.DataSource = dt;
        }
        void musteriListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,MusteriAd,MusteriSoyad From Musteri", bgl.Baglanti());
            da.Fill(dt);
            lookMusteri.Properties.NullText = "Lütfen bir Müşteri adı seçiniz";
            lookMusteri.Properties.ValueMember = "ID";
            lookMusteri.Properties.DisplayMember = "MusteriAd";
            lookMusteri.Properties.DataSource = dt;
        }
        void biletListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BiletId,AdetSayısı From Bilet", bgl.Baglanti());
            da.Fill(dt);
            lookBilet.Properties.NullText = "Lütfen biletin adet sayısını seçiniz";
            lookBilet.Properties.ValueMember = "BiletId";
            lookBilet.Properties.DisplayMember = "AdetSayısı";
            lookBilet.Properties.DataSource = dt;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtekle = new SqlCommand("insert into Satis_Fatura (CalisanlarID,Tarih,MusteriID,BiletID,Fiyat,Tutar) values (@a1,@a2,@a3,@a4,@a5,@a6)", bgl.Baglanti());
            kmtekle.Parameters.AddWithValue("@a1", lookCalisan.EditValue);
            kmtekle.Parameters.AddWithValue("@a2", mskTarih.Text);
            kmtekle.Parameters.AddWithValue("@a3", lookMusteri.EditValue);
            kmtekle.Parameters.AddWithValue("@a4", lookBilet.EditValue);
            kmtekle.Parameters.AddWithValue("@a5", txtFiyat.Text);
            kmtekle.Parameters.AddWithValue("@a6", txtTutar.Text);
            kmtekle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Yeni Fatura Bilgisi Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        
        private void FrmSatisFatura_Load(object sender, EventArgs e)
        {
            calisanListele();
            musteriListele();
            biletListele();
            listele();
        }

       

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                lookCalisan.Text = dr["CalisanAd"].ToString();
                mskTarih.Text = dr["Tarih"].ToString();
                lookMusteri.Text = dr["MusteriAd"].ToString();
                lookBilet.Text = dr["AdetSayısı"].ToString();
                txtFiyat.Text = dr["Fiyat"].ToString();
                txtTutar.Text = dr["Tutar"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            lookCalisan.EditValue = "";
            mskTarih.Text = "";
            lookMusteri.EditValue = "";
            lookBilet.EditValue = "";
            txtFiyat.Text = "";
            txtTutar.Text = "";
            lookCalisan.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmtsil = new SqlCommand("Delete From Satis_Fatura where ID=@b1", bgl.Baglanti());
            kmtsil.Parameters.AddWithValue("@b1", txtId.Text);
            kmtsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Fatura Bilgileri Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtguncelle = new SqlCommand("Update Satis_Fatura set CalisanlarID=@c1,Tarih=@c2,MusteriID=@c3,BiletID=@c4,Fiyat=@c5,Tutar=@c6 where ID=@c7", bgl.Baglanti());
            kmtguncelle.Parameters.AddWithValue("@c1", lookCalisan.EditValue);
            kmtguncelle.Parameters.AddWithValue("@c2", mskTarih.Text);
            kmtguncelle.Parameters.AddWithValue("@c3", lookMusteri.EditValue);
            kmtguncelle.Parameters.AddWithValue("@c4", lookBilet.EditValue);
            kmtguncelle.Parameters.AddWithValue("@c5", txtFiyat.Text);
            kmtguncelle.Parameters.AddWithValue("@c6", txtTutar.Text);
            kmtguncelle.Parameters.AddWithValue("@c7", txtId.Text);
            kmtguncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Fatura Bilgileri Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
