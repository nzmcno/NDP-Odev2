
using System;


namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Imlec gorunmemesi icin kod
            Console.CursorVisible = false;
            // Paneller Cizilir.
            AnaPanel.AnaPaneliCiz();
            SahnePaneli shn = new SahnePaneli(60, 35);
            shn.AktifSekilAta(new Dortgen());

        }

    }

    // Her yerden kolay erisebilmek icin static bir sinif olusturdum ve isim kolaylasti.
    class AnaPanel
    {
        static public void AnaPaneliCiz()
        {
            // Sahne paneli cizmek 
            SahnePaneli sahne = new SahnePaneli(60, 35);
            sahne.KonumAta(0, 0);

            sahne.Ciz();


            // Kontrol paneli cizmek
            KontrolPaneli knt = new KontrolPaneli(47, 17);
            knt.KonumAta(62, 0);

            knt.Ciz();
            knt.MenuCiz();


            // bilgi paneli cizmek
            BilgiPaneli blg = new BilgiPaneli(47, 17);
            blg.KonumAta(62, 18);
            blg.Ciz();
        }
    }
}
