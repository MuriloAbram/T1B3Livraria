using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using T1B3Livraria.Application.DTOs;
using T1B3Livraria.Application.Interfaces;


namespace T1B3Livraria.API.Controllers
{
    [ApiController]           // Define que esta classe responde a requisições HTTP (JSON)
    [Route("api/[controller]")] // A rota será: localhost:porta/api/usuarios
    [Authorize]               // Exige que o cliente esteja logado com um token/cookie
    public class UsuariosController : ControllerBase
    {


        private readonly IUsuariosService _usuariosService;

        public UsuariosController(IUsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [HttpGet] // GET /api/usuarios
        public async Task<IActionResult> GetAll()
        {
            var usuarios = await _usuariosService.GetAllAsync();
            return Ok(usuarios); // Retorna HTTP 200 com a lista em JSON
        }

        [HttpPost] // POST /api/usuarios
        public async Task<IActionResult> Create([FromBody] CreateUsuarioDto dto)
        {
            var (success, usuario, error) = await _usuariosService.CreateAsync(dto);
            if (!success)
                return BadRequest(new { message = error }); // HTTP 400
            return Ok(usuario); // HTTP 200
        }

        [HttpDelete("{id}")] // DELETE /api/usuarios/{id}
        public async Task<IActionResult> Delete(string id)
        {
            var (success, error) = await _usuariosService.DeleteAsync(id);
            if (!success)
                return BadRequest(new { message = error }); // HTTP 400
            return NoContent(); // HTTP 204
        }

        [HttpPut("{id}")] // PUT /api/usuarios/{id}
        public async Task<IActionResult> Update(string id, [FromBody] UpdateUsuarioDto dto)
        {
            var (success, usuario, error) = await _usuariosService.UpdateAsync(id, dto);
            if (!success)
                return BadRequest(new { message = error }); // HTTP 400
            return Ok(usuario); // HTTP 200
        }
    }
}