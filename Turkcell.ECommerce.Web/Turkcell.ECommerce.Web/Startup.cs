using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Turkcell.ECommerce.Business.Concrete.Extensions;
using Turkcell.ECommerce.DataAccess;
using Turkcell.ECommerce.Entities.Concrete;

namespace Turkcell.ECommerce.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddAutoMapper(typeof(Startup));
            services.AddEntityFrameworkSqlite().AddDbContext<EnityFramWorkDbContext>();
            services.LoadMyService();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //404 error versin eğer sayfa yoksa
                app.UseStatusCodePages();
                AddTestData();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        private static void AddTestData()
        {
            IList<Product> products = new List<Product>();
            products.Add(new Product { Name = "Turkcell Telefon", Price = 10.00M, Photo = "", Desciption = "Turkcell Telefon" });
            products.Add(new Product { Name = "Turkcell Bilgisayar", Price = 12.00M, Photo = "", Desciption = "Turkcell Bilgisayar" });
            products.Add(new Product { Name = "Turkcell Kulaklık", Price = 13.00M, Photo = "", Desciption = "Turkcell Kulaklık" });

            IList<BasketItem> basketItems = new List<BasketItem>();
            basketItems.Add(new BasketItem { Id = 1, ProductId = 1, Quantity = 2, UserId = 1 });
            basketItems.Add(new BasketItem { Id = 2, ProductId = 5, Quantity = 1, UserId = 1 });
        }
    }
}
