﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Klant
{
    public string naam;
    public string leeftijd;
    public string email;
    public string check;

    public Klant(string naam, string leeftijd, string email)
    {
        this.naam = naam;
        this.leeftijd = leeftijd;
        this.email = email;
    }
}
