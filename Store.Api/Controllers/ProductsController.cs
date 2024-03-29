using Microsoft.AspNetCore.Mvc;
using Serilog;
using Store.Api.ApiModels;
using Store.Api.Interfaces;

namespace Store.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductLogic _productLogic;

        public ProductsController(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts(string category = "all")
        {
            Log.ForContext("Category", category)
                .Information("Start GetProducts");
            return _productLogic.GetProductsForCategory(category);
        }
    }
}
