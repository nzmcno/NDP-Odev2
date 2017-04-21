
using System;


namespace Odev2
{
    class SahnePaneli
    {
        public SahnePaneli(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            cizimAlani = new Dortgen();
            //
        }

        public void KonumAta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //Sahne panelini cizer.
        public void Ciz()
        {
                       
            
            cizimAlani.KonumAta(x, y);
            cizimAlani.BoyutAta(genislik, yukseklik);
            cizimAlani.RenkAta(ConsoleColor.Yellow);

            cizimAlani.Ciz();
            
        }

       

        public void AktifSekilAta(Dortgen yeniSekil)
        {   // Sekiller dizsini tanimlar.
            sekiller =new Dortgen[maksimumSekilSayisi];

            // Sekiller dizisine nesne ekler.
            for (int i = 0; i < maksimumSekilSayisi; i++)
            {
                sekiller[i] = new Dortgen(60, 35);
            }

            while (true)
            {
                
                ConsoleKeyInfo tus = Console.ReadKey(true);
                              
                if (tus.Key == ConsoleKey.E )
                {   // Sekil sayisi maksimuma ulasinca program kapanir.
                    if (sekilSayisi == maksimumSekilSayisi)
                    {
                        break;
                    }

                    Console.Clear();

                    AnaPanel.AnaPaneliCiz();

                    for (int i = 0; i <= sekilSayisi; i++)
                    {
                        sekiller[i].Ciz();
                    }

                    sekiller[sekilSayisi + 1].Ciz();
                    aktifSekil= sekiller[sekilSayisi + 1];
                    yeniSekil = aktifSekil;

                    BilgiPaneli blg = new BilgiPaneli(47, 17);
                    blg.SekilAta(yeniSekil);
                    blg.BilgiCiz();

                    sekilSayisi++;


                }

                if (sekilSayisi >= 0)
                {


                    if (tus.Key == ConsoleKey.D  )
                    {
                        Console.Clear();
                        if (sekiller[sekilSayisi].getX() + sekiller[sekilSayisi].getGenislik() != 59)
                        {
                            sekiller[sekilSayisi].SagaOtele();

                        }
                        AnaPanel.AnaPaneliCiz();
                        for (int i = 0; i <= sekilSayisi; i++)
                        {
                            sekiller[i].Ciz();
                        }
                        BilgiPaneli blg = new BilgiPaneli(47, 17);
                        blg.SekilAta(yeniSekil);
                        blg.BilgiCiz();

                    }
                    if (tus.Key == ConsoleKey.A )
                    {
                       
                            Console.Clear();
                            if (sekiller[sekilSayisi].getX() != 1)
                            {
                                sekiller[sekilSayisi].SolaOtele();
                            }

                            AnaPanel.AnaPaneliCiz();
                            for (int i = 0; i <= sekilSayisi; i++)
                            {
                                sekiller[i].Ciz();
                            }
                            BilgiPaneli blg = new BilgiPaneli(47, 17);

                            blg.SekilAta(yeniSekil);
                            blg.BilgiCiz();
                        

                    }

                    if (tus.Key == ConsoleKey.W )
                    {
                        Console.Clear();
                        if (sekiller[sekilSayisi].getY() != 1)
                        {
                            sekiller[sekilSayisi].YukariOtele();

                        }

                        AnaPanel.AnaPaneliCiz();
                        for (int i = 0; i <= sekilSayisi; i++)
                        {
                            sekiller[i].Ciz();
                        }
                        BilgiPaneli blg = new BilgiPaneli(47, 17);
                        blg.SekilAta(yeniSekil);
                        blg.BilgiCiz();
                    }
                    if (tus.Key == ConsoleKey.S )
                    {
                        Console.Clear();
                        if (sekiller[sekilSayisi].getY() + sekiller[sekilSayisi].getYukseklik() != 34)
                        {
                            sekiller[sekilSayisi].AsagiOtele();
                        }

                        AnaPanel.AnaPaneliCiz();
                        for (int i = 0; i <= sekilSayisi; i++)
                        {
                            sekiller[i].Ciz();
                        }
                        BilgiPaneli blg = new BilgiPaneli(47, 17);
                        blg.SekilAta(yeniSekil);
                        blg.BilgiCiz();
                    }
                }

            }

        }


        
        public void SekilSolaOtele()
        {
            x -= 1;
        }
        public void SekilSagaOtele()
        {
            x += 1;

        }

        public void SekilYukariOtele()
        {
            y -= 1;
        }

        public void SekilAsagiOtele()
        {
            y += 1;
        }

        public bool SekillerCarpisiyormu()
        {
            bool carpisiyormu=true;
          /*  for (int i = 0; i < sekilSayisi+1; i++)
            {
                    if ( //Carpisma durumlari yazilir.  )

            {
                    carpisiyormu = false;
                }
            }
               

            // Carpisma testi denemesi yaptim fakat basarili olmadi.
            // Harflerin yazildigi if lerin icine " && SekillerCarpisiyormu() " eklenecek.

           */

            return carpisiyormu;

        }



      
        private int genislik;
        private int yukseklik;
        private int x;
        private int y;
        private Dortgen cizimAlani;
        private Dortgen aktifSekil;
        private int sekilSayisi = -1;
        private int maksimumSekilSayisi = 99;
        private Dortgen[] sekiller;
    }
}
