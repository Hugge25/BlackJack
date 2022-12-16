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

            string[] Vinnarna = { "Tom", "Tom", "Tom" };

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
                Console.WriteLine("    69. ? ");
                Console.WriteLine();

                string val = (Console.ReadLine());

                switch (val)
                {
                    case "1":
                        Console.Clear();
                        int DatorDra = 0;
                        int SumSpelare = 0;
                        int SumDator = 0;

                        SumSpelare = SumSpelare + KortSpelare.Next(1, 11);
                        SumDator = SumDator + KortDator.Next(1, 11);


                        bool Spel = true;

                        string Dra = "j";

                        while (Spel == true)
                        {



                            switch (Dra)
                            {
                                case "j":
                                    DatorDraKort.Next(1, 3);
                                    DatorDra = DatorDraKort.Next(1, 3);

                                    SumSpelare = SumSpelare + KortSpelare.Next(1, 11);

                                    DatorDra = 2;

                                    if (DatorDra == 2)
                                    {
                                        SumDator = SumDator + KortDator.Next(1, 11);
                                    }
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
                                    break;


                                case "n":
                                    DatorDraKort.Next(1, 3);
                                    DatorDra = DatorDraKort.Next(1, 3);

                                    if (DatorDra == 2)
                                    {
                                        SumDator = SumDator + KortDator.Next(1, 11);
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("    Nu kommer du och datorn få varist kort");
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"    Dina poäng:{SumSpelare}");
                                    Thread.Sleep(1000);
                                    Console.WriteLine($"    Datorns poäng: {SumDator}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Thread.Sleep(1000);
                                    Console.WriteLine();
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

                            if (SumSpelare < 21 && SumDator < 21)
                            {
                                Console.WriteLine("    Vill du dra ett till kort? j/n");
                                Console.WriteLine();
                                Dra = Console.ReadLine();
                            }

                            if (SumSpelare == 21 || SumDator > 21)
                            {
                                Console.WriteLine("    Du har vunnit!!!");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.Write("Skriv ditt namn: ");

                                if (Vinnarna[0] == "Tom")
                                {
                                    Vinnarna[0] = Console.ReadLine();
                                }

                                else if (Vinnarna[1] == "Tom" && Vinnarna[0] != "Tom")
                                {
                                    Vinnarna = Vinnarna.Skip(value + 1).Concat(Vinnarna.Take(value + 1)).ToArray();
                                    Vinnarna[0] = Console.ReadLine();
                                }

                                else if (Vinnarna[2] == "Tom" && Vinnarna[1] != "Tom")
                                {
                                    Vinnarna = Vinnarna.Skip(value + 1).Concat(Vinnarna.Take(value + 1)).ToArray();
                                    Vinnarna[0] = Console.ReadLine();
                                }

                                else if (Vinnarna[2] != "Tom")
                                {
                                    Vinnarna = Vinnarna.Skip(value + 1).Concat(Vinnarna.Take(value + 1)).ToArray();
                                    Vinnarna[0] = Console.ReadLine();
                                }

                                Spel = false;
                            }

                            else if (SumDator == 21 || SumSpelare > 21)
                            {

                                Console.WriteLine("    Du förlorade, datorn vann :(");
                                Console.WriteLine();
                                Console.WriteLine();
                                Spel = false;
                            }
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine("Tryck enter för meny");
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
                        Console.WriteLine("Tryck enter för meny");
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
                        Console.WriteLine("Tryck enter för meny");
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

                    case "69":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("░░░░░░░░░░░░░░░░▓██████▓▓▓░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░█████▓▓█████████▓░░░░░░░░░░░\r\n░░░░░░░░░░█████▓░░▓█████████████░░░░░░░░░\r\n░░░░░░░░▓███▓░░░▓█████████████████░░░░░░░\r\n░░░░░░░███▓░░░░░███████████████████▓░░░░░\r\n░░░░░░███░░░░░░██████████████████████░░░░\r\n░░░░░███░░░░░░░███████████████████████░░░\r\n░░░░███░░░░░░░░███████░░░░██████████▓█▓░░\r\n░░░███▓░░░░░░░░███████░░░░▓██████████▓█░░\r\n░░▓███░░░░░░░░░░██████▓░░▓███████████▓██░\r\n░░████░░░░░░░░░░▓████████████████████▓▓█░\r\n░▓█░█▓░░░░░░░░░░░░████████████████████░██\r\n░██░█░░░░░░░░░░░░░░▓██████████████████░██\r\n░█▓░█░░░░░░░░░░░░░░░░░▓███████████████░▓█\r\n▓█▓░█▓░░░░░░░░░░░░░░░░░░██████████████░░█\r\n██░░██░░░░░░░░░░░▓▓░░░░░░▓████████████░░█\r\n██░▓░█░░░░░░░░░░████▓░░░░░███████████▓░░█\r\n██░█░██░░░░░░░░▓█████░░░░░░██████████░░▓█\r\n██░▓█░██░░░░░░░░████▓░░░░░░█████████░░▓▓█\r\n▓█░░█░░█▓░░░░░░░░▓▓░░░░░░░░████████▓░░▓██\r\n░█░░█▓░▓██░░░░░░░░░░░░░░░░░███████▓░░█▓█▓\r\n░██░███████▓░░░░░░░░░░░░░░██████████▓█▓█░\r\n░▓█░██▓░░░▓███░░░░░░░░░░▓██████▓░░░▓██▓█░\r\n░░███▓░░░░░░░███████████████▓░░░░░░░░██▓░\r\n░░░██░░▓▓█▓▓▓░░░▓████████▓░░░░▓▓█▓▓░░██░░\r\n░░░▓█░████████▓░░░░░░░░░░░░▓████████░▓█░░\r\n░░░█▓▓███████████░░░░░░░░████████████░█▓░\r\n░░░█░█████████████░░░░░░█████████████░██░\r\n░░▓█░▓████████████░░░░░░█████████████░░█░\r\n░░▓█░▓▓███████████░░░░░░███████████▓▓░░█░\r\n░░▓█░░░▓█████████░░░░░░░░█████████▓░░░░█░\r\n░░░█▓░░░████████░░░░░░░░░░████████░░░░██░\r\n░░░██░░░░░█████░░░░████░░░░█████▓░░░░░█▓░\r\n░░░░██░░░░░░░░░░░░██████░░░░░░░░░░▓░░██░░\r\n░░░░▓████▓░░░░░░░░███▓██▓░░░░░░░░█████░░░\r\n░░░░░▓█▓████▓░░░░░██░▓▓██░░░░▓████░██░░░░\r\n░░░░░░░░▓█▓██░▓░░░██▓▓▓██░░█▓█████░░░░░░░\r\n░░░░░░░░▓█░███▓░░░▓▓▓░▓░░░░░█▓██▓█░░░░░░░\r\n░░░░░░░░▓█░██▓░░▓░░░░░░░░░▓░███▓▓█░░░░░░░\r\n░░░░░░░░▓█░███▓███▓░░░░░▓███▓██░▓█░░░░░░░\r\n░░░░░░░░██░░██░▓░█████████░▓▓█▓░▓█░░░░░░░\r\n░░░░░░░░▓█░░▓██▓▓░░▓░█░█░▓░▓██░░░█░░░░░░░\r\n░░░░░░░░░█▓░░████░▓░░▓░░▓▓███░░░██░░░░░░░\r\n░░░░░░░░░▓█▓░░████████▓█████░░░██▓░░░░░░░\r\n░░░░░░░░░░░██░░▓▓▓▓▓▓▓▓▓▓▓█░░░██░░░░░░░░░\r\n░░░░░░░░░░░░██░░▓█████▓██▓░░▓██░░░░░░░░░░\r\n░░░░░░░░░░░░░██░░░░░▓▓░░░░░███░░░░░░░░░░░\r\n░░░░░░░░░░░░░░██░░░░░░░░░░██▓░░░░░░░░░░░░\r\n");

                        Thread.Sleep(1000);

                        string text9 = "...";
                        foreach (char c in text9)
                        {
                            Console.Write(c);
                            Thread.Sleep(500);
                        }

                        string text10 = "haha get pranked";
                        foreach (char c in text10)
                        {
                            Console.Write(c);
                            Thread.Sleep(100);
                        }
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Tryck enter för meny");
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
