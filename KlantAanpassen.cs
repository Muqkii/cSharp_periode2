using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class KlantAanpassen
{
    public static List<Klant> deLijst = new List<Klant>();
    public static int i = 1;
    public static string j;

    public static void lijstWeergeven()
    {
        int counting = 0;
        foreach (var item in deLijst)
        {
            Console.WriteLine(deLijst[counting].nummer);
            Console.WriteLine(" ");
            Console.WriteLine(deLijst[counting].naam);
            Console.WriteLine(deLijst[counting].leeftijd);
            Console.WriteLine(deLijst[counting].email);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            counting++;
        }
    }

    public static void klantToevoegen()
    {
        Console.WriteLine("Naam van klant: ");
        string naam = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("Leeftijd van klant: ");
        string leeftijd = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("E-mail van klant: ");
        string email = Console.ReadLine();
        Console.WriteLine(" ");
        j = Convert.ToString(i);
        deLijst.Add(new Klant("Klant #" + j, naam, leeftijd, email));
        LijstMenu.laatHLzien = true;
        i++;
    }

    public static void klantAanpassen()
    {
        int klantNum;
        Console.WriteLine("Welke klant will je bewerken?: ");
        string klantNumStr = Console.ReadLine();
        Console.WriteLine(" ");

        try
        {
            int.TryParse(klantNumStr, out klantNum);

            klantNum -= 1;
            deLijst[klantNum].check = "test";
            Console.WriteLine("Bewerk naam van klant: ");
            string nNaam = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Bewerk leeftijd van klant: ");
            string nLeeftijd = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Bewerk e-mail van klant: ");
            string nEmail = Console.ReadLine();
            Console.WriteLine(" ");
            deLijst[klantNum].naam = nNaam;
            deLijst[klantNum].leeftijd = nLeeftijd;
            deLijst[klantNum].email = nEmail;
        }
        catch (Exception e)
        {
            Console.WriteLine("Ongeldige klant nummer.");
            Console.WriteLine(" ");
        }

        LijstMenu.laatHLzien = true;
    }

    public static void klantVerwijderen()
    {
        int klantNum;
        Console.WriteLine("Welke klant wil je verwijderen?: ");
        string klantNumStr = Console.ReadLine();
        Console.WriteLine(" ");
        if (int.TryParse(klantNumStr, out klantNum))
        {
            klantNum -= 1;
            deLijst.RemoveAt(klantNum);
        }
        else
        {
            Console.WriteLine("Ongeldige klant nummer.");
            Console.WriteLine(" ");
        }
        LijstMenu.laatHLzien = true;
    }
}
