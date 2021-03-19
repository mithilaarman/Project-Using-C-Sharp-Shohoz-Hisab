using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_bill;
using Hello.Application.MTbl_item;
using Hello.Application.MTbl_order;
using Hello.Application.MTbl_payment;
using Hello.Application.MTbl_product;
using Hello.Application.MTbl_user;
using Hello.Data;
using HocDotNet.Application.MTbl_bill;
using HocDotNet.Application.MTbl_item;
using HocDotNet.Application.MTbl_order;
using HocDotNet.Application.MTbl_payment;
using HocDotNet.Application.MTbl_product;
using HocDotNet.Application.MTbl_user;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hello.WebApi
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

            services.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
            {
                builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
                .WithOrigins("https://localhost:44345");
            }));


            services.AddDbContext<HelloDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("HelloDatabase")));

            // add DI
            services.AddTransient<ITbl_productService, Tbl_productService>();
            services.AddTransient<ITbl_orderService, Tbl_orderService>();
            services.AddTransient<ITbl_itemService, Tbl_itemService>();
            services.AddTransient<ITbl_paymentService, Tbl_paymentService>();
            services.AddTransient<ITbl_billService, Tbl_billService>();
            services.AddTransient<ITbl_userService, Tbl_userService>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
