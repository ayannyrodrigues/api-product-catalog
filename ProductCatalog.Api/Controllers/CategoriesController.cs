using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.Models;
using ProductCatalog.Infrastructure.Context;

namespace ProductCatalog.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ProductCatalogDbContext _context;
        public CategoriesController(ProductCatalogDbContext context)
        {
            _context = context;
        }

        [HttpGet("products")]
        public ActionResult<IEnumerable<Category>> GetCategoriesWithProducts()
        {
            var listCategoriesWithProducts = _context.Categories.Include(p => p.Products).ToList();

            if (listCategoriesWithProducts is null)
            {
                return NotFound();
            }

            return listCategoriesWithProducts;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            var categories = _context.Categories.ToList();

            if(categories is null)
            {
                return NotFound();
            }

            return categories;
        }

        [HttpGet("{id:int}", Name="GetCategories")]
        public ActionResult<Category> Get(int id) 
        {
            var category = _context.Categories.FirstOrDefault(p => p.CategoryId == id);

            if (category is null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost]
        public ActionResult Post(Category category)
        {
            if(category is null)
            {
                return BadRequest();
            }

            _context.Add(category);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetCategories", new { id = category.CategoryId }, category);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(category);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(p => p.CategoryId == id);

            if (category is null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();

            return Ok(category);
        }
    }
}
