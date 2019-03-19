using SoruBankası.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruBankası.presenters
{
    public class ManuelSinavOlustur
    {

        public ManuelSinavOlustur(SinavBuilder sinavBuilder, SinavBilgileri sinavBilgileri, List<Sorular> sL)
       {
           sinavBuilder.manuelSinavOlustur(sinavBilgileri, sL);
           
       }
    }
}
