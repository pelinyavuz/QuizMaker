namespace SoruBankası
{
    partial class SoruEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoruEkle));
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.chk_yanlis = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_soruMetni = new DevExpress.XtraEditors.TextEdit();
            this.txt_Dsikki = new DevExpress.XtraEditors.TextEdit();
            this.txt_Csikki = new DevExpress.XtraEditors.TextEdit();
            this.txt_Bsikki = new DevExpress.XtraEditors.TextEdit();
            this.txt_Asikki = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_soruPuani = new DevExpress.XtraEditors.TextEdit();
            this.txt_yeniKategori = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_dogruYanit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbox_kategori = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbox_zorlukDerecesi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbox_soruTipi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chk_dogru = new DevExpress.XtraEditors.CheckEdit();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ekle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_yanlis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soruMetni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dsikki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Csikki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bsikki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Asikki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soruPuani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeniKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dogruYanit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_kategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_zorlukDerecesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_soruTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_dogru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // chk_yanlis
            // 
            this.chk_yanlis.Location = new System.Drawing.Point(442, 170);
            this.chk_yanlis.Name = "chk_yanlis";
            this.chk_yanlis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_yanlis.Properties.Appearance.Options.UseFont = true;
            this.chk_yanlis.Properties.Caption = "";
            this.chk_yanlis.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style10;
            this.chk_yanlis.Size = new System.Drawing.Size(267, 22);
            this.chk_yanlis.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pictureBox2);
            this.groupControl2.Controls.Add(this.pictureBox1);
            this.groupControl2.Controls.Add(this.chk_yanlis);
            this.groupControl2.Controls.Add(this.chk_dogru);
            this.groupControl2.Location = new System.Drawing.Point(12, 82);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(661, 243);
            this.groupControl2.TabIndex = 37;
            this.groupControl2.Text = "Doğru-Yanlış";
            this.groupControl2.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 54);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 13);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "Soru Metni :";
            // 
            // txt_soruMetni
            // 
            this.txt_soruMetni.Location = new System.Drawing.Point(86, 51);
            this.txt_soruMetni.Name = "txt_soruMetni";
            this.txt_soruMetni.Size = new System.Drawing.Size(587, 20);
            this.txt_soruMetni.TabIndex = 35;
            // 
            // txt_Dsikki
            // 
            this.txt_Dsikki.Location = new System.Drawing.Point(36, 148);
            this.txt_Dsikki.Name = "txt_Dsikki";
            this.txt_Dsikki.Size = new System.Drawing.Size(611, 20);
            this.txt_Dsikki.TabIndex = 7;
            // 
            // txt_Csikki
            // 
            this.txt_Csikki.Location = new System.Drawing.Point(36, 108);
            this.txt_Csikki.Name = "txt_Csikki";
            this.txt_Csikki.Size = new System.Drawing.Size(611, 20);
            this.txt_Csikki.TabIndex = 6;
            // 
            // txt_Bsikki
            // 
            this.txt_Bsikki.Location = new System.Drawing.Point(36, 70);
            this.txt_Bsikki.Name = "txt_Bsikki";
            this.txt_Bsikki.Size = new System.Drawing.Size(611, 20);
            this.txt_Bsikki.TabIndex = 5;
            // 
            // txt_Asikki
            // 
            this.txt_Asikki.Location = new System.Drawing.Point(36, 34);
            this.txt_Asikki.Name = "txt_Asikki";
            this.txt_Asikki.Size = new System.Drawing.Size(611, 20);
            this.txt_Asikki.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 151);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "D )";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "C )";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 398);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 13);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Soru Puanı :";
            // 
            // txt_soruPuani
            // 
            this.txt_soruPuani.Location = new System.Drawing.Point(86, 391);
            this.txt_soruPuani.Name = "txt_soruPuani";
            this.txt_soruPuani.Size = new System.Drawing.Size(67, 20);
            this.txt_soruPuani.TabIndex = 32;
            // 
            // txt_yeniKategori
            // 
            this.txt_yeniKategori.EditValue = "Yeni Kategori";
            this.txt_yeniKategori.Location = new System.Drawing.Point(464, 12);
            this.txt_yeniKategori.Name = "txt_yeniKategori";
            this.txt_yeniKategori.Size = new System.Drawing.Size(209, 20);
            this.txt_yeniKategori.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(13, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "B )";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 354);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Doğru Yanıt :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "A )";
            // 
            // txt_dogruYanit
            // 
            this.txt_dogruYanit.Location = new System.Drawing.Point(86, 351);
            this.txt_dogruYanit.Name = "txt_dogruYanit";
            this.txt_dogruYanit.Size = new System.Drawing.Size(243, 20);
            this.txt_dogruYanit.TabIndex = 25;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_Dsikki);
            this.groupControl1.Controls.Add(this.txt_Csikki);
            this.groupControl1.Controls.Add(this.txt_Bsikki);
            this.groupControl1.Controls.Add(this.txt_Asikki);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 82);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(661, 187);
            this.groupControl1.TabIndex = 29;
            this.groupControl1.Text = "Çoktan Seçmeli";
            this.groupControl1.Visible = false;
            // 
            // cbox_kategori
            // 
            this.cbox_kategori.EditValue = "Kategori";
            this.cbox_kategori.Location = new System.Drawing.Point(314, 11);
            this.cbox_kategori.Name = "cbox_kategori";
            this.cbox_kategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_kategori.Properties.Items.AddRange(new object[] {
            "Kategori"});
            this.cbox_kategori.Size = new System.Drawing.Size(117, 20);
            this.cbox_kategori.TabIndex = 28;
            // 
            // cbox_zorlukDerecesi
            // 
            this.cbox_zorlukDerecesi.EditValue = "Zorluk Derecesi";
            this.cbox_zorlukDerecesi.Location = new System.Drawing.Point(161, 12);
            this.cbox_zorlukDerecesi.Name = "cbox_zorlukDerecesi";
            this.cbox_zorlukDerecesi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_zorlukDerecesi.Properties.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cbox_zorlukDerecesi.Size = new System.Drawing.Size(117, 20);
            this.cbox_zorlukDerecesi.TabIndex = 27;
            // 
            // cbox_soruTipi
            // 
            this.cbox_soruTipi.EditValue = "Soru Tipi";
            this.cbox_soruTipi.Location = new System.Drawing.Point(17, 11);
            this.cbox_soruTipi.Name = "cbox_soruTipi";
            this.cbox_soruTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_soruTipi.Properties.Items.AddRange(new object[] {
            "Çoktan Seçmeli",
            "Doğru-Yanlış",
            "Klasik"});
            this.cbox_soruTipi.Size = new System.Drawing.Size(117, 20);
            this.cbox_soruTipi.TabIndex = 26;
            this.cbox_soruTipi.Tag = "";
            this.cbox_soruTipi.SelectedIndexChanged += new System.EventHandler(this.cbox_soruTipi_SelectedIndexChanged);
            // 
            // chk_dogru
            // 
            this.chk_dogru.Location = new System.Drawing.Point(188, 169);
            this.chk_dogru.Name = "chk_dogru";
            this.chk_dogru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_dogru.Properties.Appearance.Options.UseFont = true;
            this.chk_dogru.Properties.Caption = "";
            this.chk_dogru.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style10;
            this.chk_dogru.Size = new System.Drawing.Size(81, 22);
            this.chk_dogru.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoruBankası.Properties.Resources._648352259e;
            this.pictureBox2.Location = new System.Drawing.Point(406, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoruBankası.Properties.Resources.f160e9729d;
            this.pictureBox1.Location = new System.Drawing.Point(161, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ekle
            // 
            this.btn_ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.ImageOptions.Image")));
            this.btn_ekle.Location = new System.Drawing.Point(579, 415);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(94, 37);
            this.btn_ekle.TabIndex = 34;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // SoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 464);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_soruMetni);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_soruPuani);
            this.Controls.Add(this.txt_yeniKategori);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_dogruYanit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cbox_kategori);
            this.Controls.Add(this.cbox_zorlukDerecesi);
            this.Controls.Add(this.cbox_soruTipi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoruEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru Ekle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_yanlis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_soruMetni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dsikki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Csikki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bsikki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Asikki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soruPuani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeniKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dogruYanit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_kategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_zorlukDerecesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_soruTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_dogru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit chk_yanlis;
        private DevExpress.XtraEditors.CheckEdit chk_dogru;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_soruMetni;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_soruPuani;
        private DevExpress.XtraEditors.TextEdit txt_yeniKategori;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_ekle;
        private DevExpress.XtraEditors.TextEdit txt_dogruYanit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_Dsikki;
        private DevExpress.XtraEditors.TextEdit txt_Csikki;
        private DevExpress.XtraEditors.TextEdit txt_Bsikki;
        private DevExpress.XtraEditors.TextEdit txt_Asikki;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_kategori;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_zorlukDerecesi;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_soruTipi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

