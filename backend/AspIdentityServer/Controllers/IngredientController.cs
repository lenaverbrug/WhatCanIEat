using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspIdentityServer.data;
using Microsoft.AspNetCore.Authorization;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Identity;
using AspIdentityServer.data.Models;

namespace AspIdentityServer.Controllers
{
#pragma warning disable CS0618 // Type or member is obsolete
    [Authorize(ActiveAuthenticationSchemes = IdentityServerAuthenticationDefaults.AuthenticationScheme, Policy = "Access Resources")]
#pragma warning restore CS0618 // Type or member is obsolete
    [Produces("application/json")]
    [Route("api/Ingredients")]
    public class IngredientController : Controller
    {
        private readonly ApplicationDBcontext _context;
        private readonly UserManager<ApplicationUser> userManager;

        public IngredientController(ApplicationDBcontext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        // GET: api/Ingredients
       /* [HttpGet]
        public async Task<ActionResult> GetMens()
        {
            var mens = new Mens
            {
                MensID = 1,
                isBoy = true,
                leeftijd = "24 jaar",
                naam = "axelle"
            };
            return new JsonResult(mens);
        }*/

        [HttpGet]
        public async Task<ActionResult> GetIngredient()
        {
            var user = await userManager.GetUserAsync(User);

            var model = user.UserName;
            return new JsonResult(user);
        }


        // GET: api/Ingredients/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMens([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mens = await _context.Ingredient.SingleOrDefaultAsync(m => m.ingredientID == id);

            if (mens == null)
            {
                return NotFound();
            }

            return Ok(mens);
        }

        // PUT: api/Ingredients/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMens([FromRoute] int id, [FromBody] Ingredient ingredient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ingredient.ingredientID)
            {
                return BadRequest();
            }

            _context.Entry(ingredient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MensExists(id))
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

        // POST: api/Ingredients
        [HttpPost]
        public async Task<IActionResult> PostIngredient([FromBody] Ingredient ingredient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Ingredient.Add(ingredient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIngredient", new { id = ingredient.ingredientID }, ingredient);
        }

        // DELETE: api/Ingredients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ingredient = await _context.Ingredient.SingleOrDefaultAsync(m => m.ingredientID == id);
            if (ingredient == null)
            {
                return NotFound();
            }

            _context.Ingredient.Remove(ingredient);
            await _context.SaveChangesAsync();

            return Ok(ingredient);
        }

        private bool MensExists(int id)
        {
            return _context.Ingredient.Any(e => e.ingredientID == id);
        }
    }
}
