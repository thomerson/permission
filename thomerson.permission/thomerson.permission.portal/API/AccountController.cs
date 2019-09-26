using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using thomerson.Gatlin;

namespace thomerson.permission.portal.API
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]string userId, string password)
        {
            userId.CheckNullOrEmpty(nameof(userId));
            password.CheckNullOrEmpty(nameof(password));

            await new Task(() =>
            {
                //
            });

            return Json("");
        }
    }
}
