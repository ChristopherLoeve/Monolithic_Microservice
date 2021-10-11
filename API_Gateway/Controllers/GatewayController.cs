using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
/// <summary>
/// testChange
/// testChange
/// testChange
/// testChange
/// testChange
/// testChange
/// testChange
/// </summary>
namespace API_Gateway.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class ProxyController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public ProxyController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }
        [HttpGet] 
        public async Task<IActionResult> Books()
        {
            return await ProxyTo("https://localhost:44366/books");
        }

        [HttpGet]
        public async Task<IActionResult> Authors()
        {
            return await ProxyTo("https://localhost:44302/authors");
        }

        private async Task<ContentResult> ProxyTo(string url)
        {
            return Content(await _httpClient.GetStringAsync(url));
        }
    }
}
