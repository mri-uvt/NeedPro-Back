using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeedPro_Back.Models;

namespace NeedPro_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSkillsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public UserSkillsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/UserSkills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserSkill>>> GetUserSkill()
        {
            return await _context.UserSkill.ToListAsync();
        }

        // GET: api/UserSkills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserSkill>> GetUserSkill(int id)
        {
            var userSkill = await _context.UserSkill.FindAsync(id);

            if (userSkill == null)
            {
                return NotFound();
            }

            return userSkill;
        }

        // PUT: api/UserSkills/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserSkill(int id, UserSkill userSkill)
        {
            if (id != userSkill.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userSkill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserSkillExists(id))
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

        // POST: api/UserSkills
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UserSkill>> PostUserSkill(UserSkill userSkill)
        {
            _context.UserSkill.Add(userSkill);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserSkillExists(userSkill.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserSkill", new { id = userSkill.UserId }, userSkill);
        }

        // DELETE: api/UserSkills/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserSkill>> DeleteUserSkill(int id)
        {
            var userSkill = await _context.UserSkill.FindAsync(id);
            if (userSkill == null)
            {
                return NotFound();
            }

            _context.UserSkill.Remove(userSkill);
            await _context.SaveChangesAsync();

            return userSkill;
        }

        private bool UserSkillExists(int id)
        {
            return _context.UserSkill.Any(e => e.UserId == id);
        }
    }
}
