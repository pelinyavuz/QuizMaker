using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SoruBankası.presenters;
using SoruBankası.models;
using SoruBankası.views;

namespace SoruBankası
{
    public partial class Anasayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form cagır;

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          /*  if(SoruEklePresenter.goster == null)
            {
                cagır = SoruEklePresenter.getInstance();
                cagır.MdiParent = this;
                cagır.Show();
            }
            else if (SoruEklePresenter.goster != null)
            {
                cagır.Close();
                SoruEklePresenter.goster = null;
                cagır = SoruEklePresenter.getInstance();
                cagır.MdiParent = this;
                cagır.Show();
            }*/


            if (SoruEklePresenter.olustur == null && SoruEklePresenter.goster == null && SoruEklePresenter.yazdir == null)
            {

                cagır = SoruEklePresenter.getInstance();
                cagır.MdiParent = this;
                cagır.Show();
            }
            else if (SoruEklePresenter.olustur != null || SoruEklePresenter.goster != null || SoruEklePresenter.yazdir != null)
            {
                cagır.Close();
                SoruEklePresenter.olustur = null;
                SoruEklePresenter.goster = null;
                SoruEklePresenter.yazdir = null;
                cagır = SoruEklePresenter.getInstance();
                cagır.MdiParent = this;
                cagır.Show();
            }
            else
            {
                cagır.Close();
                SoruEklePresenter.olustur = null;
                SoruEklePresenter.goster = null;
                SoruEklePresenter.yazdir = null;
                cagır = SoruEklePresenter.getInstance();
                cagır.MdiParent = this;
                cagır.Show();

            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SoruEklePresenter.olustur == null && SoruEklePresenter.addQues == null && SoruEklePresenter.yazdir == null)
            {

                cagır = SoruEklePresenter.getInstance1();
                cagır.MdiParent = this;
                cagır.Show();
            }
            else if (SoruEklePresenter.olustur != null || SoruEklePresenter.addQues != null || SoruEklePresenter.yazdir != null)
            {
                cagır.Close();
                SoruEklePresenter.olustur = null;
                SoruEklePresenter.addQues = null;
                SoruEklePresenter.yazdir = null;
                cagır = SoruEklePresenter.getInstance1();
                cagır.MdiParent = this;
                cagır.Show();
            }
            else
            {
                cagır.Close();
                SoruEklePresenter.olustur = null;
                SoruEklePresenter.addQues = null;
                SoruEklePresenter.yazdir = null;
                cagır = SoruEklePresenter.getInstance1();
                cagır.MdiParent = this;
                cagır.Show();

            }
                
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SoruEklePresenter.addQues == null && SoruEklePresenter.goster==null && SoruEklePresenter.yazdir == null)
            {
                cagır = SoruEklePresenter.getInstance2();
                cagır.MdiParent = this;
                cagır.Show();
            }
            else if (SoruEklePresenter.addQues != null || SoruEklePresenter.goster!=null || SoruEklePresenter.yazdir != null)
            {
                cagır.Close();
                SoruEklePresenter.addQues = null;
                SoruEklePresenter.goster = null;
                SoruEklePresenter.yazdir = null;
                cagır = SoruEklePresenter.getInstance2();
                cagır.MdiParent = this;
                cagır.Show();
            }
            else
            {
                cagır.Close();
                SoruEklePresenter.addQues = null;
                SoruEklePresenter.goster = null;
                SoruEklePresenter.yazdir = null;
                cagır = SoruEklePresenter.getInstance2();
                cagır.MdiParent = this;
                cagır.Show();
                
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SoruEklePresenter.addQues == null && SoruEklePresenter.goster == null && SoruEklePresenter.olustur == null)
            {
                cagır = SoruEklePresenter.getInstance3();
                cagır.MdiParent = this;
                cagır.Show();
            }
            else if (SoruEklePresenter.addQues != null || SoruEklePresenter.goster != null || SoruEklePresenter.olustur != null)
            {
                cagır.Close();
                SoruEklePresenter.addQues = null;
                SoruEklePresenter.goster = null;
                SoruEklePresenter.olustur = null;
                cagır = SoruEklePresenter.getInstance3();
                cagır.MdiParent = this;
                cagır.Show();
            }
            else
            {
                cagır.Close();
                SoruEklePresenter.addQues = null;
                SoruEklePresenter.goster = null;
                SoruEklePresenter.olustur = null;
                cagır = SoruEklePresenter.getInstance3();
                cagır.MdiParent = this;
                cagır.Show();
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}