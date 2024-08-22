using GastroManagerBE.DB;
using GastroManagerBE.HttpRequest;
using GastroManagerBE.Interfaces;
using GastroManagerBE.Models;
using GastroManagerBE.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GastroManagerBE.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("Policy")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productService;
        private readonly IConfiguration Configuration;
        private readonly GastroManagerContext _context;

        public ProductController(IProductServices productService, IConfiguration configuration, GastroManagerContext context)
        {
            _productService = productService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var rpta = _context.Products.Include(x => x.Category).ToList();

                var response = new
                {
                    success = true,
                    data = rpta,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpGet("[Action]/{categoryId}")]
        public async Task<IActionResult> GetByCategory([FromRoute] int categoryId)
        {
            try
            {
                var rpta = _productService.QueryNoTracking().Include(x => x.Category).Where(x => x.CategoryId == categoryId).ToList();

                var response = new
                {
                    success = true,
                    data = rpta,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> Create([FromBody] ProductRequest request)
        {
            try
            {
                var newProduct = new Product()
                {
                    Name = request.Name,
                    Description = request.Description,
                    Image = request.Image,
                    Price = request.Price,
                    Available = request.Available,
                    CategoryId = request.CategoryId,
                    CreatedBy = "API",
                    CreatedAt = DateTime.Now
                };

                await _productService.AddAsync(newProduct);

                var response = new
                {
                    success = true,
                    data = newProduct,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
