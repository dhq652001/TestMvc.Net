using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using TestMvc.Services;

namespace TestMvc.Controllers
{
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger;
        private readonly ProductService _productService;

        public FirstController(ILogger<FirstController> logger, ProductService productService) 
        {
            _logger = logger;
            _productService = productService;
        }
        public IActionResult HelloView(string username)
        
        {
            if(!string.IsNullOrEmpty(username))
            
                username = "Khach";
            //View() => Razor Page Engine, doc .cshtml(template)
            //----------------------------------
            //View(template) - template đường dẫn tuyệt đối tới .cshtml
            //View(template, model)
            return View("/MyView/xinchao1.cshtml",username);
        }
        public IActionResult ViewProduct(int? id)
        {
            var product = _productService.Where(p  => p.Id == id).FirstOrDefault();
            if(product == null)
                return NotFound();
            //View/First/ViewProduct.cshtml
            return View(product);
        }
    }
}
