using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoruBankası.models;
using SoruBankası.presenters;

namespace SoruBankası.views
{
    public interface ISoruBankasi
    {
        void getir(IList<Sorular> soru);
    }
}
