using System.ComponentModel.Design;
int playerWin = 0;
int playerAllWin = 0;
int machineWin = 0;
int machineAllWin = 0;
int draw = 0;
bool run = true;
bool game = true;
string gepValasztas = "";
string playerValasztas = "";

Konzol.Cim("Üdvözöllek a játékban!");

// főciklus
do
{ 
    // főmenü kiiratása
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("[1] új játék!");
    Console.WriteLine("[2] statisztika");
    Console.WriteLine("[3] statisztika nullázása");
    Console.WriteLine("[4] a tábla letörlése");
    Console.WriteLine("[k] kilépés");
    Console.ResetColor();

    Console.WriteLine("Kérlek válassz egy menüpontot: ");
    string menu = Console.ReadLine();
    Console.WriteLine();
    bool siker = int.TryParse(menu, out int menuszam);

    if (siker == true)
    {
        if (menuszam == 1)
        {
            Console.WriteLine("BO5");
            for (int korszam = 0; korszam < 5; korszam++) { 
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[1] = kő; [2] = papír; [3] = olló [4] = főmenü");
                Console.ResetColor();

                Console.Write("Mit mutatnál? ");
                string felhaszanalo = Console.ReadLine();
                bool siker2 = int.TryParse(felhaszanalo, out int userInput);

                if (userInput > 4 && userInput < 1 || siker2 == false)
                {
                    Console.WriteLine("Rossz bemenet");
                    Console.WriteLine();
                }

                else
                {
                    // játékmenet
                        int gepInput = Random.Shared.Next(1, 4);
                        if (gepInput == 1)
                        {
                            gepValasztas = "Kő";
                        }
                        else if (gepInput == 2)
                        {
                            gepValasztas = "Papír";
                        }
                        else
                        {
                            gepValasztas = "Olló";
                        }

                        if (userInput == 1)
                        {
                            playerValasztas = "Kő";
                        }
                        else if (userInput == 2)
                        {
                            playerValasztas = "Papír";
                        }
                        else
                        {
                            playerValasztas = "Olló";
                        }

                        if (userInput == 1 && gepInput == 3 || userInput == 2 && gepInput == 1 || userInput == 3 && gepInput == 2)
                        {
                            Konzol.Siker($"A játékos nyerte a kört! A játékos választása: {playerValasztas}");
                            Konzol.Hiba($"A gép választása: {gepValasztas}");
                            playerWin++;
                            Console.WriteLine();
                        }

                        else if (userInput == 3 && gepInput == 1 || userInput == 1 && gepInput == 2 || userInput == 2 && gepInput == 3)
                        {
                            Konzol.Hiba("A gép nyerte a kört! ");
                            Konzol.Siker($"A gép választása: {gepValasztas}");
                            Konzol.Hiba($"A játékos választása: {playerValasztas}");
                            machineWin++;                    
                            Console.WriteLine();
                        }

                        else if (userInput == 1 && gepInput == 1 || userInput == 2 && gepInput == 2 || userInput == 3 && gepInput == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Döntetlen kör!");
                            Console.WriteLine($"A gép választása: {gepValasztas}");
                            Console.WriteLine($"A játékos választása: {playerValasztas}");
                            Console.WriteLine();
                        }


                        else if (userInput == 4)
                        {
                            Console.WriteLine();
                            break;
                        }

                        else
                        {
                            Konzol.Hiba("Rossz bemenet!");
                        }

                        if (playerWin == 3 )
                        {
                            Konzol.Siker("A játékos megnyert 3 kört, így ő a végső nyertes");
                            playerAllWin++;
                            Console.WriteLine();
                            break;
                        }
                        else if (machineWin == 3)
                        {
                            Konzol.Siker("A gép megnyert 3 kört, így ő a végső nyertes");
                            machineAllWin++;
                            Console.WriteLine();
                            break;
                        }
                        else if (korszam == 4)
                        {
                            Console.ForegroundColor= ConsoleColor.Yellow;
                            Console.WriteLine("Döntetlen a végső eredmény!");
                            Console.WriteLine();
                            draw++;
                        }


                }

            }
        // statisztika kiiratása
        }
        else if (menuszam == 2)
        {
            Console.WriteLine($"A játékos győzelmeinek száma = {playerAllWin}, A gép győzelmeinek száma = {machineAllWin}, a döntetlenek száma = {draw}");
            Console.WriteLine();
        }
        // statisztika nullázása
        else if (menuszam == 3)
        {
            playerWin = 0;
            machineWin = 0;
            draw = 0;
            Console.WriteLine("A statisztika nullázva!");
            Console.WriteLine();
        }
        // konzol letörlése
        else if (menuszam == 4)
        {
            Console.Clear();
        }
        // rossz bemenet
        else
        {
            Konzol.Hiba("Rossz bemenet!");
        }
    }
    // kilépés
    else if (menu == "k" || menu == "K")
    {
        Console.WriteLine("A játéknak vége, köszönöm hogy itt voltál!");
        run = false;
    }
}
while (run);