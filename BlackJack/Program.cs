using System;
using System.Data;
using System.Globalization;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Random KortSpelare = new Random();
            Random KortDator = new Random();
            Random DatorDraKort = new Random();

            bool Avsluta = false;

            string namn = "Ingen";

            string[] Vinnarna = { "...", "...", "..." };

            var value = 1;

            while (Avsluta == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("    -----BLACK JACK-----");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("    1. Spela BlackJack");
                Console.WriteLine("    2. De 3 senaste vinnarna");
                Console.WriteLine("    3. Spelets regler");
                Console.WriteLine("    4. Avsluta programmet");
                Console.WriteLine("    5. Extra ");
                Console.WriteLine();

                string val = (Console.ReadLine());

                switch (val)
                {
                    case "1":
                        Console.Clear();
                        int DatorDra = 0;
                        int SumSpelare = 0;
                        int SumDator = 0;

                        SumSpelare = SumSpelare + KortSpelare.Next(1, 11) + KortSpelare.Next(1, 11);
                        SumDator = SumDator + KortSpelare.Next(1, 11) + KortSpelare.Next(1, 11);

                        Console.WriteLine();
                        Console.WriteLine("    Nu kommer du och datorn två kort");
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"    Dina poäng: {SumSpelare}");
                        Thread.Sleep(1000);
                        Console.WriteLine($"    Datorns poäng: {SumDator}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(1000);
                        Console.WriteLine();

                        bool Spel = true;

                        string Dra = "j";

                        int DuVann;

                        while (Spel == true)
                        {
                            if(SumDator > 21)
                            {
                                DuVann = 1;
                            }

                            if(SumSpelare > 21)
                            {
                                DuVann = 0;
                            }
                            
                            if(SumSpelare == SumDator)
                            {
                                DuVann = 2;
                            }

                            if(SumDator => 17)
                            {
                                DatorDra = 0;
                            }
                            else
                            {
                                DatorDra = DatorDraKort.Next(0, 2);
                            }

                            if(DatorDra == 0 && SumSpelare <= 21  && SumSpelare > SumDator)
                            { 
                                DuVann = 1;
                            }

                            if (DuVann != 1 || DuVann =! 0)
                            {
                                
                            }

                            Console.WriteLine("    Vill du dra ett till kort? j/n");
                            Console.Write("    ");
                            Dra = Console.ReadLine();

                            switch (Dra)
                            {
                                case "j":
                                    SumSpelare = SumSpelare + KortSpelare.Next(1, 11);

                                    Console.WriteLine();
                                    Console.WriteLine("    Nu kommer du få ett kort");
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine($"    Dina poäng: {SumSpelare}");
                                    Thread.Sleep(1000);
                                    Console.WriteLine($"    Datorns poäng: {SumDator}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Thread.Sleep(1000);
                                    Console.WriteLine();
                                    break;


                                case "n":
                                    if(DatorDra == 1)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("    Datorn väljer att dra kort");
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine($"    Dina poäng:{SumSpelare}");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"    Datorns poäng: {SumDator}");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Thread.Sleep(1000);
                                        Console.WriteLine();
                                    }

                                    else if(DatorDra == 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("    Ingen drog ett kort");
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine($"    Dina poäng:{SumSpelare}");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"    Datorns poäng: {SumDator}");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Thread.Sleep(1000);
                                        Console.WriteLine();
                                    }
                                   
                                    break;


                                default:
                                    string text0 = "Ej giltigt!";
                                    foreach (char c in text0)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(50);
                                    }
                                    Thread.Sleep(1000);
                                    Console.WriteLine();
                                    break;
                            }
                            
                            if(DuVann == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("    Du förlorade, datorn vann :(");
                                Console.WriteLine();
                                Console.WriteLine();
                                Spel = false;         
                            }

                            if(DuVann == 1)
                            {                    
                                Console.WriteLine("    Du har vunnit!!!");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.Write("Skriv ditt namn: ");
                                if (Vinnarna[0] == "...")
                                {
                                    Vinnarna[0] = Console.ReadLine();
                                }

                                else if (Vinnarna[1] == "..." && Vinnarna[0] != "...")
                                {
                                    Vinnarna = Vinnarna.Skip(value + 1).Concat(Vinnarna.Take(value + 1)).ToArray();
                                    Vinnarna[0] = Console.ReadLine();
                                }
                              
                                else if (Vinnarna[2] == "..." && Vinnarna[1] != "...")
                                {
                                    Vinnarna = Vinnarna.Skip(value + 1).Concat(Vinnarna.Take(value + 1)).ToArray();
                                    Vinnarna[0] = Console.ReadLine();
                                }
                                else if (Vinnarna[2] != "...")
                                {
                                    Vinnarna = Vinnarna.Skip(value + 1).Concat(Vinnarna.Take(value + 1)).ToArray();
                                    Vinnarna[0] = Console.ReadLine();
                                }
                                
                                Spel = false;
                            }

                            if(DuVann == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine("   Det blev lika!");
                                Console.WriteLine();
                                Console.WriteLine();
                                Spel = false;
                            }

                        }
                        
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.Write("Tryck enter för meny");
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    case "2":
                        Console.Clear();
                        Console.WriteLine();
                        string text1 = "Tre senaste vinnarna";
                        foreach (char a in text1)
                        {
                            Console.Write(a);
                            Thread.Sleep(50);
                        }

                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.WriteLine();

                        string text2 = $"1. {Vinnarna[0]}";
                        foreach (char b in text2)
                        {
                            Console.Write(b);
                            Thread.Sleep(50);
                        }

                        Thread.Sleep(500);
                        Console.WriteLine();

                        string text3 = $"2. {Vinnarna[1]}";
                        foreach (char c in text3)
                        {
                            Console.Write(c);
                            Thread.Sleep(50);
                        }

                        Thread.Sleep(500);
                        Console.WriteLine();

                        string text4 = $"3. {Vinnarna[2]}";
                        foreach (char c in text4)
                        {
                            Console.Write(c);
                            Thread.Sleep(50);
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Tryck enter för meny");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("    ");

                        string text5 = "Målet i Blackjack är att få en bättre hand än dealern. För att göra det, måste du \n    ha en hand som är högre än dealerns, utan att handens totala värde överstiger \n    21. Du kan även vinna genom att ha ett totalt värde under 22 när det totala värdet \n    på dealerns hand överstiger 21.";
                        foreach (char c in text5)
                        {
                            Console.Write(c);
                            Thread.Sleep(30);
                        }



                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("    Tryck enter för meny");
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    case "4":
                        Console.Clear();
                        Console.WriteLine();

                        string text6 = "    Programmet avslutas";
                        foreach (char c in text6)
                        {
                            Console.Write(c);
                            Thread.Sleep(50);
                        }

                        Thread.Sleep(500);

                        string text7 = "...";
                        foreach (char c in text7)
                        {
                            Console.Write(c);
                            Thread.Sleep(500);
                        }

                        Thread.Sleep(500);

                        Avsluta = true;
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("────────▄▄▄▄▄▄▄▄▄\r\n────────▌▐░▀░▀░▀▐\r\n────────▌░▌░░░░░▐\r\n────────▌░░░░░░░▐\r\n────────▄▄▄▄▄▄▄▄▄\r\n──▄▀▀▀▀▀▌▄█▄░▄█▄▐▀▀▀▀▀▄\r\n─█▒▒▒▒▒▐░░░░▄░░░░▌▒▒▒▒▒█\r\n▐▒▒▒▒▒▒▒▌░░░░░░░▐▒▒▒▒▒▒▒▌\r\n▐▒▒▒▒▒▒▒█░▀▀▀▀▀░█▒▒▒▒▒▒▒▌\r\n▐▒▒▒▒▒▒▒▒█▄▄▄▄▄█▒▒▒▒▒▒▒▒▌\r\n▐▒▒▒▒▐▒▒▒▒▒▒▒▒▒▒▒▒▐▒▒▒▒▒▌\r\n▐▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▌\r\n▐▒▒▒▒▒▐▒▒▒▒▒▒▒▒▒▒▒▌▒▒▒▒▒▌\r\n▐▒▒▒▒▒▒▌▒▒▒▒▒▒▒▒▒▐▒▒▒▒▒▒▌\r\n▐▒▒▒▒▒▒▌▄▄▄▄▄▄▄▄▄▐▒▒▒▒▒▒▌\r\n▐▄▄▄▄▄▄▌▌███████▌▐▄▄▄▄▄▄▌\r\n─█▀▀▀▀█─▌███▌███▌─█▀▀▀▀█\r\n─▐░░░░▌─▌███▌███▌─▐░░░░▌\r\n──▀▀▀▀──▌███▌███▌──▀▀▀▀\r\n────────▌███▌███▌\r\n────────▌███▌███▌\r\n──────▐▀▀▀██▌█▀▀▀▌\r\n▒▒▒▒▒▒▐▄▄▄▄▄▄▄▄▄▄▌▒▒▒▒▒▒▒\r\n");
                        Thread.Sleep(1000);

                        string text9 = "...";
                        foreach (char c in text9)
                        {
                            Console.Write(c);
                            Thread.Sleep(500);
                        }

                        string text10 = "haha";
                        foreach (char c in text10)
                        {
                            Console.Write(c);
                            Thread.Sleep(100);
                        }
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Tryck enter för meny");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Thread.Sleep(300);
                        string text11 = "Ej giltigt!";
                        foreach (char c in text11)
                        {
                            Console.Write(c);
                            Thread.Sleep(50);
                        }
                        Thread.Sleep(300);
                        Console.WriteLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
