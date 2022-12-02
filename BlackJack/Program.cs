using System;
using System.Globalization;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Avsluta = false;

            while(Avsluta == false)
            {
                Console.WriteLine("");
                Console.WriteLine("    -----BLACK JACK-----");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("    1. Spela BlackJack");
                Console.WriteLine("    2. Visa senaste vinnaren");
                Console.WriteLine("    3. Spelets regler");
                Console.WriteLine("    4. Avsluta programmet");
                Console.WriteLine("");

                int val = int.Parse(Console.ReadLine());

                string namn = "Ingen";

                switch(val)
                {
                    case 1:

                        Thread.Sleep(1000);

                        Random KortSpelare = new Random();
                        Random KortDator = new Random();
                        Random DatorDraKort = new Random();

                        int DatorDra = DatorDraKort.Next(1,2);
                        int SumSpelare = KortDator.Next(1, 11);
                        int SumDator = KortSpelare.Next(1, 11);

                        bool Spel = true;

                        while (Spel == true)
                        {

                            string Dra = "j";
                          

                            if(Dra == "j")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("    Nu kommer du och datorn få varist kort");
                                Console.WriteLine($"    Dina poäng:{SumSpelare}");
                                Console.WriteLine($"    Datorns poäng: {SumDator}");
                                Console.WriteLine("");
                                Console.WriteLine("    Vill du dra ett till kort? j/n");
                                Console.WriteLine("");
                            }
                            Dra = Console.ReadLine();

                            if (DatorDra == 1)
                            {
                                SumDator = SumDator + KortDator.Next(1, 11);
                            }

                            else
                            {

                            }

                            switch (Dra)
                            {
                                case "j":
                                    SumSpelare = SumSpelare + KortSpelare.Next(1, 11);
                                    break;

                                default:
                                    break;

                            }

                            if (SumSpelare == 21 || SumDator > 21)
                            {
                                Console.WriteLine("    Nu kommer du och datorn få varist kort");
                                Console.WriteLine($"    Dina poäng:{SumSpelare}");
                                Console.WriteLine($"    Datorns poäng: {SumDator}");
                                Console.WriteLine("");
                                Console.WriteLine("    Du har vunnit!!!");
                                Console.WriteLine("");
                                Console.WriteLine("");

                                Console.Write("Skriv ditt namn: ");

                                namn = Console.ReadLine();

                                Spel = false;
                            }

                            else if (SumDator == 21 || SumSpelare > 21)
                            {
                                Console.WriteLine("    Nu kommer du och datorn få varist kort");
                                Console.WriteLine($"    Dina poäng:{SumSpelare}");
                                Console.WriteLine($"    Datorns poäng: {SumDator}");
                                Console.WriteLine("");
                                Console.WriteLine("    Du förlorade, datorn vann :(");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Spel = false;
                            }
                        }

                        break;


                    case 2:
                        Console.WriteLine($"Den senaste vinnaren var: " + namn);
                        Console.WriteLine();
                        break;


                    case 3:
                        Thread.Sleep(1000);
                        Console.Write("    ");

                        string text1 = "Målet i Blackjack är att få en bättre hand än dealern. För att göra det, måste du";
                        foreach (char d in text1)
                        {
                            Console.Write(d);
                            Thread.Sleep(50);
                        }

                        Console.WriteLine("");
                        Console.Write("    ");

                        string text2 = "ha en hand som är högre än dealerns, utan att handens totala värde överstiger";
                        foreach (char e in text2)
                        {
                            Console.Write(e);
                            Thread.Sleep(50);
                        }

                        Console.WriteLine("");
                        Console.Write("    ");

                        string text3 = "21. Du kan även vinna genom att ha ett totalt värde under 22 när det totala värdet";
                        foreach (char f in text3)
                        {
                            Console.Write(f);
                            Thread.Sleep(50);
                        }

                        Console.WriteLine("");
                        Console.Write("    ");

                        string text4 = "på dealerns hand överstiger 21.";
                        foreach (char g in text4)
                        {
                            Console.Write(g );
                            Thread.Sleep(50);
                        }

                        Console.WriteLine("");

                        Console.WriteLine("");
                        break;


                    case 4:
                        Console.WriteLine("");

                        string text = "    Programmet avslutas";
                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(100);
                        }

                        Thread.Sleep(1000);

                        string text0 = "...";
                        foreach (char a in text0)
                        {
                            Console.Write(a);
                            Thread.Sleep(500);
                        }
                        Avsluta = true;
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
