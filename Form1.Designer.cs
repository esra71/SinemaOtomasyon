namespace SinemaOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnFilmler = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeanslar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalonlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMüsteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalısanlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnKoltuklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSatisFatura = new DevExpress.XtraBars.BarButtonItem();
            this.btnBiletler = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAnaSayfa,
            this.btnFilmler,
            this.btnSeanslar,
            this.btnSalonlar,
            this.btnMüsteriler,
            this.btnCalısanlar,
            this.btnKoltuklar,
            this.btnSatisFatura,
            this.btnBiletler,
            this.btnAyarlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(754, 141);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Caption = "ANASAYFA";
            this.btnAnaSayfa.Id = 1;
            this.btnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.Image")));
            this.btnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.LargeImage")));
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnaSayfa_ItemClick);
            // 
            // btnFilmler
            // 
            this.btnFilmler.Caption = "FİLMLER";
            this.btnFilmler.Id = 2;
            this.btnFilmler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFilmler.ImageOptions.Image")));
            this.btnFilmler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFilmler.ImageOptions.LargeImage")));
            this.btnFilmler.Name = "btnFilmler";
            this.btnFilmler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFilmler_ItemClick);
            // 
            // btnSeanslar
            // 
            this.btnSeanslar.Caption = "SEANSLAR";
            this.btnSeanslar.Id = 3;
            this.btnSeanslar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeanslar.ImageOptions.Image")));
            this.btnSeanslar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSeanslar.ImageOptions.LargeImage")));
            this.btnSeanslar.Name = "btnSeanslar";
            this.btnSeanslar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSeanslar_ItemClick);
            // 
            // btnSalonlar
            // 
            this.btnSalonlar.Caption = "SALONLAR";
            this.btnSalonlar.Id = 4;
            this.btnSalonlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalonlar.ImageOptions.Image")));
            this.btnSalonlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalonlar.ImageOptions.LargeImage")));
            this.btnSalonlar.Name = "btnSalonlar";
            this.btnSalonlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalonlar_ItemClick);
            // 
            // btnMüsteriler
            // 
            this.btnMüsteriler.Caption = "MÜŞTERİLER";
            this.btnMüsteriler.Id = 5;
            this.btnMüsteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMüsteriler.ImageOptions.Image")));
            this.btnMüsteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMüsteriler.ImageOptions.LargeImage")));
            this.btnMüsteriler.Name = "btnMüsteriler";
            this.btnMüsteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMüsteriler_ItemClick);
            // 
            // btnCalısanlar
            // 
            this.btnCalısanlar.Caption = "ÇALIŞANLAR";
            this.btnCalısanlar.Id = 6;
            this.btnCalısanlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalısanlar.ImageOptions.Image")));
            this.btnCalısanlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCalısanlar.ImageOptions.LargeImage")));
            this.btnCalısanlar.Name = "btnCalısanlar";
            this.btnCalısanlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalısanlar_ItemClick);
            // 
            // btnKoltuklar
            // 
            this.btnKoltuklar.Caption = "KOLTUKLAR";
            this.btnKoltuklar.Id = 7;
            this.btnKoltuklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKoltuklar.ImageOptions.Image")));
            this.btnKoltuklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKoltuklar.ImageOptions.LargeImage")));
            this.btnKoltuklar.Name = "btnKoltuklar";
            // 
            // btnSatisFatura
            // 
            this.btnSatisFatura.Caption = "SATIŞ FATURA";
            this.btnSatisFatura.Id = 8;
            this.btnSatisFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisFatura.ImageOptions.Image")));
            this.btnSatisFatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSatisFatura.ImageOptions.LargeImage")));
            this.btnSatisFatura.Name = "btnSatisFatura";
            this.btnSatisFatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSatisFatura_ItemClick);
            // 
            // btnBiletler
            // 
            this.btnBiletler.Caption = "BİLETLER";
            this.btnBiletler.Id = 9;
            this.btnBiletler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBiletler.ImageOptions.Image")));
            this.btnBiletler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBiletler.ImageOptions.LargeImage")));
            this.btnBiletler.Name = "btnBiletler";
            this.btnBiletler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBiletler_ItemClick);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "AYARLAR";
            this.btnAyarlar.Id = 10;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAyarlar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "SİNEMA OTOMASYON SİSTEMİ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFilmler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSeanslar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSalonlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMüsteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCalısanlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSatisFatura);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBiletler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 661);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİNEMA OTOMASYON";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem btnFilmler;
        private DevExpress.XtraBars.BarButtonItem btnSeanslar;
        private DevExpress.XtraBars.BarButtonItem btnSalonlar;
        private DevExpress.XtraBars.BarButtonItem btnMüsteriler;
        private DevExpress.XtraBars.BarButtonItem btnCalısanlar;
        private DevExpress.XtraBars.BarButtonItem btnKoltuklar;
        private DevExpress.XtraBars.BarButtonItem btnSatisFatura;
        private DevExpress.XtraBars.BarButtonItem btnBiletler;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

