using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Context
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) :  base(options) { }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .ToTable("Categoria")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Categoria>()
                .Property(x => x.Nome)
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<Categoria>()
                .HasMany(x => x.Livros)
                .WithOne(x => x.Categoria);


            modelBuilder.Entity<Autor>()
                .ToTable("Autor")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Autor>()
                .Property(x => x.Nome)                
                .HasMaxLength(60)
                .IsRequired();

            modelBuilder.Entity<Autor>()                
                .HasMany(x => x.Livros);
                //.WithMany(x => x.Autores);


            modelBuilder.Entity<Livro>()
                .ToTable("Livro")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Livro>()
                .Property(x => x.Nome)
                .HasMaxLength(60)
                .IsRequired();

            modelBuilder.Entity<Livro>()
                .Property(x => x.ISBN)
                .HasMaxLength(32)
                .IsRequired();

            modelBuilder.Entity<Livro>()
                .Property(x => x.DataLancamento)
                .IsRequired();
        }
    }
}
 