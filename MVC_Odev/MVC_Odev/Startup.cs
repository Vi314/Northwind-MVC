using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MVC_Odev
{
    public class Startup
    {
  
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            Repository.Repository.SepetOlustur();

            app.UseEndpoints(x =>
            {
                x.MapControllerRoute(
                    name: "UpdateRoute",
                    pattern: "{controller}/{action}/{id}",
                    defaults: new {controller="Update"}
                    );


                x.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
