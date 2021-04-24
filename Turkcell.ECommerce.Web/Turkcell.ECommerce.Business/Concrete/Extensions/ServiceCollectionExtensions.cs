﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.Core.DataAccess;
using Turkcell.ECommerce.DataAccess;
using Turkcell.ECommerce.DataAccess.Abstract;
using Turkcell.ECommerce.DataAccess.Concrete;

namespace Turkcell.ECommerce.Business.Concrete.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<EnityFramWorkDbContext>();
            serviceCollection.AddScoped<IProductService, ProductManager>();
            serviceCollection.AddScoped<IProductDal, ProductDal>();

            return serviceCollection;
        }
    }
}
