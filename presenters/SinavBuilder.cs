    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoruBankası.presenters;
using SoruBankası.models;

namespace SoruBankası.presenters
{
    public abstract class SinavBuilder
    {
        public string SinavAdi { get; set; }
        public string GozetmenAdi { get; set; }
        public string Derslik { get; set; }
        public int SoruSayisi { get; set; }
        public string Kategori { get; set; }
        public string ZorlukDerecesi { get; set; }
        public int Kolay { get; set; }
        public int Orta { get; set; }
        public int Zor { get; set; }

        public DBsoruBankasiDataContext dbContext;

        public Sinav sinav;
        public List<Sinav> sinavListesi;
        public SinavBilgileri sinavBilgileri;
        public Sorular soru;
        public List<Sorular> soruListesi;
        public List<Sorular> kolaySoruListesi;
        public List<Sorular> ortaSoruListesi;
        public List<Sorular> zorSoruListesi;

        public abstract void otoSinavOlustur(SinavBilgileri sB);
        public abstract void manuelSinavOlustur(SinavBilgileri sB, List<Sorular> sL);

    }
}
