namespace ShoppingApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Razor.Internal;
    using ShoppingApp.Data.Common.Repositories;
    using ShoppingApp.Data.Models;
    using System.Linq;

    public class HomeController : BaseController
    {
        private readonly IRepository<Product> productRepository;

        public HomeController(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
           
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => this.View();
    }
}
