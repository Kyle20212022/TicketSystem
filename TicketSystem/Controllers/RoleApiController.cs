using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleApiController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleApiController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        [HttpGet]
        public async Task<List<IdentityRole>> CreateRoleAsync()
        {
            var result = await _roleManager.CreateAsync(new IdentityRole("Admin"));
            var a = result.Succeeded;
            var r = _roleManager.Roles.ToList();
            return r;
        }
    }
}
