using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalWebAPI.Models;

namespace ProjetoFinalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly BaseFinalDeDadosContext _context;

        public UsuariosController(BaseFinalDeDadosContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario()
        {
            return await _context.Usuario.ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        [EnableCors("MyPolicy")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            var arrayUsu = _context.Usuario.ToList<Usuario>();
            foreach (var item in arrayUsu)
            {
                if (item.Login == usuario.Login)
                    return NotFound();
            }

            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
        }

        [HttpPost("validate")]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<bool>> ValidaUsuario(Usuario usuario)
        {
            var arrayUsu = _context.Usuario.ToList<Usuario>();
            foreach (var item in arrayUsu)
            {
                if (item.Login == usuario.Login && item.Senha == usuario.Senha)
                    return true;
            }
            return false;
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<Usuario>> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.Id == id);
        }
    }
}
