
using System;


namespace Odev2
{
    class BilgiPaneli
    {
        public BilgiPaneli(int genislik, int yukseklik)
        {

            this.genislik = genislik;
            this.yukseklik = yukseklik;

            cizimAlani = new Dortgen();

        }
        //Bilgi Panelinin Konumunu atar.
        public void KonumAta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        // Bilgi panelini cizen metod.
        public void Ciz()
        {
            cizimAlani.KonumAta(x, y);
            cizimAlani.BoyutAta(genislik, yukseklik);
            cizimAlani.RenkAta(ConsoleColor.Green);
            
            
            cizimAlani.Ciz();
        }
        // Gerekli degerleri yazan metod.
        public void BilgiCiz()
        {


            Console.SetCursorPosition(73,21);
            Console.Write("X................:"+aktifSekil.getX());
            Console.SetCursorPosition(73, 23);
            Console.Write("Y................:" + aktifSekil.getY());
            Console.SetCursorPosition(73, 25);
            Console.Write("Genislik.........:" + aktifSekil.getGenislik());
            Console.SetCursorPosition(73, 27);
            Console.Write("Yukseklik........:" + aktifSekil.getYukseklik());
            Console.SetCursorPosition(73, 29);
            Console.Write("Renk.............:" + aktifSekil.getRenk());
           
        }
        // Sekilllerden hangisinin aktif olacagi secilir.
        public void SekilAta(Dortgen sekil)
        {

            aktifSekil = sekil;
            
        }

        private Dortgen aktifSekil;
        private Dortgen cizimAlani;
        private int genislik;
        private int yukseklik;
        private int x;
        private int y;
    }
}
