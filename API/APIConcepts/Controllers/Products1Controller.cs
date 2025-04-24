using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

//2.Controllers and Actions
[ApiController]
[Route("[controller]")]
public class Products1Controller : ControllerBase
{
    private static readonly List<string> Products = new List<string> { "Product1", "Product2", "Product3" };

    // GET: /products
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Products);
    }

    // GET: /products/{id}
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        if (id < 0 || id >= Products.Count)
        {
            return NotFound();
        }
        return Ok(Products[id]);
    }

    // POST: /products
    [HttpPost]
    public IActionResult Create([FromBody] string product)
    {
        Products.Add(product);
        return CreatedAtAction(nameof(GetById), new { id = Products.Count - 1 }, product);
    }

    // PUT: /products/{id}
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] string product)
    {
        if (id < 0 || id >= Products.Count)
        {
            return NotFound();
        }
        Products[id] = product;
        return NoContent();
    }

    // DELETE: /products/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (id < 0 || id >= Products.Count)
        {
            return NotFound();
        }
        Products.RemoveAt(id);
        return NoContent();
    }
}
