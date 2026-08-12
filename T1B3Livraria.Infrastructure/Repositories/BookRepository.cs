using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1B3Livraria.Domain.Entities;
using T1B3Livraria.Domain.Interfaces;
using T1B3Livraria.Infrastructure.Context;

namespace T1B3Livraria.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LivrariaDbContext _context;

        public BookRepository(LivrariaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.Books
                .Include(b => b.Category) 
                .OrderByDescending(b => b.CreatedAt)
                .ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            return await _context.Books
                .Include(b => b.Category)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Book>> GetFeaturedAsync()
        {
            return await _context.Books
                .Include(b => b.Category)
                .Where(b => b.IsFeatured)  // WHERE IsFeatured = true
                .ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Books
                .Include(b => b.Category)
                .Where(b => b.CategoryId == categoryId)
                .ToListAsync();
        }

        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> CountAsync()
        {
            return await _context.Books.CountAsync();
        }
    }
}
