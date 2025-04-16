using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using (var db = new BibliothequeContext())
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var jeffrey = new Auteur
            {
                Nom = "Jeffrey burluraux",
                DateNaissance = new DateTime(2002, 2, 26)
            };

            var musa = new Auteur
            {
                Nom = "Musa adamu",
                DateNaissance = new DateTime(2004, 2, 8)
            };

            jeffrey.Bibliographie.Add(new Livre
            {
                Titre = "Awoko Master ",
                DatePublication = new DateTime(2012, 1, 1)
            });

            jeffrey.Bibliographie.Add(new Livre
            {
                Titre = "Ayimolou vivina",
                DatePublication = new DateTime(2014, 1, 1)
            });

            musa.Bibliographie.Add(new Livre
            {
                Titre = "Zemidjan",
                DatePublication = new DateTime(2020, 1, 1)
            });

            db.Auteurs.AddRange(jeffrey, musa);
            db.SaveChanges();

            //Requête de test : afficher tous les livres avec leur auteur
            var tousLesLivres = db.Livres.Include(l => l.Auteur).ToList();

            Console.WriteLine("Livres et leurs auteurs :");
            foreach (var livre in tousLesLivres)
            {
                Console.WriteLine($"- {livre.Titre} ({livre.DatePublication.Year}) par {livre.Auteur.Nom}");
            }
        }
    }
}