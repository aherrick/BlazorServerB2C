using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SupplyChainCloud.UI.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthorizeController : ControllerBase
    {
        public AuthorizeController()
        {
        }

        [Authorize]
        public async Task<IActionResult> NewUser()
        {
            // TODO: hit this endpoint after login/register with B2C.

            return Redirect("/");
        }
    }
}