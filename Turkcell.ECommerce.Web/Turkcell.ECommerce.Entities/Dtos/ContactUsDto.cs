using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Entities.Concrete;

namespace Turkcell.ECommerce.Entities.Dtos
{
    public class ContactUsDto
    {
        //public ContactUs ContactUs { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
