using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Core.EntityFramework;
using Turkcell.ECommerce.DataAccess.Abstract;
using Turkcell.ECommerce.Entities.Concrete;

namespace Turkcell.ECommerce.DataAccess.Concrete.Repositories
{
    public class ContactUsDal: RepositoryBase<ContactUs, EnityFramWorkDbContext>, IContactUsDal
    {
        public ContactUsDal(EnityFramWorkDbContext context) : base(context)
        {

        }
    }
}
