using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.Abstract;
using Turkcell.ECommerce.Entities.Concrete;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Business.Abstract
{
    public interface IContactUsService
    {
        Task<IDataResult<IList<ContactUs>>> GetAll();
        Task<IResult> InsertMessage(ContactUs contactUsDto);
    }
}
