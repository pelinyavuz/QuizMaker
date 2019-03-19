using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoruBankası.models;

namespace SoruBankası.presenters
{
   public class SinavOlustur:SinavBuilder
    {
       public SinavOlustur()
       {
           sinav=new Sinav();
           sinavListesi = new List<Sinav>();
           sinavBilgileri = new SinavBilgileri();
           soru = new Sorular();
           soruListesi=new List<Sorular>();
           kolaySoruListesi=new List<Sorular>();
           ortaSoruListesi = new List<Sorular>();
           zorSoruListesi = new List<Sorular>();
           dbContext = new DBsoruBankasiDataContext();
       }

       public override void manuelSinavOlustur(SinavBilgileri sB, List<Sorular> sL)
       {
           sinavBilgileri = sB;
           dbContext.SinavBilgileris.InsertOnSubmit(sB);
           dbContext.SubmitChanges();
           soruListesi=sL;

           for (int i = 0; i < sL.Count; i++)
           {
               sinav=new Sinav();
               sinav.SoruId = sL[i].soruid;
               sinav.SinavBilgileriId = sB.id;
               dbContext.Sinavs.InsertOnSubmit(sinav);
               dbContext.SubmitChanges();
           }

       }

       public override void otoSinavOlustur(SinavBilgileri sB)
       {
           sinavBilgileri = sB;

           dbContext.SinavBilgileris.InsertOnSubmit(sB);
           dbContext.SubmitChanges();
           int soruSayisi = Convert.ToInt32(sB.SoruSayisi);
           if(sB.ZorlukDerecesi=="Zor")
           {
               Zor = (soruSayisi * 5) / 10;
               Orta = (soruSayisi * 3) / 10;
               Kolay = (soruSayisi * 2) / 10;
           }
           else if (sB.ZorlukDerecesi == "Orta")
           {
               Zor = (soruSayisi * 3) / 10;
               Orta = (soruSayisi * 5) / 10;
               Kolay = (soruSayisi * 2) / 10;
           }
           else if (sB.ZorlukDerecesi == "Kolay")
           {
               Zor = (soruSayisi * 1) / 10;
               Orta = (soruSayisi * 3) / 10;
               Kolay = (soruSayisi * 6) / 10;
           }
           
           List<Sorular> c = new List<Sorular>();
           var sorgu2 = from s in dbContext.Sorulars where s.kategori == sB.Kategori select s;
           foreach (var item in sorgu2)
           {
               c.Add(item);
           }
           
           Random rand = new Random();
           for (int i = 0; i < c.Count; i++ )
           {
               if (c[i].zorlukDerecesi == "Zor")
               {
                   zorSoruListesi.Add(c[i]);
               }
               else if (c[i].zorlukDerecesi == "Orta")
               {
                   ortaSoruListesi.Add(c[i]);
               }
               else
               {
                   kolaySoruListesi.Add(c[i]);     
               }
                             
           }
           

           for (int i = 0; i < Zor; i++)
           {
               int randZor = rand.Next(Zor);
               soruListesi.Add(zorSoruListesi[randZor]);
           }

           for (int i = 0; i < Orta; i++)
           {
               int randOrta = rand.Next(Orta);
               soruListesi.Add(ortaSoruListesi[randOrta]);
           }

           for (int i = 0; i < Kolay; i++)
           {
               int randKolay = rand.Next(Kolay);
               soruListesi.Add(kolaySoruListesi[randKolay]);
           }
           
           for(int i=0; i<soruListesi.Count; i++)
           {    
                sinav=new Sinav();
                sinav.SinavBilgileriId = sinavBilgileri.id;
                sinav.SoruId = soruListesi[i].soruid;
                dbContext.Sinavs.InsertOnSubmit(sinav);
                dbContext.SubmitChanges();
           }
           
       }
    }
}
