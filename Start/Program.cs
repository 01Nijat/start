using System;

namespace baslangiclar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //bala gore telebenin bacariqli yada bacariqsiz oldugunu gosteren bir kod.
            /* 
            int score = 90;
            if (score > 60)
            {
                Console.WriteLine("Bacariqli Telebe");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bacariqsiz telebe");
                Console.ReadLine();
            }*/
            #endregion
            #region
            //telebeden 3 dene balini hesabliyib ona gore score yazan kod
            // eger bal 80-100 aradisa A+,, 60-80 disa A,, 40-60 disa B,, 0-40 disa F yazsin.
            /*
            Console.WriteLine("Xais edirik scoreni daxil edin");
            int score=int.Parse(Console.ReadLine());
            Console.WriteLine("xais edirik ikinci scoreni daxil edin");
            int score2=int.Parse(Console.ReadLine());
            Console.WriteLine("xais edirik ucuncu scoreni daxil edin");
           int score3= int.Parse(Console.ReadLine());
            int cavab = (score + score2 + score3) / 3;
            if(cavab>80 && cavab <= 100)
            {
                Console.WriteLine("Sizin baliniz A+");
                Console.ReadLine();
            }
            else if(cavab>60 && cavab <= 80)
            {
                Console.WriteLine("Sizin baliniz, A");
                Console.ReadLine();
            }
            else if(cavab>40 && cavab <= 60)
            {
                Console.WriteLine("baliniz, B");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Baliniz, F");
                Console.ReadLine();
            } 
              */


            #endregion
            #region
            //Atm Yaratmaq,
            // 1 tusuna basanda balansi goster,
            //2 tusuna basanda pul cixartmaq,
            //3 tusuna basanda pul elave etmek,
            //Q tusuna basanda cixis etmek.
            /*
            Console.WriteLine("Xos geldiniz");
            Console.WriteLine("xais edirim bir secim edin");

            int Balans = 1000;
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Balansiniz" + (Balans));
                Console.ReadLine();
            }
            else if (secim == "2")
            {

                int cixartma = int.Parse(Console.ReadLine());

                if (cixartma > Balans)
                {
                    Console.WriteLine("bu islemi ede bilmezsiz");
                    Console.ReadLine();

                }
                Console.WriteLine("qalan Azn" + (Balans - cixartma));
                Console.ReadLine();

            }
            else if (secim == "3")
            {
                int elave_etmek = int.Parse(Console.ReadLine());
                Console.WriteLine("umumi hesab" + (Balans + elave_etmek));
                Console.ReadLine();
            }
            else if (secim == "q")
            {
                Console.WriteLine("Cixis edildi, Xos gunler");
            }
            else
            {
                Console.WriteLine("bir secim edin");
                Console.ReadLine();
            }*/

            #endregion
            #region
            //beden kutle indeksi kilo/(boy*boy)
            //beden kutle indeksi 18 den kicikse zeif.
            //18 ve 25 araligidisa normal.
            //25 den coxdusa piylidir
            /*
            Console.WriteLine("ceki daxil edin");

            int kilo = int.Parse(Console.ReadLine());
            Console.WriteLine("boy daxil edin");
            double boy = Convert.ToDouble(Console.ReadLine());
            double indeks = kilo / (boy * boy);
            if (indeks<18)
            {
                Console.WriteLine("Zeif cekiniz var");
                Console.ReadLine();
            }
            else if (indeks>=18&&indeks<=25)
            {
                Console.WriteLine("beden kutleniz Normaldir");
                Console.ReadLine();
            }
            else if (indeks>25)
            {
                Console.WriteLine("piylisiz");
                Console.ReadLine();
            }*/
            #endregion
            #region
            //Atm  programi "switch case" le yoxlamaq
            //1-e basanda balansi goster.
            //2-e basanda pul cixart
            //3-e basanda pul elave et
            //4-e basanda cixis et
            //basqa deyerlere basanda xeberdarliq etsin
            /*
            Console.WriteLine("Atm-ye Xos geldiniz");
            Console.WriteLine("1-Reqemi Balansi");
            Console.WriteLine("2-Reqemi Pul goturmek");
            Console.WriteLine("3-Reqemi Pul elave etmek");
            Console.WriteLine("4-Reqemi Cixis etmek ucun");
            int Balans = 1400;
            string secim = Console.ReadLine();
            switch (secim)
            {
                case  "1":
                    Console.WriteLine("Sizin balansiniz"+ Balans);
                    Console.ReadLine();
                    break;

                case  "2":
                    Console.WriteLine("Xais edirik Balansinizdan cekmek isdediyiniz mevacibi qeyd edin");
                    int Cekilen_Pul = int.Parse(Console.ReadLine());
                    if (Cekilen_Pul>Balans)
                    {
                        Console.WriteLine("Emeliyyat Yalnisdir Balansinizda o qeder mevacib yoxdur");
                        
                    }
                    else
                    {
                        Console.WriteLine("sizin Balansiniz" + (Balans-Cekilen_Pul));
                        Console.ReadLine();
                    }
                    break;

                   case "3":
                    Console.WriteLine("Elave edeceyiniz meblegi qeyd edin");
                    int Elave_edilecek = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ugurlu Emelliyat" + (Balans+Elave_edilecek));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Cixis edilir Tesekkur edirik");
                    Console.ReadLine();
                    break;
                default:
                       Console.WriteLine("xais edirik duzun deyer secin");
                    Console.ReadLine();
                    break;
            } */
            #endregion
            #region
            /*
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
            */
            #endregion
            #region
            /*
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine("");
            }
            Console.ReadLine();
            */
            #endregion
            #region
            //int a = 100;
            //while (a >= 0) 
            //{
            // Console.WriteLine(a);
            // a -= 2;
            // }
            //Console.ReadLine();
            /*
            int n = 10;
            while (1<=n)
            {
                
                Console.WriteLine(n);
                n--;
            }
            Console.ReadLine();
            */
            #endregion
            #region
            //do while while de sert truedise do nun icindeki kodlar isleyir, falsedise en az bir defe iwleyir.
            // 1 den o a qeder olan sayilari do/while ekrana cixartmaq alt alta.
            // 1den 100 e qeder olan ededlerin cemini ekrana cixartmaq.
            //1 ci ders.
            /* int a = 1;
             do
             {

                 Console.WriteLine(a);
                 a++;
             } while (a<=10);

             Console.ReadLine(); */

            //2 ci helli
            /* int a = 1;
             int cem = 0;
             do
             {
                 cem += a;
                 a++;
             } while (a<=100);
             Console.WriteLine("1 den 100 3 qeder olan ededlerin Toplami  "   +cem);
             Console.ReadLine();*/

            // Break ve Continue; Break sadece o serte gore kodu tamamen qirir, Contunie ise bir defe qirir ve davam edir.
            /* int a = 1;
             for (int i = 0; a <=10 ; a++)
             {

                 if (a==7)
                 {
                      break; //--- 7 e qeder olanlari yazdirdi.
                    // continue; //--- buda 7 ni saymadi ve 10 qeder olanlari qeyd etdi
                 }
                 Console.WriteLine("ededlerin siyahisi---" +a);

             }
             Console.ReadLine();
            */
            #endregion
            #region
            // sade bir Vurma cedveli ekranda gosder. 
            /*   for (int i = 0; i <=10; i++)
               {
                   for (int j = 0; j <= 10; j++)
                   {
                       Console.WriteLine(i + " x " + j + "=" + (i * j));
                   }

               }
               Console.ReadLine(); */
            #endregion
            #region
            /*
            // login ve password olan bir uygulama ve 3 defeen artiq yalnis olsa daxil ola bilmesin.
            int sans = 3;
            while (true)
            {               
                Console.WriteLine("Zehmet olmasa login daxil edin");
                string login = Console.ReadLine();
                Console.WriteLine("zehmet olmasa password daxil edin");
                string password = Console.ReadLine();
                if (login=="Nijat" && password=="Nijat123")
                {
                    Console.WriteLine("xos geldiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("parolunuz yanlisdir");
                    if (sans>0)
                    {
                        sans-=1;
                    }
                    if (sans==0)
                    {
                        Console.WriteLine("sizin sansiniz bitibdir artiq xais ediik terk edin");
                        break;
                    }
                }
                Console.ReadLine();
            } */

            #endregion
            #region
            // istifadeciden bir sayi alib, 0 dan o sayiya qeder toplayib ve boleciyik isdifadeciden aldigimiz sayiya,
            //eger ortalama 50 den boyukduse boyukdu diyecek, kicikdise kicikdi yazacaq.
            /*
            Console.WriteLine("salam xos geldiniz xais edirik bir reqem secin ");
            int say = int.Parse(Console.ReadLine());
            int Cem = 0;
            for (int i = 0; i <=say; i++)
            {
                Cem += i;
            }
            double ortalama = Cem / say;
            if (ortalama>50)
            {
                Console.WriteLine("ortalama boyukdur 50 den");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ortalama 50 den kicikdir");
                Console.ReadLine();
            } */
            #endregion
        }
    }
}
