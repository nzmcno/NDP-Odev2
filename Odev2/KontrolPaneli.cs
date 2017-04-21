
using System;


namespace Odev2
{
    class KontrolPaneli
    {
        public KontrolPaneli(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            cizimAlani = new Dortgen();

        }
        //Kontrol panelini cizer.
        public void Ciz()
        {
            cizimAlani.KonumAta(x, y);
            cizimAlani.BoyutAta(genislik, yukseklik);
            cizimAlani.RenkAta(ConsoleColor.Cyan);

            cizimAlani.Ciz();

            
        }
        //Kontrol panelinin konumunu belirler.
        public void KonumAta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //Kontrol panelinin menusu cizilir.
        public void MenuCiz()
        {

            Console.SetCursorPosition(73,1);
            Console.Write("KONTROL PANELI");
            Console.SetCursorPosition(73, 3);
            Console.Write("SEKIL EKLE   < E >");
            Console.SetCursorPosition(73, 5);
            Console.Write("YUKARI OTELE < W >");
            Console.SetCursorPosition(73, 7);
            Console.Write("SOLA OTELE   < A >");
            Console.SetCursorPosition(73, 9);
            Console.Write("ASAGI OTELE  < S >");
            Console.SetCursorPosition(73, 11);
            Console.Write("SAGA OTELE   < D >");

        }

        

        private int genislik;
        private int yukseklik;
        private int x;
        private int y;
        private Dortgen cizimAlani;
    }
}
