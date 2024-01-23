using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LijstMenu
{
    public static string[] menuLijstArray = {"Klantenlijst weergeven", "Lijst toepassen", "Afsluiten", "Klant toevoegen", "Klant aanpassen", "Klant verwijderen" };
    public static bool codeRunning = true;
    public static bool laatHLzien = true;

    public static void hoofdLijst()
    {
        Console.WriteLine(menuLijstArray[0]);
        Console.WriteLine(menuLijstArray[1]);
        Console.WriteLine(menuLijstArray[2]);
        Console.WriteLine(" ");
    }

    public static void klantToepassenLijst()
    {
        Console.WriteLine(menuLijstArray[3]);
        Console.WriteLine(menuLijstArray[4]);
        Console.WriteLine(menuLijstArray[5]);
        Console.WriteLine(" ");
    }

    public static void LaatHoofdLijstZien(bool LHLZ)
    {
        if(LHLZ)
        {
            hoofdLijst();
        }
    }

    public static void lijstControls()
    {
        string input = Console.ReadLine().ToLower();
        Console.WriteLine(" ");
        switch (input)
        {
            case "klantenlijst weergeven":
                KlantAanpassen.lijstWeergeven();
                break;
            case "lijst toepassen":
                laatHLzien = false;
                Console.WriteLine(" ");
                klantToepassenLijst();
                break;
            case "afsluiten":
                codeRunning = false;
                break;
            case "klant toevoegen":
                KlantAanpassen.klantToevoegen();
                break;
            case "klant aanpassen":
                KlantAanpassen.klantAanpassen();
                break;
            case "klant verwijderen":
                KlantAanpassen.klantVerwijderen();
                break;

            default:
                Console.WriteLine("Niet geldig");
                Console.WriteLine(" ");
                break;
        }
     }
}
