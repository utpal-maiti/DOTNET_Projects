using APIConcepts.Services;

using Microsoft.AspNetCore.Mvc;
namespace APIConcepts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Products2Controller : ControllerBase
    {
        private readonly IProductService _productService;

        public Products2Controller(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] string product)
        {
            _productService.AddProduct(product);
            return CreatedAtAction(nameof(GetById), new { id = _productService.GetProducts().Count() - 1 }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] string product)
        {
            _productService.UpdateProduct(id, product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }

}
