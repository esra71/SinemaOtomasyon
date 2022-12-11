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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Admin ", bgl.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            txtKullanici.Text = "";
            txtSifre.Text = "";
        }

        private void btnİslemler_Click(object sender, EventArgs e)
        {
            if (btnİslemler.Text == "KAYDET") {
                SqlCommand komut = new SqlCommand("insert into Admin (KullanıcıAdi, Sifre) values(@a1,@a2)", bgl.Baglanti());
                komut.Parameters.AddWithValue("@a1", txtKullanici.Text);
                komut.Parameters.AddWithValue("@a2", txtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Yeni Kullanıcı Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if (btnİslemler.Text == "GÜNCELLE")
            {
                SqlCommand komutgncl = new SqlCommand("Update Admin Set Sifre=@b2 where KullanıcıAdi=@b1", bgl.Baglanti());
                komutgncl.Parameters.AddWithValue("@b1", txtKullanici.Text);
                komutgncl.Parameters.AddWithValue("@b2", txtSifre.Text);
                komutgncl.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Admin Şifresi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtKullanici.Text = dr["KullanıcıAdi"].ToString();
                txtSifre.Text = dr["Sifre"].ToString();
            }
            
        }

        private void txtKullanici_EditValueChanged(object sender, EventArgs e)
        {
            if (txtKullanici.Text != "")
            {
                btnİslemler.Text = "GÜNCELLE";
            }
            else
                btnİslemler.Text = "KAYDET";
        }
    }
}
