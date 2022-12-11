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
    public partial class FrmCalisanlar : Form
    {
        public FrmCalisanlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Calisanlar", bgl.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        
        void sehirListesi()
        {
            SqlCommand kmt = new SqlCommand("Select Sehir From Iller", bgl.Baglanti());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cbxil.Properties.Items.Add(dr[0]);
            }
            bgl.Baglanti().Close();
        }

        private void cbxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxilce.Properties.Items.Clear();
            SqlCommand kmt = new SqlCommand("Select Ilce From Ilceler where Sehir=@a1", bgl.Baglanti());
            kmt.Parameters.AddWithValue("@a1", cbxil.SelectedIndex + 1);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cbxilce.Properties.Items.Add(dr[0]);
            }
            bgl.Baglanti().Close();
        }

        private void FrmCalisanlar_Load(object sender, EventArgs e)
        {
            sehirListesi();
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtekle = new SqlCommand("insert into Calisanlar (CalisanAd,CalisanSoyad,Telefon,TC,Mail,İl,İlce,Adres,Görev) values (@b1,@b2,@b3,@b4,@b5,@b6,@b7,@b8,@b9)", bgl.Baglanti());
            kmtekle.Parameters.AddWithValue("@b1", txtAd.Text);
            kmtekle.Parameters.AddWithValue("@b2", txtSoyad.Text);
            kmtekle.Parameters.AddWithValue("@b3", mskTelefon.Text);
            kmtekle.Parameters.AddWithValue("@b4", mskTC.Text);
            kmtekle.Parameters.AddWithValue("@b5", txtMail.Text);
            kmtekle.Parameters.AddWithValue("@b6", cbxil.Text);
            kmtekle.Parameters.AddWithValue("@b7", cbxilce.Text);
            kmtekle.Parameters.AddWithValue("@b8", rtxtAdres.Text);
            kmtekle.Parameters.AddWithValue("@b9", txtGorev.Text);
            kmtekle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Yeni Çalışan Bilgileri Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["CalisanAd"].ToString();
                txtSoyad.Text = dr["CalisanSoyad"].ToString();
                mskTelefon.Text = dr["Telefon"].ToString();
                mskTC.Text = dr["TC"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                cbxil.Text = dr["İl"].ToString();
                cbxilce.Text = dr["İlce"].ToString();
                rtxtAdres.Text = dr["Adres"].ToString();
                txtGorev.Text = dr["Görev"].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmtsil = new SqlCommand("Delete From Calisanlar where ID=@c1", bgl.Baglanti());
            kmtsil.Parameters.AddWithValue("@c1", txtID.Text);
            kmtsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Çalışan Bilgileri Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtguncelle = new SqlCommand("Update Calisanlar set CalisanAd=@d1,CalisanSoyad=@d2,Telefon=@d3,TC=@d4,Mail=@d5,İl=@d6,İlce=@d7,Adres=@d8,Görev=@d9 where ID=@d10", bgl.Baglanti());
            kmtguncelle.Parameters.AddWithValue("@d1", txtAd.Text);
            kmtguncelle.Parameters.AddWithValue("@d2", txtSoyad.Text);
            kmtguncelle.Parameters.AddWithValue("@d3", mskTelefon.Text);
            kmtguncelle.Parameters.AddWithValue("@d4", mskTC.Text);
            kmtguncelle.Parameters.AddWithValue("@d5", txtMail.Text);
            kmtguncelle.Parameters.AddWithValue("@d6", cbxil.Text);
            kmtguncelle.Parameters.AddWithValue("@d7", cbxilce.Text);
            kmtguncelle.Parameters.AddWithValue("@d8", rtxtAdres.Text);
            kmtguncelle.Parameters.AddWithValue("@d9", txtGorev.Text);
            kmtguncelle.Parameters.AddWithValue("@d10", txtID.Text);
            kmtguncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Çalışan Bilgileri Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTelefon.Text = "";
            mskTC.Text = "";
            txtMail.Text = "";
            cbxil.Text = "";
            cbxilce.Text = "";
            rtxtAdres.Text = "";
            txtGorev.Text = "";
        }
    }
}
