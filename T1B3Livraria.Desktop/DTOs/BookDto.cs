using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1B3Livraria.Desktop.DTOs
{
    public class BookResponseDto
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

    public class CreateBookDto
    {
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Editora { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }
    }

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

