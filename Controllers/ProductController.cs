using api02.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new List<Product>()
            {
                new Product(){Id = 1, Name = "PC"}
            };
        }

    }
}