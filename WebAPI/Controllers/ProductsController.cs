using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("getAll")]
        public IActionResult Get()
        {
            var result = productService.GetAll();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Product product) {
            var result = productService.Add(product);
        return Ok(result);
        }


    }
}
