using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShowProduct.Business.Abstract;
using ShowProduct.Business.Concrete;
using ShowProduct.Core.CrossCuttingConcert.Identities;
using ShowProduct.Core.CrossCuttingConcert.Identities.MicrosoftIdentity;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.DataAccess.Concrete;
using ShowProduct.DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddSession();
            services.AddDbContext<ApplicationDbContext>();
            services.AddScoped<IAboutDAL, AboutDAL>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAdDAL, AdDAL>();
            services.AddScoped<IAdService, AdManager>();
            services.AddScoped<IBoxDAL, BoxDAL>();
            services.AddScoped<IBoxService, BoxManager>();
            services.AddScoped<ICategoryDAL, CategoryDAL>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICommentDAL, CommentDAL>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IContactDAL, ContactDAL>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactMessageDAL, ContactMessageDAL>();
            services.AddScoped<IContactMessageService, ContactMessageManager>();
            services.AddScoped<ILocationDAL, LocationDAL>();
            services.AddScoped<ILocationService, LocationManager>();
            services.AddScoped<IPictureDAL, PictureDAL>();
            services.AddScoped<IPictureService, PictureManager>();
            services.AddScoped<IProductDAL, ProductDAL>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDetailDAL, ProductDetailDAL>();
            services.AddScoped<IProductDetailService, ProductDetailManager>();
            services.AddScoped<IReportDAL, ReportDAL>();
            services.AddScoped<IReportService, ReportManager>();
            services.AddScoped<ISendMailDAL, SendMailDAL>();
            services.AddScoped<ISendMailService, SendMailManager>();
            services.AddScoped<ISocialMediaDAL, SocialMediaDAL>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISubcategoryDAL, SubcategoryDAL>();
            services.AddScoped<ISubcategoryService, SubcategoryManager>();
            services.AddScoped<ITagDAL, TagDAL>();
            services.AddScoped<ITagService, TagManager>();
            services.AddScoped<IToDoDAL, ToDoDaL>();
            services.AddScoped<IToDoService, ToDoManager>();
            services.AddScoped<IUserDAL, UserDAL>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserLogDAL, UserLogDAL>();
            services.AddScoped<IUserLogService, UserLogManager>();
            services.AddScoped<IVideoAdDAL, VideoAdDAL>();
            services.AddScoped<IVideoAdService, VideoAdManager>();

            services.AddIdentity<ApplicationUser, IdentityRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequiredLength = 3;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>();
            //services.AddAuthentication();
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(i =>
                {
                    i.LoginPath = "/Account/Login/";
                });

            services.ConfigureApplicationCookie(option =>
            {
                option.Cookie.HttpOnly = true;
                option.ExpireTimeSpan = TimeSpan.FromDays(5);
                option.LoginPath = "/Account/Login/";
                option.LogoutPath = "/Account/Logout/";
                option.Cookie.SameSite = SameSiteMode.Strict;
                option.Cookie.Name = "ShowProduct";
                option.SlidingExpiration = true;
            });
            services.AddHttpContextAccessor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            IdentityInitializer.CreateAdmin(userManager, roleManager);
            app.UseStatusCodePagesWithReExecute("/Home/NotFound", "?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();           
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
