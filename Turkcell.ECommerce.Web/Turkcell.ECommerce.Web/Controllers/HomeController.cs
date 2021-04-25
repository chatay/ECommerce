using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.ComplexTypes;
using Turkcell.ECommerce.Entities.Concrete;
using Turkcell.ECommerce.Entities.Dtos;
using Turkcell.ECommerce.Web.Models;

namespace Turkcell.ECommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService _productService)
        {
            _logger = logger;
            this._productService = _productService;
        }

        public async Task<IActionResult> Index()
        {
            var productViewModel = await _productService.GetAll();
            return View(productViewModel);
        }
        [HttpPost]
        public IActionResult AddProduct(string data)
        {
            //var result = await _productService.Add();
            return View();
        }
        public async Task<IActionResult> GetOrders()
        {
            var result = await _productService.GetAll();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View("Privacy", result.Data);
            }
            return View("Privacy");
        }
        [HttpGet]
        public async Task<IActionResult> ProductDetail(int productId)
        {
            var productViewModel = await _productService.Get(productId);
            return View("ProductDetail",productViewModel);
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
