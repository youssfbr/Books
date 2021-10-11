﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Categoria
    {        
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo inválido")]
        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}