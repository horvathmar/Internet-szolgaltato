namespace Internet_szolgaltato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Új fiók létrehozása");
            Console.Write("Név: ");
            string nev1 = Console.ReadLine();
            Console.Write("Jelszó: ");
            int j1 = int.Parse(Console.ReadLine());
            try
            {
                Felhasznalo p1 = new Felhasznalo(nev1, j1);
                Console.WriteLine($"{nev1} sikeresen csatlakozott a hálózathoz.");
                //Felhasznalo p2 = new Felhasznalo("Gezuka", 1234567);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
