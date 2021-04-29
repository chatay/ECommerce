using log4net;
using log4net.Core;
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
        private readonly IProductService _productService;
        private static readonly ILog log = LogManager.GetLogger(typeof(HomeController));
        //private readonly ILogger _logger;
        private readonly ILogger<HomeController> _logger;
        public HomeController(IProductService _productService, ILogger<HomeController> logger)
        {
            this._productService = _productService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Home Controller started");
            try
            {
                var productViewModel = await _productService.GetAll();

                _logger.LogInformation("Home Controller started");

                return View(productViewModel);
            }

            catch (Exception ex)
            {
                _logger.LogError("Home Controller exception ", ex);

                return View("Error");
            }
            finally
            {
                // StreamReader.Close() ya da db connection kapatmak için kullanabiliriz.
                // dispose işlemler için ...
            }

        }
        public async Task<IActionResult> GetOrders()
        {
            _logger.LogInformation("GetOrders");
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
            _logger.LogInformation("ProductDetail");
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
