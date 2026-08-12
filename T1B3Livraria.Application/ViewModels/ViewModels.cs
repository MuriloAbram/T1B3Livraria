using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1B3Livraria.Application.DTOs;

namespace T1B3Livraria.Application.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<BookDto> FeaturedBooks { get; set; } = new List<BookDto>();
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public IEnumerable<BookDto> RecentBooks { get; set; } = new List<BookDto>();
    }

    public class BookDetailsViewModel
    {
        public BookDto Book { get; set; } = new BookDto();
        public IEnumerable<BookDto> RelatedBooks { get; set; } = new List<BookDto>();
    }

    public class DashboardViewModel
    {
        public int TotalBooks { get; set; }
        public int TotalCategories { get; set; }
        public int FeaturedBooks { get; set; }
        public IEnumerable<BookDto> RecentBooks { get; set; } = new List<BookDto>();
    }

    public class BookFormViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
    }

    public class BookListViewModel
    {
        public IEnumerable<BookDto> Books { get; set; } = new List<BookDto>();
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public int? SelectedCategoryId { get; set; }
    }
}
