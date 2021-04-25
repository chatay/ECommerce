using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Web.Controllers
{
    public class BasketController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBasketService _basketService;

        public BasketController(ILogger<HomeController> logger, IBasketService basketService)
        {
            _logger = logger;
            _basketService = basketService;
        }
        public async Task<IActionResult> Index()
        {
            var basketItemss = await _basketService.GetBasketItems();
            return View(basketItemss);
        }
        [HttpPost]
        public IActionResult AddItemIntoBasket(BasketAddDto model)
        {
            var basketAdd = _basketService.Add(model);
            return RedirectToAction("Index");
        }
    }
}
