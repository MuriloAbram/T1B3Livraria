using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1B3Livraria.Desktop.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Editora { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public bool IsFeatured { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    /// <summary>
    /// DTO para criação de um novo Game.
    /// Contém apenas os campos que o usuário precisa preencher.
    /// Note que Id e CreatedAt NÃO estão aqui — são gerados automaticamente.
    /// </summary>
    public class CreateBookDto
    {
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Editora { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }
    }

    /// <summary>
    /// DTO para atualização de um Game existente.
    /// </summary>
    public class UpdateBookDto
    {
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Editora { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int AnoPublicacao { get; set; }
        public bool IsFeatured { get; set; }
    }
}

