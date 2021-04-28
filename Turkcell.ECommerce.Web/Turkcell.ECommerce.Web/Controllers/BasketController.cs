using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.Core.Aspects.Autofac.Loggers;
using Turkcell.ECommerce.Core.Aspects.Autofac.Logging;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Web.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        //private static ILog Log { get; set; }
        private static readonly ILog log = LogManager.GetLogger(typeof(BasketController));
        //ILog log = LogManager.GetLogger(typeof(BasketController));
        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }
        //[LogAspect(typeof(FileLogger))]
        public async Task<IActionResult> Index()
        {
            log.Info("selam");
            var basketItemss = await _basketService.GetBasketItems();
            return View(basketItemss);
        }

        //[LogAspect(typeof(FileLogger))]
        [HttpPost]
        public IActionResult AddItemIntoBasket(BasketAddDto model)
        {
            log.Info("selam");

            var basketAdd = _basketService.Add(model);
            return RedirectToAction("Index");
        }
    }
}
