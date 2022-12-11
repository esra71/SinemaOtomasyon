namespace SinemaOtomasyon
{
    partial class FrmFilmler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilmler));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDil = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.mskYıl = new System.Windows.Forms.MaskedTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.rbtHayir = new System.Windows.Forms.RadioButton();
            this.rbtEvet = new System.Windows.Forms.RadioButton();
            this.mskTxtFilmSuresi = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFilmTuru = new DevExpress.XtraEditors.TextEdit();
            this.txtFilmAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilmTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilmAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.txtDil);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.mskYıl);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.rbtHayir);
            this.groupControl1.Controls.Add(this.rbtEvet);
            this.groupControl1.Controls.Add(this.mskTxtFilmSuresi);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtFilmTuru);
            this.groupControl1.Controls.Add(this.txtFilmAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(519, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(232, 658);
            this.groupControl1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SinemaOtomasyon.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtDil
            // 
            this.txtDil.Location = new System.Drawing.Point(82, 303);
            this.txtDil.Name = "txtDil";
            this.txtDil.Size = new System.Drawing.Size(100, 20);
            this.txtDil.TabIndex = 21;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(60, 306);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(15, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Dil:";
            // 
            // mskYıl
            // 
            this.mskYıl.Location = new System.Drawing.Point(82, 264);
            this.mskYıl.Mask = "0000";
            this.mskYıl.Name = "mskYıl";
            this.mskYıl.Size = new System.Drawing.Size(100, 21);
            this.mskYıl.TabIndex = 16;
            this.mskYıl.ValidatingType = typeof(int);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(30, 267);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Yapım Yıl:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(66, 415);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(116, 37);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Film Güncelle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSil.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(67, 372);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(116, 37);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Film Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 635);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "labelControl6";
            this.labelControl6.TextChanged += new System.EventHandler(this.labelControl6_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKaydet.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(67, 329);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 37);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Film Ekle";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 242);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Kategori:";
            // 
            // rbtHayir
            // 
            this.rbtHayir.AutoSize = true;
            this.rbtHayir.Location = new System.Drawing.Point(133, 240);
            this.rbtHayir.Name = "rbtHayir";
            this.rbtHayir.Size = new System.Drawing.Size(62, 17);
            this.rbtHayir.TabIndex = 9;
            this.rbtHayir.TabStop = true;
            this.rbtHayir.Text = "Yabancı";
            this.rbtHayir.UseVisualStyleBackColor = true;
            this.rbtHayir.CheckedChanged += new System.EventHandler(this.rbtHayir_CheckedChanged);
            // 
            // rbtEvet
            // 
            this.rbtEvet.AutoSize = true;
            this.rbtEvet.Location = new System.Drawing.Point(82, 240);
            this.rbtEvet.Name = "rbtEvet";
            this.rbtEvet.Size = new System.Drawing.Size(45, 17);
            this.rbtEvet.TabIndex = 8;
            this.rbtEvet.TabStop = true;
            this.rbtEvet.Text = "Yerli";
            this.rbtEvet.UseVisualStyleBackColor = true;
            this.rbtEvet.CheckedChanged += new System.EventHandler(this.rbtEvet_CheckedChanged);
            // 
            // mskTxtFilmSuresi
            // 
            this.mskTxtFilmSuresi.Location = new System.Drawing.Point(82, 204);
            this.mskTxtFilmSuresi.Mask = "90:00";
            this.mskTxtFilmSuresi.Name = "mskTxtFilmSuresi";
            this.mskTxtFilmSuresi.Size = new System.Drawing.Size(100, 21);
            this.mskTxtFilmSuresi.TabIndex = 7;
            this.mskTxtFilmSuresi.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Film Süresi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 178);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Film Türü:";
            // 
            // txtFilmTuru
            // 
            this.txtFilmTuru.Location = new System.Drawing.Point(82, 175);
            this.txtFilmTuru.Name = "txtFilmTuru";
            this.txtFilmTuru.Size = new System.Drawing.Size(100, 20);
            this.txtFilmTuru.TabIndex = 4;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(82, 149);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(100, 20);
            this.txtFilmAd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 152);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Film Adı:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(82, 123);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 126);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(2, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(511, 658);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmFilmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 661);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmFilmler";
            this.Text = "FİLMLER";
            this.Load += new System.EventHandler(this.FrmFilmler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilmTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilmAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RadioButton rbtHayir;
        private System.Windows.Forms.RadioButton rbtEvet;
        private System.Windows.Forms.MaskedTextBox mskTxtFilmSuresi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFilmTuru;
        private DevExpress.XtraEditors.TextEdit txtFilmAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.MaskedTextBox mskYıl;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtDil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}