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

        /// <summary>
        /// Cria um novo book via POST /api/books.
        /// Requer perfil Admin (verificado pela API).
        /// </summary>
        /// <param name="dto">Dados do book a ser criado</param>
        /// <returns>Book criado ou null em caso de erro</returns>
        public async Task<(bool Success, BookResponseDto? Book, string ErrorMessage)>
            CreateAsync(CreateBookDto dto)
        {
            return await _http.PostAsync<GameResponseDto>("/api/games", dto);
        }

        /// <summary>
        /// Atualiza um game existente via PUT /api/games/{id}.
        /// Requer perfil Admin (verificado pela API).
        /// </summary>
        public async Task<(bool Success, GameResponseDto? Game, string ErrorMessage)>
            UpdateAsync(int id, UpdateGameDto dto)
        {
            return await _http.PutAsync<GameResponseDto>($"/api/games/{id}", dto);
        }

        /// <summary>
        /// Exclui um game via DELETE /api/games/{id}.
        /// Requer perfil Admin (verificado pela API).
        /// </summary>
        public async Task<(bool Success, string ErrorMessage)> DeleteAsync(int id)
        {
            return await _http.DeleteAsync($"/api/games/{id}");
        }
    }
}
