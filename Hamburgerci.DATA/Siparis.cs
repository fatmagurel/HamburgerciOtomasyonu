using Hamburgerci.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA
{
    public class Siparis
    {

        public int EkstraID { get; set; }
        public int MenuID { get; set; }
        public int SiparisID { get; set; }
        public Menu SeciliMenu { get; set; }
        public virtual List<Ekstra> EkstraMalzemeleri { get; set; }
        public virtual List<SiparisEkstra> SiparisEkstralar { get; set; }
        public virtual List<MenuSiparis> MenuSiparisler { get; set; }
        public decimal Hesap { get; set; }
        public string Boyutu { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public void Hesapla()
        {
            //Menu Fiyati: 20 TL
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;

            if (Boyutu == "Orta")
            {
                ToplamTutar += ToplamTutar * 0.10M;
            }

            else if (Boyutu == "Buyuk")
            {
                ToplamTutar += ToplamTutar * 0.25M;
            }
            //switch (Boyutu)
            //{
            //    case Boyutu.Orta:
            //        ToplamTutar += ToplamTutar * 0.10M;//Toplamtutar=20+(20*0.10)
            //        break;
            //    case Boyutu.Buyuk:
            //        ToplamTutar += ToplamTutar * 0.25M;
            //        break;
            //}

            foreach (Ekstra ekstra in EkstraMalzemeleri)
                ToplamTutar += ekstra.Fiyati;

            ToplamTutar = ToplamTutar * Adet;
        }

        public override string ToString()
        {
            if (EkstraMalzemeleri.Count < 1)
            {
                return string.Format("{0} Menü X {1} Adet, {2} Boy, Toplam: {3}", SeciliMenu.MenuAdi, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = null;

                foreach (Ekstra ekstra in EkstraMalzemeleri)
                {
                    ekstraMalzemeler += ekstra.EkstraAdi + ", ";
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(',', ' ');

                return string.Format("{0} Menü X {1} Adet, {2} Boy, ({3}) Toplam: {4}", SeciliMenu.MenuAdi, Adet, Boyutu.ToString(), ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
