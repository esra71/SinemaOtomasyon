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
    public partial class FrmSalonlar : Form
    {
        public FrmSalonlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Salonlar", bgl.Baglanti());
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
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtSinemaAdi.Text = dr["SinemaAdı"].ToString();
                txtSalonAd.Text = dr["SalonAdı"].ToString();
                txtKapasite.Text = dr["SalonKapasitesi"].ToString();
                cbxil.Text = dr["İl"].ToString();
                cbxilce.Text = dr["İlce"].ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtekle = new SqlCommand("insert into Salonlar (SinemaAdı,SalonAdı,SalonKapasitesi,İl,İlce) values (@b1,@b2,@b3,@b4,@b5)", bgl.Baglanti());
            kmtekle.Parameters.AddWithValue("@b1", txtSinemaAdi.Text);
            kmtekle.Parameters.AddWithValue("@b2", txtSalonAd.Text);
            kmtekle.Parameters.AddWithValue("@b3", txtKapasite.Text);
            kmtekle.Parameters.AddWithValue("@b4", cbxil.Text);
            kmtekle.Parameters.AddWithValue("@b5", cbxilce.Text);
            kmtekle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Yeni Kayıt Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSinemaAdi.Text = "";
            txtSalonAd.Text = "";
            txtKapasite.Text = "";
            cbxil.Text = "";
            cbxilce.Text = "";
            txtSinemaAdi.Focus();
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

        private void FrmSalonlar_Load(object sender, EventArgs e)
        {
            sehirListesi();
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmtsil = new SqlCommand("Delete From Salonlar where ID=@c1", bgl.Baglanti());
            kmtsil.Parameters.AddWithValue("@c1", txtID.Text);
            kmtsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Salon Bilgileri Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtguncelle = new SqlCommand("Update Salonlar set SinemaAdı=@d1,SalonAdı=@d2,SalonKapasitesi=@d3,İl=@d4,İlce=@d5 where ID=@d6", bgl.Baglanti());
            kmtguncelle.Parameters.AddWithValue("@d1", txtSinemaAdi.Text);
            kmtguncelle.Parameters.AddWithValue("@d2", txtSalonAd.Text);
            kmtguncelle.Parameters.AddWithValue("@d3", txtKapasite.Text);
            kmtguncelle.Parameters.AddWithValue("@d4", cbxil.Text);
            kmtguncelle.Parameters.AddWithValue("@d5", cbxilce.Text);
            kmtguncelle.Parameters.AddWithValue("@d6", txtID.Text);
            kmtguncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Salon Bilgileri Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
