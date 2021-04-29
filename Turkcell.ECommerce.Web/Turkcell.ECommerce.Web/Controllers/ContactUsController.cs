using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.Entities.Concrete;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Web.Controllers
{
    public class ContactUsController : Controller
    {
        #region Fields

        private readonly IContactUsService _contactUsService;

        #endregion

        #region Constructor

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        #endregion

        #region Methods

        // GET: /ContactUs/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMessage(ContactUsDto model)
        {
            bool err = true;
            if (ModelState.IsValid)
            {
                var messageEntity = new ContactUs
                {
                    Name = model.Name,
                    Email = model.Email,
                    Title = model.Title,
                    Message = model.Message
                };

                _contactUsService.InsertMessage(messageEntity);
                err = false;
            }

            TempData["ContactUsErr"] = err;
            return RedirectToAction("Index");
        }

        #endregion
    }
}