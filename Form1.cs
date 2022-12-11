using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmFilmler film;
        private void btnFilmler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (film == null || film.IsDisposed)
            {
                film = new FrmFilmler();
                film.MdiParent = this;
                film.Show();
            }
        }
        FrmMusteriler musteri;
        private void btnMüsteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteri == null ||  musteri.IsDisposed)
            {
                musteri = new FrmMusteriler();
                musteri.MdiParent = this;
                musteri.Show();
            }
        }
        FrmSalonlar salon;
        private void btnSalonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (salon == null || salon.IsDisposed)
            {
                salon = new FrmSalonlar();
                salon.MdiParent = this;
                salon.Show();
            }
        }
        FrmCalisanlar calisan;
        private void btnCalısanlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (calisan == null || calisan.IsDisposed)
            {
                calisan = new FrmCalisanlar();
                calisan.MdiParent = this;
                calisan.Show();
            }
        }
        FrmSeanslar seans;
        private void btnSeanslar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (seans == null || seans.IsDisposed)
            {
                seans = new FrmSeanslar();
                seans.MdiParent = this;
                seans.Show();
            }
        }
        FrmSatisFatura satis;
        private void btnSatisFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (satis == null || satis.IsDisposed)
            {
                satis = new FrmSatisFatura();
                satis.MdiParent = this;
                satis.Show();
            }
        }
        FrmBiletler bilet;
        private void btnBiletler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bilet == null || bilet.IsDisposed)
            {
                bilet = new FrmBiletler();
                bilet.MdiParent = this;
                bilet.Show();
            }
        }
        FrmAnaSayfa anasayfa;
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                anasayfa = new FrmAnaSayfa();
                anasayfa.MdiParent = this;
                anasayfa.Show();
            }
        }
        FrmAyarlar ayar;
        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ayar == null || ayar.IsDisposed)
            {
                ayar = new FrmAyarlar();
                ayar.MdiParent = this;
                ayar.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
