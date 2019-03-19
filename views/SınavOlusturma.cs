using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SoruBankası.presenters;
using SoruBankası.models;
using SoruBankası.views;

namespace SoruBankası.views
{
    public partial class SinavOlusturma : DevExpress.XtraEditors.XtraForm
    {
        public SinavOlusturma()
        {
            InitializeComponent();
        }
        

        DBsoruBankasiDataContext dbContext = new DBsoruBankasiDataContext();

        private void SınavOlusturma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hCKDataSet.Sorular' table. You can move, or remove it, as needed.
            this.sorularTableAdapter.Fill(this.hCKDataSet.Sorular);
            var sorgu = (from soru in dbContext.Sorulars select soru.kategori).Distinct();
          
            foreach (var z in sorgu)
            {
                cbox_kategori.Properties.Items.Add(z);
            }
          
        }
        SinavBuilder sinavBuilder = new SinavOlustur();
        SinavBilgileri sinavBilgileri = new SinavBilgileri();
        private void btnSinavOlustur_Click(object sender, EventArgs e)
        {

            
            sinavBilgileri.Derslik = txt_derslik.Text;
            sinavBilgileri.GozetmenAdi = txt_gozetmen.Text;
            sinavBilgileri.Kategori = cbox_kategori.Text;
            sinavBilgileri.SinavAdi = txt_sinavAdi.Text;
            int soruSayisi = Convert.ToInt32(txt_SoruSayisi.Text);
            sinavBilgileri.SoruSayisi = soruSayisi;
            sinavBilgileri.ZorlukDerecesi = cbox_zorlukDerecesi.Text;
            
            
            
            OtoSinavOlustur sinavDirector= new OtoSinavOlustur(sinavBuilder,sinavBilgileri);
                   MessageBox.Show(sinavBuilder.sinavBilgileri.Derslik);
        }

        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_mSinavOlustur_Click(object sender, EventArgs e)
        {
            sinavBilgileri.Derslik = txt_mDerslik.Text;
            sinavBilgileri.GozetmenAdi = txt_mGozetmen.Text;
            sinavBilgileri.Kategori = cB_mKategori.Text;
            sinavBilgileri.SinavAdi = txt_mSinavAdi.Text;
            sinavBilgileri.ZorlukDerecesi = cB_mZorlukDerecesi.Text;
            List<Sorular> sL=new List<Sorular>();
            gCSoruListele.DataSource = sL;
            
            //ManuelSinavOlustur sinavDirector = new ManuelSinavOlustur(sinavBuilder, sinavBilgilerii);
        }


    }
}