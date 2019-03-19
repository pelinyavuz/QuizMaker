using SoruBankası.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruBankası.presenters
{
   public class OtoSinavOlustur
    {
       public OtoSinavOlustur(SinavBuilder sinavBuilder, SinavBilgileri sinavBilgileri)
       {
           sinavBuilder.otoSinavOlustur(sinavBilgileri);
           
       }
    }
}
