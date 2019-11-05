using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiObjeto.Model;
using WebApiObjeto.Models;

namespace WebApiObjeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetosController : ControllerBase
    {
        private readonly WebApiObjetoContext _context;

        public ObjetosController(WebApiObjetoContext context)
        {
            _context = context;
        }

        // GET: api/Objetos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objeto>>> GetObjeto()
        {
            return await _context.Objeto.ToListAsync();
        }

        // GET: api/Objetos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Objeto>> GetObjeto(int id)
        {
            var objeto = await _context.Objeto.FindAsync(id);

            if (objeto == null)
            {
                return NotFound();
            }

            return objeto;
        }

        [HttpGet("{densidade}/{volume}")]
        public async Task<ActionResult<double>> CalculaPeso(double densidade,double volume)
        { 
            return densidade * volume;
        }

        // PUT: api/Objetos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjeto(int id, Objeto objeto)
        {
            if (id != objeto.Id)
            {
                return BadRequest();
            }

            _context.Entry(objeto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjetoExists(id))
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

        // POST: api/Objetos
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Objeto>> PostObjeto(Objeto objeto)
        {
            _context.Objeto.Add(objeto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObjeto", new { id = objeto.Id }, objeto);
        }

        // DELETE: api/Objetos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Objeto>> DeleteObjeto(int id)
        {
            var objeto = await _context.Objeto.FindAsync(id);
            if (objeto == null)
            {
                return NotFound();
            }

            _context.Objeto.Remove(objeto);
            await _context.SaveChangesAsync();

            return objeto;
        }

        private bool ObjetoExists(int id)
        {
            return _context.Objeto.Any(e => e.Id == id);
        }
    }
}
