namespace SoruBankası
{
    partial class SoruGoster
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
            this.gridC_sorular = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsoruid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoruTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzorlukDerecesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoruMetni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoruCevabi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaSikki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbSikki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcSikki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldSikki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoruPuani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridC_sorular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridC_sorular
            // 
            this.gridC_sorular.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridC_sorular.Location = new System.Drawing.Point(0, 0);
            this.gridC_sorular.MainView = this.gridView1;
            this.gridC_sorular.Name = "gridC_sorular";
            this.gridC_sorular.Size = new System.Drawing.Size(712, 321);
            this.gridC_sorular.TabIndex = 0;
            this.gridC_sorular.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsoruid,
            this.colsoruTipi,
            this.colzorlukDerecesi,
            this.colkategori,
            this.colsoruMetni,
            this.colsoruCevabi,
            this.colaSikki,
            this.colbSikki,
            this.colcSikki,
            this.coldSikki,
            this.colsoruPuani});
            this.gridView1.GridControl = this.gridC_sorular;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colsoruid
            // 
            this.colsoruid.FieldName = "soruid";
            this.colsoruid.Name = "colsoruid";
            this.colsoruid.Visible = true;
            this.colsoruid.VisibleIndex = 0;
            // 
            // colsoruTipi
            // 
            this.colsoruTipi.FieldName = "soruTipi";
            this.colsoruTipi.Name = "colsoruTipi";
            this.colsoruTipi.Visible = true;
            this.colsoruTipi.VisibleIndex = 1;
            // 
            // colzorlukDerecesi
            // 
            this.colzorlukDerecesi.FieldName = "zorlukDerecesi";
            this.colzorlukDerecesi.Name = "colzorlukDerecesi";
            this.colzorlukDerecesi.Visible = true;
            this.colzorlukDerecesi.VisibleIndex = 2;
            // 
            // colkategori
            // 
            this.colkategori.FieldName = "kategori";
            this.colkategori.Name = "colkategori";
            this.colkategori.Visible = true;
            this.colkategori.VisibleIndex = 3;
            // 
            // colsoruMetni
            // 
            this.colsoruMetni.FieldName = "soruMetni";
            this.colsoruMetni.Name = "colsoruMetni";
            this.colsoruMetni.Visible = true;
            this.colsoruMetni.VisibleIndex = 4;
            // 
            // colsoruCevabi
            // 
            this.colsoruCevabi.FieldName = "soruCevabi";
            this.colsoruCevabi.Name = "colsoruCevabi";
            this.colsoruCevabi.Visible = true;
            this.colsoruCevabi.VisibleIndex = 5;
            // 
            // colaSikki
            // 
            this.colaSikki.FieldName = "aSikki";
            this.colaSikki.Name = "colaSikki";
            this.colaSikki.Visible = true;
            this.colaSikki.VisibleIndex = 6;
            // 
            // colbSikki
            // 
            this.colbSikki.FieldName = "bSikki";
            this.colbSikki.Name = "colbSikki";
            this.colbSikki.Visible = true;
            this.colbSikki.VisibleIndex = 7;
            // 
            // colcSikki
            // 
            this.colcSikki.FieldName = "cSikki";
            this.colcSikki.Name = "colcSikki";
            this.colcSikki.Visible = true;
            this.colcSikki.VisibleIndex = 8;
            // 
            // coldSikki
            // 
            this.coldSikki.FieldName = "dSikki";
            this.coldSikki.Name = "coldSikki";
            this.coldSikki.Visible = true;
            this.coldSikki.VisibleIndex = 9;
            // 
            // colsoruPuani
            // 
            this.colsoruPuani.FieldName = "soruPuani";
            this.colsoruPuani.Name = "colsoruPuani";
            this.colsoruPuani.Visible = true;
            this.colsoruPuani.VisibleIndex = 10;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(479, 327);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(49, 21);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "Sil";
            this.btn_sil.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(404, 327);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(42, 21);
            this.txt_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İd";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(534, 327);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(166, 21);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Güncelle ve Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
            // 
            // SoruGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 360);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.gridC_sorular);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoruGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoruGoster";
            this.Load += new System.EventHandler(this.SoruGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridC_sorular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit silItemButtonEdit;
        private DevExpress.XtraGrid.GridControl gridC_sorular;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colsoruid;
        private DevExpress.XtraGrid.Columns.GridColumn colsoruTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colzorlukDerecesi;
        private DevExpress.XtraGrid.Columns.GridColumn colkategori;
        private DevExpress.XtraGrid.Columns.GridColumn colsoruMetni;
        private DevExpress.XtraGrid.Columns.GridColumn colsoruCevabi;
        private DevExpress.XtraGrid.Columns.GridColumn colaSikki;
        private DevExpress.XtraGrid.Columns.GridColumn colbSikki;
        private DevExpress.XtraGrid.Columns.GridColumn colcSikki;
        private DevExpress.XtraGrid.Columns.GridColumn coldSikki;
        private DevExpress.XtraGrid.Columns.GridColumn colsoruPuani;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}