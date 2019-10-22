using BoDeTracNghiemDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BoDeTracNghiemDemo
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


            services.AddDbContext<AppDataConText>(
               options => options.UseSqlServer(Configuration.GetConnectionString("BoDeTracNghiemDemo"))
               );
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 3;

            })
               .AddEntityFrameworkStores<AppDataConText>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("OrganizerAccessPolicy", policy => policy.RequireRole("Admin"));

                //options.AddPolicy("SpeakerAccessPolicy",
                //    policy => policy.RequireAssertion(context => context.User.IsInRole("User")));

                //options.AddPolicy("YearsOfExperiencePolicy",
                //    policy => policy.AddRequirements(new YearsOfExperienceRequirement(6)));

                //options.AddPolicy("ProposalEditPolicy",
                //    policy => policy.AddRequirements(new ProposalRequirement(false)));
            });

            services.AddMvc(
                    opt =>
                    {
                        var policy = new AuthorizationPolicyBuilder()
                        .RequireAuthenticatedUser()
                        .Build();
                        opt.Filters.Add(new AuthorizeFilter(policy));
                    }

                ).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
