using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1B3Livraria.Desktop.DTOs;
using T1B3Livraria.Desktop.Helpers;

namespace T1B3Livraria.Desktop.Services
{
    public class BooksApiService
    {
        private readonly HttpClientHelper _http;

        public BooksApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        public async Task<List<BookResponseDto>> GetAllAsync()
        {
            try
            {
                var books = await _http.GetAsync<List<BookResponseDto>>("/api/books");
                return books ?? new List<BookResponseDto>();
            }
            catch
            {
                return new List<BookResponseDto>();
            }
        }

        public async Task<BookResponseDto> GetByIdAsync(int id)
        {
            return await _http.GetAsync<BookResponseDto>($"/api/books/{id}");
        }

        public async Task<(bool Success, BookResponseDto? Book, string ErrorMessage)>
            CreateAsync(CreateBookDto dto)
        {
            return await _http.PostAsync<BookResponseDto>("/api/books", dto);
        }

        public async Task<(bool Success, BookResponseDto? Book, string ErrorMessage)>
            UpdateAsync(int id, UpdateBookDto dto)
        {
            return await _http.PutAsync<BookResponseDto>($"/api/books/{id}", dto);
        }

        public async Task<(bool Success, string ErrorMessage)> DeleteAsync(int id)
        {
            return await _http.DeleteAsync($"/api/books/{id}");
        }
    }
}
