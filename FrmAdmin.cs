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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
      
        private void btnGirisYap_Click(object sender, EventArgs e)
 
        {
            SqlCommand kmt = new SqlCommand("Select *From Admin where KullanıcıAdi=@a1 and Sifre=@a2", bgl.Baglanti());
            kmt.Parameters.AddWithValue("@a1", txtKullanici.Text);
            kmt.Parameters.AddWithValue("@a2", txtSifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre Girdiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.Baglanti().Close();
        }

    }
}
