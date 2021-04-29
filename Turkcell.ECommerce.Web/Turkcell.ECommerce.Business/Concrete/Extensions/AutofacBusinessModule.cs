using Autofac;
using Autofac.Extras.DynamicProxy;
using AutofacSerilogIntegration;
using Castle.DynamicProxy;
using log4net;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.Core.Utilities.Interception;
using Turkcell.ECommerce.DataAccess;
using Turkcell.ECommerce.DataAccess.Abstract;
using Turkcell.ECommerce.DataAccess.Concrete;
using Turkcell.ECommerce.DataAccess.Concrete.Repositories;

namespace Turkcell.ECommerce.Business.Concrete.Extensions
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<ProductDal>().As<IProductDal>();

            builder.RegisterType<BasketManager>().As<IBasketService>();
            builder.RegisterType<BasketDal>().As<IBasketDal>();

            builder.RegisterType<ContactUsManager>().As<IContactUsService>();
            builder.RegisterType<ContactUsDal>().As<IContactUsDal>();

            ContainerBuilder cb = new ContainerBuilder();
            cb.Register(c => LogManager.GetLogger(typeof(Object))).As<ILog>();
            IContainer container = cb.Build();
            builder.RegisterLogger();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                 .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                 {
                     Selector = new AspectInterceptorSelector()
                 }).SingleInstance();

        }
    }
}
