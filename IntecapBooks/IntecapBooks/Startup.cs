using IntecapBooks.Business.Entities;
using IntecapBooks.Infrastructure.API;
using IntecapBooks.Infrastructure.Data;
using IntecapBooks.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IntecapBooks.Infrastructure.Extensions;
using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace IntecapBooks
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
            services.AddControllersWithViews();
            services.AddScoped<IBooksService, BooksService>();
            services.AddScoped<IRepository<Book>, BooksRepository>();
            services.AddHttpClient<IExternalBookProviderClient, ExternalBookProviderClient>();

            services.AddIdentity<IdentityUser, IdentityRole>(options => {
                options.Password.RequireDigit = true;
            }).AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAuthentication().AddFacebook(options => {
                options.AppId = "398327801749935";
                options.AppSecret = "dced6dcc64c1e61d9cc1d37828ca1c36";
            });

            services.AddAuthentication().AddGoogle(options => {
                options.ClientSecret = "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";
                options.ClientId = "77452298986-3f4m6gs17c0fo6tb6hlchne4ghc69rfg.apps.googleusercontent.com";
            });

            services.AddDatabaseProvider();

            services.Configure<CookiePolicyOptions>(options => {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;

                options.OnAppendCookie = cookieContext =>
                    CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);
                options.OnDeleteCookie = cookieContext =>
                    CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);
            });
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
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            
            
        }
        public void CheckSameSite(HttpContext httpContext, CookieOptions cookieOptions)
        {
            if (cookieOptions.SameSite == SameSiteMode.None)
            {
                //var userAgent = httpContext.Request.Headers["User-Agent"].ToString();
                cookieOptions.SameSite = SameSiteMode.Unspecified;
            }
        }
    }
}
