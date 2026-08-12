using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1B3Livraria.Domain.Entities
{
    public class Category
    {
        /// <summary>
        /// Identificador único da categoria (chave primária).
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
