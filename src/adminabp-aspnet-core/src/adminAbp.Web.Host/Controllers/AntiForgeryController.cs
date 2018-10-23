using Microsoft.AspNetCore.Antiforgery;
using adminAbp.Controllers;

namespace adminAbp.Web.Host.Controllers
{
    public class AntiForgeryController : adminAbpControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
