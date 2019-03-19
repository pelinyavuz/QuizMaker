using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoruBankası.models;
using SoruBankası.presenters;
using SoruBankası.views;
using DevExpress.XtraEditors;

namespace SoruBankası
{
    public partial class SoruEkle : DevExpress.XtraEditors.XtraForm{
        public SoruEkle()
        {
            InitializeComponent();
        }

        DBsoruBankasiDataContext dbContext = new DBsoruBankasiDataContext();

        private void cbox_soruTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_soruTipi.Text == "Çoktan Seçmeli")
            {
                groupControl1.Visible = true;
                groupControl2.Visible = false;
                labelControl5.Visible = true;
                txt_dogruYanit.Visible = true;
            }
            else if (cbox_soruTipi.Text == "Doğru-Yanlış")
            {
                groupControl1.Visible = false;
                groupControl2.Visible = true;
                labelControl5.Visible = false;
                txt_dogruYanit.Visible = false;
            }
            else
            {
                groupControl1.Visible = false;
                groupControl2.Visible = false;
                labelControl5.Visible = true;
                txt_dogruYanit.Visible = true;
            }
        }
        SoruBankasiPresenter sbp =new SoruBankasiPresenter();


        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string dogruYanit;
            if(cbox_soruTipi.Text == "Çoktan Seçmeli")
            {
                dogruYanit=txt_dogruYanit.Text;
            }
            else if(cbox_soruTipi.Text=="Doğru-Yanlış")
            {
                if(chk_dogru.Checked)
                {
                    dogruYanit=chk_dogru.Text;
                }
                else
                    dogruYanit=chk_yanlis.Text;
            }
            else
                dogruYanit=txt_dogruYanit.Text;

            string kategoriAdi= null;
            if (cbox_kategori.Text!="Kategori")
            {
                kategoriAdi = cbox_kategori.Text;
            }
            else
            {
                kategoriAdi = txt_yeniKategori.Text;
            }


            sbp.soruEkle(cbox_soruTipi.Text, cbox_zorlukDerecesi.Text, kategoriAdi, txt_soruMetni.Text, dogruYanit, Convert.ToInt16(txt_soruPuani.Text), txt_Asikki.Text, txt_Bsikki.Text, txt_Csikki.Text, txt_Dsikki.Text);

            MessageBox.Show("Soru Eklendi..");
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sorgu = (from soru in dbContext.Sorulars select soru.kategori).Distinct();

            foreach( var z in sorgu)
            {
                cbox_kategori.Properties.Items.Add(z);
            }
        }

    
    }
}
