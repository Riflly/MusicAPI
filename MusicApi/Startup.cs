using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MusicApi.Models;
using Microsoft.AspNetCore.Identity;
using MusicApi.Infrastructure;

namespace MusicApi
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
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});


            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<MusicAPIsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MusicAPIs")));
            //Assigning custom classes to Identity for Users and Roles
            services.AddIdentity<User, UserRole>().AddDefaultTokenProviders();
            //Using custom storage provider for users
            services.AddTransient<IUserStore<User>, UserStore>();
            //Using custom storage provider for roles
            services.AddTransient<IRoleStore<UserRole>, RoleStore>();
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/Login";
                options.LogoutPath = "/Logout";
            });

            //services.AddDbContext<MusicAPIsContext>(option =>
            //option.UseSqlServer(
            //    Configuration["Data:SportsStoreProducts:ConnectionString"]));

            //   services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration["Data:SportsStoreProducts:ConnectionString"]));
            /// services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders();

            services.AddTransient<IProductRepo, EFProductRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MusicAPIsContext db, SignInManager<User> s)
        {
            if (env.IsDevelopment())
            {
                User user = s.UserManager.FindByNameAsync("dev").Result;
                app.UseDeveloperExceptionPage();
                if (s.UserManager.FindByNameAsync("dev").Result == null)
                {
                    var result = s.UserManager.CreateAsync(new User
                    {
                        UserName = "dev",
                        UserEmail = "dev@app.com"
                    }, "Aut94L#G-a").Result;
                }
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapSpaFallbackRoute("spa-fallback", new { controller = "Home", action = "Index" });

            });
        }
    }
}
