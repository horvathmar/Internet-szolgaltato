namespace Internet_szolgaltato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] menuItems = { "Új felhasználó létrehozása", "Jelszó megváltoztatása", "Felhasználók megtekintése", "Option 4" };
            int selectedOption = ShowMenu(menuItems);

            Console.Clear();
            Console.WriteLine($"{menuItems[selectedOption]}");
            foreach (var item in menuItems)
            {
                if (menuItems[0] == menuItems[selectedOption])
                {
                    Uj_felhasznalo();
                    return;
                }
                if (menuItems[1] == menuItems[selectedOption])
                {
                    Jelszo_megvaltoztatasa();
                    return;
                }
                if (menuItems[2] == menuItems[selectedOption])
                {
                    Felhasznalok_kiirasa();
                    return;
                }
            }


            //Console.WriteLine("Új fiók létrehozása");


        }

        static int ShowMenu(string[] menuItems)
        {
            int currentSelection = 0;

            while (true)
            {
                Console.Clear();
                DisplayMenu(menuItems, currentSelection);

                ConsoleKeyInfo key = Console.ReadKey(intercept: true);

                if (key.Key == ConsoleKey.UpArrow)
                {
                    currentSelection = (currentSelection == 0) ? menuItems.Length - 1 : currentSelection - 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    currentSelection = (currentSelection == menuItems.Length - 1) ? 0 : currentSelection + 1;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    return currentSelection;
                }
            }
        }

        static void DisplayMenu(string[] menuItems, int selectedIndex)
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"\t{menuItems[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"\t{menuItems[i]}");
                }
            }
        }

        static void Uj_felhasznalo()
        {
            Console.Write("Név: ");
            string nev1 = Console.ReadLine();
            Console.Write("Jelszó: ");
            int j1 = int.Parse(Console.ReadLine());
            try
            {
                //Ugyfel p1 = new Ugyfel(nev1, j1);
                Console.WriteLine($"{nev1} sikeresen csatlakozott a hálózathoz.");
                //Felhasznalo p2 = new Felhasznalo("Gezuka", 1234567);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Jelszo_megvaltoztatasa()
        {

        }
        static void Felhasznalok_kiirasa()
        {

        }
    }

}

