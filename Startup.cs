using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1
{
    public class Startup
    {

        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<AppointmentContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:AppointmentConnection"]);
            });

            // Heres the second service added
            services.AddScoped <IAppointmentRepo,EFAppointmentsRepo> ();

            ////All of these services to be able to do the cart and use sessions
            //services.AddRazorPages();

            //services.AddDistributedMemoryCache();
            //services.AddSession();
            //services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "home",
                    "Homepage",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    "day",
                    "SignUp/{day}",
                    new { Controller = "Home", action = "SignUp" }
                    );

                endpoints.MapControllerRoute(
                    "signup",
                    "SignUp",
                    new { Controller = "Home", action = "SignUp" }
                    );

                endpoints.MapControllerRoute(
                    "form",
                    "SignUp/Form",
                    new { Controller = "Home", action = "Form" }
                    );

                endpoints.MapControllerRoute(
                    "viewapps",
                    "ViewAppointments",
                    new { Controller = "Home", action = "ViewAppointments" }
                    );

                endpoints.MapDefaultControllerRoute();


            });

            //Seed data function
            SeedData.EnsurePopulated(app);
        }
    }
}
