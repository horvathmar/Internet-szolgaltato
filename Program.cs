using System.Text;

namespace Internet_szolgaltato
{
    internal class Program
    {
        static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        static int menuIndex = 0;
        static string[] menuOptions = { "Ügyfél létrehozása", "Ügyfelek listázása", "Ügyfél kérés küldése", "Kilépés" };

        static void Main()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.WriteLine("Internet Szolgáltató Hálózat Szimuláció\n");
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    if (i == menuIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {menuOptions[i]} <");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(menuOptions[i]);
                    }
                }

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    menuIndex = (menuIndex == 0) ? menuOptions.Length - 1 : menuIndex - 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    menuIndex = (menuIndex == menuOptions.Length - 1) ? 0 : menuIndex + 1;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (menuIndex)
                    {
                        case 0:
                            UjUgyfel();
                            break;
                        case 1:
                            ListazUgyfelek();
                            break;
                        case 2:
                            Kuldes();
                            break;
                        case 3:
                            return;
                    }
                }
            } while (true);
        }

        static void UjUgyfel()
        {
            Console.Write("Add meg az ügyfél nevét: ");
            string nev = Console.ReadLine();
            string jelszo = "";
            do
            {
                Console.Write("Add meg a 6 jegyű jelszót (csak számok): ");
                jelszo = BekerJelszo();
            } while (jelszo.Length != 6 || !int.TryParse(jelszo, out _));
            ugyfelek.Add(new Ugyfel(nev, jelszo));
            Console.WriteLine("Ügyfél létrehozva! Nyomj meg egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        static void ListazUgyfelek()
        {
            Console.WriteLine("Regisztrált ügyfelek:");
            foreach (var ugyfel in ugyfelek)
            {
                Console.WriteLine($"Név: {ugyfel.Nev}, Jelszó: ******");
            }
            Console.WriteLine("Nyomj meg egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        static void Kuldes()
        {
            if (ugyfelek.Count == 0)
            {
                Console.WriteLine("Nincs regisztrált ügyfél!");
                Console.ReadKey();
                return;
            }
            Console.Write("Válassz ügyfelet (0 - {0}): ", ugyfelek.Count - 1);
            int index = int.Parse(Console.ReadLine());
            Ugyfel ugyfel = ugyfelek[index];
            Console.Write("Írd be az adatot, amit küldeni szeretnél: ");
            string adat = Console.ReadLine();
            Router router = new Router("Fő Router");
            Szerver szerver = new Szerver("Fő Szerver");
            InternetCsomag csomag = ugyfel.Kuldes(adat);
            router.Tovabbitas(csomag, szerver);
            Console.WriteLine($"Adat sikeresen továbbítva! Elküldés ideje: {DateTime.Now.Hour}:{DateTime.Now.Minute}");
            Console.WriteLine("Nyomj meg egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        static string BekerJelszo()
        {
            StringBuilder jelszo = new StringBuilder();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (char.IsDigit(key.KeyChar) && jelszo.Length < 6)
                {
                    jelszo.Append(key.KeyChar);
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && jelszo.Length > 0)
                {
                    jelszo.Remove(jelszo.Length - 1, 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return jelszo.ToString();
        }
    }





    //static void Main(string[] args)
    //{

    //    string[] menuItems = { "Új felhasználó létrehozása", "Jelszó megváltoztatása", "Felhasználók megtekintése", "Option 4" };
    //    int selectedOption = ShowMenu(menuItems);

    //    Console.Clear();
    //    Console.WriteLine($"{menuItems[selectedOption]}");
    //    foreach (var item in menuItems)
    //    {
    //        if (menuItems[0] == menuItems[selectedOption])
    //        {
    //            Uj_felhasznalo();
    //            return;
    //        }
    //        if (menuItems[1] == menuItems[selectedOption])
    //        {
    //            Jelszo_megvaltoztatasa();
    //            return;
    //        }
    //        if (menuItems[2] == menuItems[selectedOption])
    //        {
    //            Felhasznalok_kiirasa();
    //            return;
    //        }
    //    }


    //    //Console.WriteLine("Új fiók létrehozása");


    //}

    //static int ShowMenu(string[] menuItems)
    //{
    //    int currentSelection = 0;

    //    while (true)
    //    {
    //        Console.Clear();
    //        DisplayMenu(menuItems, currentSelection);

    //        ConsoleKeyInfo key = Console.ReadKey(intercept: true);

    //        if (key.Key == ConsoleKey.UpArrow)
    //        {
    //            currentSelection = (currentSelection == 0) ? menuItems.Length - 1 : currentSelection - 1;
    //        }
    //        else if (key.Key == ConsoleKey.DownArrow)
    //        {
    //            currentSelection = (currentSelection == menuItems.Length - 1) ? 0 : currentSelection + 1;
    //        }
    //        else if (key.Key == ConsoleKey.Enter)
    //        {
    //            return currentSelection;
    //        }
    //    }
    //}

    //static void DisplayMenu(string[] menuItems, int selectedIndex)
    //{
    //    for (int i = 0; i < menuItems.Length; i++)
    //    {
    //        if (i == selectedIndex)
    //        {
    //            Console.BackgroundColor = ConsoleColor.White;
    //            Console.ForegroundColor = ConsoleColor.Black;
    //            Console.WriteLine($"\t{menuItems[i]}");
    //            Console.ResetColor();
    //        }
    //        else
    //        {
    //            Console.WriteLine($"\t{menuItems[i]}");
    //        }
    //    }
    //}

    //static void Uj_felhasznalo()
    //{
    //    Console.Write("Név: ");
    //    string nev1 = Console.ReadLine();
    //    Console.Write("Jelszó: ");
    //    int j1 = int.Parse(Console.ReadLine());
    //    try
    //    {
    //        //Ugyfel p1 = new Ugyfel(nev1, j1);
    //        Console.WriteLine($"{nev1} sikeresen csatlakozott a hálózathoz.");
    //        //Felhasznalo p2 = new Felhasznalo("Gezuka", 1234567);

    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
}

