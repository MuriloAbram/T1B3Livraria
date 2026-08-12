using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1B3Livraria.Application.DTOs;
using T1B3Livraria.Application.Interfaces;
using T1B3Livraria.Domain.Entities;
using T1B3Livraria.Domain.Interfaces;

namespace T1B3Livraria.Application.Services
{
    public class BookService : IBookService
    {
        //  CONCEITO: Injeção de Dependência
        // O repositório é injetado via construtor. Isso permite que o .NET
        // forneça automaticamente a implementação correta em tempo de execução.
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        /// <summary>
        /// Retorna todos os livros convertidos em DTOs.
        /// </summary>
        public async Task<IEnumerable<BookDto>> GetAllAsync()
        {
            var books = await _bookRepository.GetAllAsync();
            return books.Select(MapToDto);
        }

        public async Task<BookDto?> GetByIdAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            return book == null ? null : MapToDto(book);
        }

        public async Task<IEnumerable<BookDto>> GetFeaturedAsync()
        {
            var books = await _bookRepository.GetFeaturedAsync();
            return books.Select(MapToDto);
        }

        public async Task<IEnumerable<BookDto>> GetByCategoryAsync(int categoryId)
        {
            var books = await _bookRepository.GetByCategoryAsync(categoryId);
            return books.Select(MapToDto);
        }

        public async Task<BookDto> CreateAsync(CreateBookDto dto)
        {
            // Mapeia o DTO de criação para a entidade Book
            var book = new Book
            {
                Title = dto.Title,
                Autor = dto.Autor,
                AnoPublicacao = dto.AnoPublicacao,
                Editora = dto.Editora,
                CategoryId = dto.CategoryId,
                IsFeatured = dto.IsFeatured,
                CreatedAt = DateTime.Now
            };

            await _bookRepository.AddAsync(book);

            // Retorna o book criado como DTO
            return MapToDto(book);
        }
        public async Task<BookDto?> UpdateAsync(int id, UpdateBookDto dto)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            if (book == null) return null;

            // Atualiza os campos do book com os dados do DTO
            book.Title = dto.Title;
            book.Autor = dto.Autor;
            book.AnoPublicacao = dto.AnoPublicacao;
            book.Editora = dto.Editora;
            book.CategoryId = dto.CategoryId;
            book.IsFeatured = dto.IsFeatured;

            await _bookRepository.UpdateAsync(book);
            return MapToDto(book);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            if (book == null) return false;

            await _bookRepository.DeleteAsync(id);
            return true;
        }

        public async Task<int> CountAsync()
        {
            return await _bookRepository.CountAsync();
        }

        private static BookDto MapToDto(Book book)
        {
            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Autor = book.Autor,
                Editora = book.Editora,
                AnoPublicacao = book.AnoPublicacao,
                CategoryId = book.CategoryId,
                CategoryName = book.Category?.Name ?? string.Empty,
                IsFeatured = book.IsFeatured,
                CreatedAt = book.CreatedAt
            };
        }
    }
}
