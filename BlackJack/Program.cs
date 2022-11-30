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
                Console.WriteLine("1. Spela BlackJack");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmet");

                int val = int.Parse(Console.ReadLine());

                switch(val)
                {
                    case 1:
                        Random KortSpelare = new Random();
                        Random KortDator = new Random();
                        Random DatorDraKort = new Random();

                        int DatorDra = DatorDraKort.Next(1,2);
                        int SumSpelare = 0;
                        int SumDator = 0;

                        bool Spel = true;

                        while (Spel == true)
                        {
                            string Dra = "j";
                            
                            SumDator = SumDator + KortDator.Next(1,14);

                            while (Dra == "j")
                            {
                                Console.WriteLine("Nu kommer du och datorn få varist kort");
                                Console.WriteLine($"Dina poäng:{SumSpelare}");
                                Console.WriteLine("Datorns poäng: ?");
                                Console.WriteLine("");
                                Console.WriteLine("Vill du dra ett till kort? j/n");
                            }
                            Dra = Console.ReadLine();

                            switch (Dra)
                            {
                                case "j":
                                    SumSpelare = SumSpelare + KortSpelare.Next(1, 14);
                                    break;

                                default:
                                    break;

                            }

                        }
                        break;


                    case 2:
                        Console.WriteLine();
                        break;


                    case 3:
                        Thread.Sleep(1000);
                        Console.WriteLine("");
                        Console.WriteLine("Målet i Blackjack är att få en bättre hand än dealern. För att göra det, måste du");
                        Console.WriteLine("ha en hand som är högre än dealerns, utan att handens totala värde överstiger");
                        Console.WriteLine("21. Du kan även vinna genom att ha ett totalt värde under 22 när det totala värdet");
                        Console.WriteLine("på dealerns hand överstiger 21.");
                        Console.WriteLine("");
                        break;


                    case 4:
                        Console.Write("Programmet avslutas");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Avsluta = true;
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
