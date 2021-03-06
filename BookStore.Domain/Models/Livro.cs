using System;
using System.Collections.Generic;

namespace BookStore.Domain.Models
{
    public class Livro
    {           
        public int Id { get; set; }               
        public string Nome { get; set; }
        public string ISBN { get; set; }
        public DateTime DataLancamento { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<Autor> Autores { get; set; }
    }
}
