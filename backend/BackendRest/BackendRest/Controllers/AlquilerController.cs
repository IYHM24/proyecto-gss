﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendRest.Data;
using BackendRest.Model;
using ServiceStack.Text;

namespace BackendRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : ControllerBase

    {



        private readonly BackendRestContext _context;

        public AlquilerController(BackendRestContext context)
        {
            _context = context;
        }

        // GET: api/Alquiler
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alquiler>>> GetAlquiler()
        {
          if (_context.Alquiler == null)
          {
              return NotFound();
          }
            return await _context.Alquiler.ToListAsync();
        }


        public BackendRestContext Get_context()
        {
            return _context;
        }

        // GET: api/Alquiler/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alquiler>> GetAlquiler(int id)
        {
          if (_context.Alquiler == null)
          {
              return NotFound();
          }
            var alquiler = await _context.Alquiler.FindAsync(id);

            if (alquiler == null)
            {
                return NotFound();
            }

            return alquiler;
        }

        // PUT: api/Alquiler/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlquiler(int id, Alquiler alquiler)
        {
            if (id != alquiler.id_alquiler)
            {
                return BadRequest();
            }

            _context.Entry(alquiler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlquilerExists(id))
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

        // POST: api/Alquiler
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Alquiler>> PostAlquiler(Alquiler alquiler)
        {
          if (_context.Alquiler == null)
          {
              return Problem("Entity set 'BackendRestContext.Alquiler'  is null.");
          }
            _context.Alquiler.Add(alquiler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlquiler", new { id = alquiler.id_alquiler }, alquiler);
        }

        // DELETE: api/Alquiler/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlquiler(int id)
        {
            if (_context.Alquiler == null)
            {
                return NotFound();
            }
            var alquiler = await _context.Alquiler.FindAsync(id);
            if (alquiler == null)
            {
                return NotFound();
            }

            _context.Alquiler.Remove(alquiler);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlquilerExists(int id)
        {
            return (_context.Alquiler?.Any(e => e.id_alquiler == id)).GetValueOrDefault();
        }
    }
}
