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
using SoruBankası.views;
using SoruBankası.models;
using SoruBankası.presenters;

namespace SoruBankası
{
    public partial class SoruGoster : DevExpress.XtraEditors.XtraForm,ISoruBankasi
    {
        SoruBankasiPresenter sbp;
        public SoruGoster()
        {
            InitializeComponent();
            sbp = new SoruBankasiPresenter(this);
        }

        private void SoruGoster_Load(object sender, EventArgs e)
        {
            sbp.getir();
        }

        public void getir(IList<Sorular> soru)
        {
            gridC_sorular.DataSource = null;
            gridC_sorular.RefreshDataSource();
            gridC_sorular.DataSource = soru;
            gridC_sorular.Refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txt_id.Text);
            
            sbp.sil(id);
            sbp.getir();
            txt_id.Text = "";
           
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            sbp.getir();
        }

    }
}