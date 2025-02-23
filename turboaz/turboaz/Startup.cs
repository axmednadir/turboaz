using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using turboaz.Models;

namespace turboaz
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<turboazContext>(options => options.UseSqlServer("Server=WIN-ITTUF10ILP7\\SQLEXPRESS;Database=turboaz;Trusted_Connection=True;"));
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
            {
                option.LoginPath = "/User/Login";
                option.Cookie.Name = "User";
                option.ExpireTimeSpan = TimeSpan.FromMinutes(5);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                     name: "Default",
                     pattern: "{controller=Home}/{action=Index}/{id?}"
                     );
            });
            
        }
    }
}

//PM > Scaffold - DbContext "Server=WIN-ITTUF10ILP7\SQLEXPRESS;Database=turboaz;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models