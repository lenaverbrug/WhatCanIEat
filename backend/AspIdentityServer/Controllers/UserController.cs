using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AspIdentityServer.data.Models;
using AspIdentityServer.data.Models.PostModels;
using Microsoft.AspNetCore.Authorization;
using IdentityServer4.AccessTokenValidation;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspIdentityServer.Controllers
{
#pragma warning disable CS0618 // Type or member is obsolete
    [Authorize(ActiveAuthenticationSchemes = IdentityServerAuthenticationDefaults.AuthenticationScheme, Policy = "Manage administrator")]
#pragma warning restore CS0618 // Type or member is obsolete
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<ApplicationUser> userManager, 
                                RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet("getUsers")]
        public async Task<IActionResult> GetUser()
        {
            var user = await userManager.GetUserAsync(User);
            return new JsonResult(user);
        }

        [AllowAnonymous]
        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserModel model)
        {
            try
            {
                var user = new ApplicationUser
                {
                    UserName = model.username,
                    lievelingskleur = model.lievelingsKeleur,
                    
                };
                if(model.password1 != model.password2)
                {
                    return new BadRequestObjectResult("Wachtwoorden zijn niet gelijk");
                }
                var result = await userManager.CreateAsync(user, model.password1);
                if (result.Succeeded)
                {
                    var tempUser = await userManager.FindByIdAsync(user.Id);
                    var assignUserToRole = await userManager.AddToRoleAsync(tempUser, "user");
                    if (assignUserToRole.Succeeded)
                    {
                        return new OkObjectResult("User toegevoegd en assigned to Role");
                    }
                    return Ok("user toegevoegd");
                }
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult("niet inorde " + ex);
            }
            return BadRequest();
        }
    }
}
