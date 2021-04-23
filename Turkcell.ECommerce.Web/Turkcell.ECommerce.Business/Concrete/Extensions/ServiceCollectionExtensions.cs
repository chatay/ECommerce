using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.DataAccess;

namespace Turkcell.ECommerce.Business.Concrete.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<EnityFramWorkDbContext>();
            serviceCollection.AddScoped<IProductService, ProductManager>();

            return serviceCollection;
        }
    }
}
