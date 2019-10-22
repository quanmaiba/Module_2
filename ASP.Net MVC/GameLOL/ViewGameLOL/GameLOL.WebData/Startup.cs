using GameLol.AppData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameLOL.WebData
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<GameLolContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("GameLolView"))
                );
            // services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();      
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();
            //app.UseMvcWithDefaultRoute();//giong ben duoi mac ddinh

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=quan}/{action=Edit}/{id?}");
            });

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(name: "secure",
            //        template: "secure", new
            //        {
            //            Controller = "quan",
            //            Action = "Index"
            //        });


            //    //routes.MapRoute(
            //    //name: "default",
            //    //template: "{controller=DescriptionHeroes}/{action=Index}/{id:int?}");
            //});
            app.Run(async (conten) =>
            {
                await conten.Response.WriteAsync("Failed to find route");
            });
        }
    }
}
