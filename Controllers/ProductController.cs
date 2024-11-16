using Microsoft.AspNetCore.Mvc;
using SklepMVC.Data;
using SklepMVC.Models;

namespace SklepMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly PumpPalaceDbContext _context;

        public ProductsController(PumpPalaceDbContext context)
        {
            _context = context;
        }

        // GET: api/products
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        // POST: api/products
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (product == null)
                return BadRequest("Product is null.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState); // Zwróć błędy walidacji

            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }

        // PUT: api/products/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            if (product == null || product.Id != id)
                return BadRequest("Invalid product data.");

            var existingProduct = _context.Products.Find(id);
            if (existingProduct == null)
                return NotFound();

            // Aktualizuj właściwości produktu
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.DiscountPrice = product.DiscountPrice;
            existingProduct.VAT = product.VAT;
            existingProduct.Currency = product.Currency;
            existingProduct.Stock = product.Stock;
            existingProduct.ThumbnailUrl = product.ThumbnailUrl;
            existingProduct.ImageUrl = product.ImageUrl;
            existingProduct.CategoryId = product.CategoryId;
            existingProduct.IsHidden = product.IsHidden;
            existingProduct.IsNew = product.IsNew;
            existingProduct.IsPromotion = product.IsPromotion;

            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
