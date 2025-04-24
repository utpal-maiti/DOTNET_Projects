using APIConcepts.Models;

using Microsoft.AspNetCore.Mvc;
namespace APIConcepts.Controllers
{
    //Attribute Routing
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>();
        // Route: api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            // Return all products
            return Ok(new List<string> { "Product1", "Product2" });
        }

        // Route: api/products/{id}
        [HttpGet("{id:int=1}", Name = "GetProductById")]
        public IActionResult GetById(int id)
        {
            // Route: api/products/{id}
            return Ok($"Product{id}");
        }
     

        [HttpGet]
        [Route("category/{category}")]
        public IActionResult GetByCategory(string category)
        {
            // Route: api/products/category/{category}
            return Ok($"Category: {category}");
        }


        // Route: api/products
        [HttpPost]
        public IActionResult Create([FromBody] string product)
        {
            // Create a new product
            return CreatedAtAction(nameof(GetById), new { id = 3 }, product);
        }

        [HttpPost] 
        public IActionResult Create([FromBody] Product product) { 

            if (!ModelState.IsValid) { 
                return BadRequest(ModelState); 
            } 
            product.Id = Products.Count + 1; Products.Add(product); 
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product); 
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null) { return NotFound(); }
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] string product)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}
