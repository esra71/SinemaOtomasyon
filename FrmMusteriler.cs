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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Musteri", bgl.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskKayit.Text = "";
            mskTelefon.Text = "";
            txtMail.Text = "";
            cbxil.Text = "";
            cbxilce.Text = "";
            txtAd.Focus();
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
        

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            sehirListesi();
            listele();
        }

        private void cbxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxilce.Properties.Items.Clear();
            SqlCommand kmt = new SqlCommand("Select Ilce From Ilceler where Sehir=@a1", bgl.Baglanti());
            kmt.Parameters.AddWithValue("@a1", cbxil.SelectedIndex +1);
            SqlDataReader dr= kmt.ExecuteReader();
            while (dr.Read())
            {
                cbxilce.Properties.Items.Add(dr[0]);
            }
            bgl.Baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtekle = new SqlCommand("insert into Musteri (MusteriAd,MusteriSoyad,KayıtTarihi,Telefon,Mail,İl,İlce) values (@b1,@b2,@b3,@b4,@b5,@b6,@b7)", bgl.Baglanti());
            kmtekle.Parameters.AddWithValue("@b1", txtAd.Text);
            kmtekle.Parameters.AddWithValue("@b2", txtSoyad.Text);
            kmtekle.Parameters.AddWithValue("@b3", mskKayit.Text);
            kmtekle.Parameters.AddWithValue("@b4", mskTelefon.Text);
            kmtekle.Parameters.AddWithValue("@b5", txtMail.Text);
            kmtekle.Parameters.AddWithValue("@b6", cbxil.Text);
            kmtekle.Parameters.AddWithValue("@b7", cbxilce.Text);
            kmtekle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Yeni Müşteri Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtAd.Text = dr["MusteriAd"].ToString();
                txtSoyad.Text = dr["MusteriSoyad"].ToString();
                mskKayit.Text = dr["KayıtTarihi"].ToString();
                mskTelefon.Text = dr["Telefon"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                cbxil.Text = dr["İl"].ToString();
                cbxilce.Text = dr["İlce"].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmtsil = new SqlCommand("Delete From Musteri where ID=@c1", bgl.Baglanti());
            kmtsil.Parameters.AddWithValue("@c1",txtId.Text);
            kmtsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtguncelle = new SqlCommand("Update Musteri set MusteriAd=@d1,MusteriSoyad=@d2,KayıtTarihi=@d3,Telefon=@d4,Mail=@d5,İl=@d6,İlce=@d7 where ID=@d8", bgl.Baglanti());
            kmtguncelle.Parameters.AddWithValue("@d1", txtAd.Text);
            kmtguncelle.Parameters.AddWithValue("@d2", txtSoyad.Text);
            kmtguncelle.Parameters.AddWithValue("@d3", mskKayit.Text);
            kmtguncelle.Parameters.AddWithValue("@d4", mskTelefon.Text);
            kmtguncelle.Parameters.AddWithValue("@d5", txtMail.Text);
            kmtguncelle.Parameters.AddWithValue("@d6", cbxil.Text);
            kmtguncelle.Parameters.AddWithValue("@d7", cbxilce.Text);
            kmtguncelle.Parameters.AddWithValue("@d8", txtId.Text);
            kmtguncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
