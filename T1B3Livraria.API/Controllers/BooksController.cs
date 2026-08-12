using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using T1B3Livraria.Application.DTOs;
using T1B3Livraria.Application.Interfaces;


namespace T1B3Livraria.API.Controllers

{
    /// <summary>
    /// Controller REST para operações com Games.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _BookService;

        //  CONCEITO: O serviço é injetado automaticamente pelo .NET (DI)
        public BookController(IBookService BookService)
        {
            _BookService = BookService;
        }

        /// <summary>
        /// Retorna todos os games.
        /// GET /api/games
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetAll()
        {
            var livros = await _BookService.GetAllAsync();
            return Ok(livros);
        }

        /// <summary>
        /// Busca um game específico pelo Id.
        /// GET /api/games/{id}
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<BookDto>> GetById(int id)
        {
            var livro = await _BookService.GetByIdAsync(id);

            if (livro == null)
                return NotFound(new { message = "Livros não encontrado." });

            return Ok(livro);
        }

        /// <summary>
        /// Cria um novo game.
        /// POST /api/games
        /// Requer autenticação (somente admin pode criar games).
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<BookDto>> Create([FromBody] CreateBookDto dto)
        {
            var livro = await _BookService.CreateAsync(dto);

            // Retorna 201 Created com a URL do recurso criado
            return CreatedAtAction(nameof(GetById), new { id = livro.Id }, livro);
        }

        /// <summary>
        /// Atualiza um game existente.
        /// PUT /api/games/{id}
        /// </summary>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<BookDto>> Update(int id, [FromBody] UpdateBookDto dto)
        {
            var livro = await _BookService.UpdateAsync(id, dto);

            if (livro == null)
                return NotFound(new { message = "Livro não encontrado." });

            return Ok(livro);
        }

        /// <summary>
        /// Remove um game.
        /// DELETE /api/games/{id}
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _BookService.DeleteAsync(id);

            if (!deleted)
                return NotFound(new { message = "Livro não encontrado." });

            return NoContent(); // Retorna 204 No Content (sucesso sem corpo)
        }
    }
}
