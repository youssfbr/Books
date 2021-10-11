using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Context
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) :  base(options) { }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}
 