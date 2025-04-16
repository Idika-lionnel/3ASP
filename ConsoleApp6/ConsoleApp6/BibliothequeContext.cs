using Microsoft.EntityFrameworkCore;

public class BibliothequeContext : DbContext
{
    public DbSet<Livre> Livres { get; set; }
    public DbSet<Auteur> Auteurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=bibliotheque.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auteur>()
            .HasMany(a => a.Bibliographie)
            .WithOne(l => l.Auteur)
            .HasForeignKey(l => l.AuteurId);
    }
}