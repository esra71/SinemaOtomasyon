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
    public partial class FrmFilmler : Form
    {
        public FrmFilmler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter("Select * From Filmler" ,bgl.Baglanti());
            dta.Fill(data);
            gridControl1.DataSource = data;
        }
        private void FrmFilmler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Filmler (FilmAdı, FilmTürü, Süre, Kategori, Yıl, Dil) values(@a1,@a2,@a3,@a4,@a5,@a6)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@a1" ,txtFilmAd.Text);
            komut.Parameters.AddWithValue("@a2", txtFilmTuru.Text);
            komut.Parameters.AddWithValue("@a3", mskTxtFilmSuresi.Text);
            komut.Parameters.AddWithValue("@a4", labelControl6.Text);
            komut.Parameters.AddWithValue("@a5", mskYıl.Text);
            komut.Parameters.AddWithValue("@a6", txtDil.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Yeni Film Eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void rbtEvet_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEvet.Checked == true)
            {
                labelControl6.Text = "True";
            }
        }

        private void rbtHayir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtHayir.Checked == true)
            {
                labelControl6.Text = "False";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Filmler where ID=@b1", bgl.Baglanti());
            komutsil.Parameters.AddWithValue("@b1", txtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Film Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtFilmAd.Text = dr["FilmAdı"].ToString();
            txtFilmTuru.Text = dr["FilmTürü"].ToString();
            mskTxtFilmSuresi.Text = dr["Süre"].ToString();
            labelControl6.Text = dr["Kategori"].ToString();
            mskYıl.Text = dr["Yıl"].ToString();
            txtDil.Text = dr["Dil"].ToString();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komutgncl = new SqlCommand("Update Filmler Set FilmAdı=@c1,FilmTürü=@c2,Süre=@c3,Kategori=@c4,Yıl=@c5,Dil=@c6 where ID=@c7", bgl.Baglanti());
            komutgncl.Parameters.AddWithValue("@c1", txtFilmAd.Text);
            komutgncl.Parameters.AddWithValue("@c2", txtFilmTuru.Text);
            komutgncl.Parameters.AddWithValue("@c3", mskTxtFilmSuresi.Text);
            komutgncl.Parameters.AddWithValue("@c4", labelControl6.Text);
            komutgncl.Parameters.AddWithValue("@c5", mskYıl.Text);
            komutgncl.Parameters.AddWithValue("@c6", txtDil.Text);
            komutgncl.Parameters.AddWithValue("@c7", txtId.Text);
            komutgncl.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Film Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void labelControl6_TextChanged(object sender, EventArgs e)
        {
            if (labelControl6.Text == "True")
            {
                rbtEvet.Checked = true;
            }
            if (labelControl6.Text == "False")
            {
                rbtHayir.Checked = true;
            }
        }

    }
}
