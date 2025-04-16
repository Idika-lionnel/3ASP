using System;
using System.Collections.Generic;

public class Auteur
{
    public int AuteurId { get; set; }
    public string Nom { get; set; }
    public DateTime DateNaissance { get; set; }

    public List<Livre> Bibliographie { get; set; } = new List<Livre>();
}
