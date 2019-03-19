using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoruBankası.views;

namespace SoruBankası.presenters
{
    class SoruEklePresenter
    {
        private SoruEklePresenter() { }

        public static SoruEkle addQues = null;

        public static SoruEkle getInstance()
        {
            if (addQues == null)
                addQues = new SoruEkle();
            return addQues;
        }

        public static SoruGoster goster = null;

        public static SoruGoster getInstance1()
        {
            if (goster == null && addQues==null)
                goster = new SoruGoster();
            return goster;
        }

        public static SinavOlusturma olustur = null;

        public static SinavOlusturma getInstance2()
        {
            if (olustur == null)
                olustur = new SinavOlusturma();
            return olustur;
                
        }

        public static Rapor yazdir = null;

        public static Rapor getInstance3()
        {
            if (yazdir == null)
                yazdir = new Rapor();
            return yazdir;

        }
    }
}
