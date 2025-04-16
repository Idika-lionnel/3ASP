using System;

namespace ConsoleApp1
{
    public enum Genre
    {
        Roman,
        ScienceFiction,
        Biographie,
        Fantastique
    }

    public class Livre
    {
        public string Titre;
        public string Auteur;
        public int NombrePages;
        public DateTime DatePublication;
        public bool Disponible;
        public Genre Genre;

        public Livre(string titre, string auteur, int nombrePages, DateTime datePublication, bool disponible, Genre genre)
        {
            Titre = titre;
            Auteur = auteur;
            NombrePages = nombrePages;
            DatePublication = datePublication;
            Disponible = disponible;
            Genre = genre;
        }

        public Livre(Livre autre)
        {
            Titre = autre.Titre;
            Auteur = autre.Auteur;
            NombrePages = autre.NombrePages;
            DatePublication = autre.DatePublication;
            Disponible = autre.Disponible;
            Genre = autre.Genre;
        }

        public void AfficherInfos()
        {
            Console.WriteLine("Titre : " + Titre);
            Console.WriteLine("Auteur : " + Auteur);
            Console.WriteLine("Nombre de pages : " + NombrePages);
            Console.WriteLine("Date de publication : " + DatePublication.ToString("dd/MM/yyyy"));
            Console.WriteLine("Disponible : " + (Disponible ? "Oui" : "Non"));
            Console.WriteLine("Genre : " + Genre);
        }

        public int TempsLectureEnMinutes()
        {
            return NombrePages / 2;
        }
    }

    public class Enumération
    {
        public static void Main(string[] args)
        {
            Livre livre = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", 96, new DateTime(1943, 4, 6), true, Genre.Roman);
            livre.AfficherInfos();
            Console.WriteLine("Temps estimé de lecture : " + livre.TempsLectureEnMinutes() + " minutes");

            Livre copie = new Livre(livre);
            Console.WriteLine("\nCopie du livre :");
            copie.AfficherInfos();
        }
    }
}