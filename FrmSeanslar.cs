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
    public partial class FrmSeanslar : Form
    {
        public FrmSeanslar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
       
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Seans", bgl.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtekle = new SqlCommand("insert into Seans (Tarih,Saat) values (@a1,@a2)", bgl.Baglanti());
            kmtekle.Parameters.AddWithValue("@a1", mskTarih.Text);
            kmtekle.Parameters.AddWithValue("@a2", mskSaat.Text);
            kmtekle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Yeni Seans Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmtsil = new SqlCommand("Delete From Seans where ID=@b1", bgl.Baglanti());
            kmtsil.Parameters.AddWithValue("@b1", txtId.Text);
            kmtsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Seans Bilgileri Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtguncelle = new SqlCommand("Update Seans set Tarih=@c1,Saat=@c2 where ID=@c3", bgl.Baglanti());
            kmtguncelle.Parameters.AddWithValue("@c1", mskTarih.Text);
            kmtguncelle.Parameters.AddWithValue("@c2", mskSaat.Text);
            kmtguncelle.Parameters.AddWithValue("@c3", txtId.Text);
            kmtguncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Seans Bilgileri Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            mskTarih.Focus();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                mskTarih.Text = dr["Tarih"].ToString();
                mskSaat.Text = dr["Saat"].ToString();
            }
        }

        private void FrmSeanslar_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
