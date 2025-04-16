using System;

public class Livre
{
    public int LivreId { get; set; }
    public string Titre { get; set; }
    public DateTime DatePublication { get; set; }

    public int AuteurId { get; set; }
    public Auteur Auteur { get; set; }
}