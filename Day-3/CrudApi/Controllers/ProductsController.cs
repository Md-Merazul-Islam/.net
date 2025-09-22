using Microsoft.AspNetCore.Mvc;
using CrudApi.Data;
using CrudApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {
    private readonly AppDbContext _context;
    public ProductsController(AppDbContext context)
    {
      _context = context;
    }

    // GET: api/products
    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<Product>>>> GetProducts()
    {
        var products = await _context.Products.ToListAsync();
        return Ok(new ApiResponse<IEnumerable<Product>>(true, "All products retrieved", products));
    }

    // GET: api/products/1
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<Product>>> GetProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
            return NotFound(new ApiResponse<Product>(false, "Product not found", null));

        return Ok(new ApiResponse<Product>(true, "Product retrieved successfully", product));
    }

  // POST: api/products
  [HttpPost]
  public async Task<ActionResult<ApiResponse<Product>>> CreateProduct(Product product)
  {
      _context.Products.Add(product);
      await _context.SaveChangesAsync();

      return CreatedAtAction(nameof(GetProduct), new { id = product.Id },
          new ApiResponse<Product>(true, "Product created successfully", product));
  }
      // PUT: api/products/1
    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<Product>>> UpdateProduct(int id, Product product)
    {
        if (id != product.Id)
            return BadRequest(new ApiResponse<Product>(false, "Product ID mismatch", null));

        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return Ok(new ApiResponse<Product>(true, "Product updated successfully", product));
    }

    // DELETE: api/products/1
    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<object>>> DeleteProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
            return NotFound(new ApiResponse<object>(false, "Product not found", null));

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return Ok(new ApiResponse<object>(true, "Product deleted successfully", null));
    }

  }

}