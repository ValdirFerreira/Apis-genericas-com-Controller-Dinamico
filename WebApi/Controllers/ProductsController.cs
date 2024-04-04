using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Config;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : DynamicController<Product>
    {
        public ProductsController(AppDbContext context) : base(context)
        {
        }


    }
}
