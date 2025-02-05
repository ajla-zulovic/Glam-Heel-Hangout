using eGlamHeelHangout.Model;
using eGlamHeelHangout.Service;
using Microsoft.AspNetCore.Mvc;

namespace eGlamHeelHangout.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProductController : ControllerBase
  {
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
      _productService = productService;

    }

    [HttpGet()]
    public IEnumerable<Products> Get()
    {
      return _productService.Get();
    }
  }
}
