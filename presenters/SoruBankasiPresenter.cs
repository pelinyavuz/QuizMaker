using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoruBankası.models;
using System.Data.SqlClient;
using SoruBankası.views;

namespace SoruBankası.presenters
{
    public class SoruBankasiPresenter
    {
        DBsoruBankasiDataContext dbContext;
        ISoruBankasi view;

        public SoruBankasiPresenter()
        {
            dbContext = new DBsoruBankasiDataContext();
        }

        public SoruBankasiPresenter(ISoruBankasi view)
        {
            this.view = view;
            dbContext = new DBsoruBankasiDataContext();

        }
        public void soruEkle(string soruTipi,string zorlukDerecesi,string kategori,string soruMetni,string soruCevabi,int soruPuani,string secenekA,string secenekB,string secenekC,string secenekD) 
        {
            Sorular eklenenSoru = new Sorular();
            eklenenSoru.soruTipi = soruTipi;
            eklenenSoru.zorlukDerecesi = zorlukDerecesi;
            eklenenSoru.kategori = kategori;
            eklenenSoru.soruMetni = soruMetni;
            eklenenSoru.soruCevabi = soruCevabi;
            eklenenSoru.aSikki = secenekA;
            eklenenSoru.bSikki = secenekB;
            eklenenSoru.cSikki = secenekC;
            eklenenSoru.dSikki = secenekD;
            eklenenSoru.soruPuani = soruPuani;

            dbContext.Sorulars.InsertOnSubmit(eklenenSoru);
            dbContext.SubmitChanges();
        //    view.getir(dbContext.sorulars.ToList());
        }

        public void getir()
        {
            view.getir(dbContext.Sorulars.ToList());
        }

        public void sil( int soruid)
        {
            Sorular soru = dbContext.Sorulars.First(k => k.soruid == soruid);
            dbContext.Sorulars.DeleteOnSubmit(soru);
            dbContext.SubmitChanges();
            
        }

        public void soruGuncelle(string sorukategorisi,string zorlukDerecesi)
        {
           
        }

    
        }

    }


