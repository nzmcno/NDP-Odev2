
using System;


namespace Odev2
{
    class Dortgen
    {
        public Dortgen()
        {
           // Dortgenin metodlarini kullanmamiz icin gerekli kurucu sinif.
        }

        public Dortgen(int xSinir, int ySinir)
        {
            //Dortgenin parametreli mainde kullanmamiz icin gerekli kurucu sinif.
            //sinirlar belirlendi
            this.xSinir = xSinir;
            this.ySinir = ySinir;
            //Rasgele genislik ve yukseklik atandi.
            genislik= RastgeleSayi.SayiUret(2, 20);
            yukseklik = RastgeleSayi.SayiUret(2, 20);
            //Rasgele konum atandi.
            x = RastgeleSayi.SayiUret(1,41);
            y = RastgeleSayi.SayiUret(1,16);
            //Rasgele renk atandi.
            renk = (ConsoleColor)RastgeleSayi.SayiUret(1, 15);
        }
        //X'i cagirabilmek icin gerekli metod.
        public int getX()

        {
            int DortgenX;
            DortgenX =this.x   ;
            return DortgenX;
        }
        //Y'i cagirabilmek icin gerekli metod.

        public int getY()
        {
            int DortgenY;
            DortgenY = this.y;
            return DortgenY;
        }
        //Genisligi cagirabilmek icin gerekli metod.

        public int getGenislik()
        {
            int DortgenG;
            DortgenG = this.genislik;
            return DortgenG;
        }
        //Yuksekligi cagirabilmek icin gerekli metod.

        public int getYukseklik()
        {
            int DortgenH;
            DortgenH = this.yukseklik;
            return DortgenH;
        }
        //Rengi cagirabilmek icin gerekli metod.

        public ConsoleColor getRenk()
        {
            ConsoleColor DortgenRenk;
            DortgenRenk = this.renk;
            return DortgenRenk;
        }
        // Dortgen cizdirmek metodu
        public void Ciz()
        {
            
                TepeCiz();
                DikeyCiz();
                TabanCiz();
            
           
        }

        // Dortgenin yan taraflarini cizdirmek icin metod.
        public void DikeyCiz()
        {
            

           
            for (int j = 0; j < yukseklik; j++)
            {
                Console.SetCursorPosition(x, y+j+1);
                Console.Write(KarakterSeti.Dikey);
               
                Console.SetCursorPosition(x+genislik+1, y + j + 1);

                Console.Write(KarakterSeti.Dikey);

            }
           
        }
        
        
        // Dortgenin tepesini cizen metod.

        public void TepeCiz()
        {
            Console.ForegroundColor = (ConsoleColor)renk;

            Console.SetCursorPosition(x, y);
            Console.Write(KarakterSeti.SolUstKose);
            for (int i = 0; i < genislik; i++)
            {
                Console.Write(KarakterSeti.Duz);
            }
            Console.Write(KarakterSeti.SagUstKose);

        }
        
         
        // Dortgenin tabanini cizen metod.
        public void TabanCiz()
        {
            Console.SetCursorPosition(x, y+yukseklik);

            Console.Write(KarakterSeti.SolAltKose);
            for (int i = 0; i < genislik; i++)
            {
                Console.Write(KarakterSeti.Duz);
            }
            Console.Write(KarakterSeti.SagAltKose);
            Console.ResetColor();
        }
        
        
       
        public void KonumAta(int x, int y)
        {
            this.x = x;
            this.y = y;
            //Konum atiyor.
        }

        public void BoyutAta(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            //Boyut atiyor.
        }

        public void RenkAta(ConsoleColor renk)
        {                   
            this.renk = renk;
            //Renk atiyor.
        }

        public void SolaOtele()
        {

            x -= 1;
        }

        public void SagaOtele()
        {
            x += 1;
        }

        public void YukariOtele()
        {
            y -= 1;
        }

        public void AsagiOtele()
        {
            y += 1;
        }



        private int genislik;
        private int yukseklik;
        private ConsoleColor renk;
        private int x;
        private int y;
        private int xSinir;
        private int ySinir;
    }
}
