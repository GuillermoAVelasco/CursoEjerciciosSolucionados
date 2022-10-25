using AspNetCoreParte2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AspNetCoreParte2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebaController : ControllerBase
    {        
        private readonly ILogger<PruebaController> _logger;
        private readonly IHttpClientFactory _client;
        private readonly ILoggerFactory _loggerFactory;

        //(1 y 2)
        public PruebaController(ILogger<PruebaController> logger,IHttpClientFactory client,ILoggerFactory loggerFactory)
        {
            _logger = logger;
            _client = client;
            _loggerFactory = loggerFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var url = "https://jsonplaceholder.typicode.com/posts";
            var client = _client.CreateClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsAsync<Blog[]>();

                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Blog blog)
        {
            var url = "https://jsonplaceholder.typicode.com/posts";
            var client = _client.CreateClient();
            
            HttpResponseMessage response = await client.PostAsJsonAsync(url,blog);

            if (response.IsSuccessStatusCode)
            {
               return NoContent();
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute]int id,[FromBody] Blog blog)
        {
            var url = $"https://jsonplaceholder.typicode.com/posts/{id}";
            var client = _client.CreateClient();

            HttpResponseMessage response = await client.PutAsJsonAsync(url,blog);

            if (response.IsSuccessStatusCode)
            {
                return Ok(blog);
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var url = $"https://jsonplaceholder.typicode.com/posts/{id}";
            var client = _client.CreateClient();

            HttpResponseMessage response = await client.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return Ok();
            }

            return NotFound();
        }

        //http://localhost:5056/Prueba/Payload/1?name=pepe

        [HttpPost("Payload/{id}")] //(3, 4 , 5 , 6 ,7,8)
        public async Task<IActionResult> Payload([FromBody] Root root, [FromHeader] string seguridad, [FromRoute] int id, [FromQuery] string name, [FromServices] IPersona persona)
        {           
            return Ok(root);
        }

        //9 log

        [HttpGet("Log")]
        public IActionResult Log()
        {
            var logger= _loggerFactory.CreateLogger("Prueba.Logger");
            //var logger = _logger;
            Console.WriteLine();
            Console.WriteLine("Probando REGISTRO LOG");
            logger.LogTrace("Logueando con TRACE");
            logger.LogDebug("Logueando con DEBUG");
            logger.LogInformation("Logueando con INFORMACION");
            logger.LogWarning("Logueando con WARNING");
            logger.LogError("Logueando con ERROR");
            logger.LogCritical("Logueando con CRITICAL");

            

            return Ok();
        }
    }
}