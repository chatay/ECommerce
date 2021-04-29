using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.Abstract;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.ComplexTypes;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.Concrete;
using Turkcell.ECommerce.DataAccess.Abstract;
using Turkcell.ECommerce.Entities.Concrete;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Business.Concrete
{
    class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            this.contactUsDal = contactUsDal;
        }

        public async Task<IDataResult<IList<ContactUs>>> GetAll()
        {
            var contactUsMessages = await contactUsDal.GetAllAsync(null);
            if (contactUsMessages.Count > 0)
            {
                return new DataResult<IList<ContactUs>>(ResultStatus.Success, contactUsMessages);
            }
            return new DataResult<IList<ContactUs>>(ResultStatus.Error, "none", null);
        }

        public async Task<IResult> InsertMessage(ContactUs contactUsDto)
        {
            var contactUs = new ContactUs
            {
                Message = contactUsDto.Message,
                Email = contactUsDto.Email,
                Name = contactUsDto.Name
            };
            await contactUsDal.AddAsync(contactUs);

            return new Result(ResultStatus.Success, $"{contactUs.Name} mesaj iletildi.");
        }
    }
}
