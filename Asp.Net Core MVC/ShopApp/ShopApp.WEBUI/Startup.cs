using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShopApp.Business.Extensions;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EntityFrameworkCore;
using ShopApp.WEBUI.Identity;
using ShopApp.WEBUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI
{
    public class Startup
    {
        private readonly IConfiguration Configuration;
        public Startup(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ShopDb;Integrated Security=SSPI;"

            // MVC
            // RAZOR PAGES

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));
            services.AddDbContext<ShopContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));// COOKIE VE IDENTITY 
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders(); // COOKIE VE IDENTITY 


            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 5;

                // LOCK-OUT

                options.Lockout.MaxFailedAccessAttempts = 5; // MAX 5 KERE YANLIÞ PASS GÝREBÝLÝR. ACC KÝLÝT
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // 5 DK SONRA LOGÝN OLABÝLÝR.
                options.Lockout.AllowedForNewUsers = true;

                // USER-NAME

                //options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true; // UNIQ MAIL ADRES
                options.SignIn.RequireConfirmedEmail = true; // EMAIL ONAYI
                options.SignIn.RequireConfirmedPhoneNumber = false; // TELEFON ONAYI

            });

            // COOKIE

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/accont/logout";
                options.AccessDeniedPath = "/account/accessdenied"; // ERÝÞÝM ENGELÝ 
                options.SlidingExpiration = true; // COOKIE DEFAULT TIME 20 DK. TRUE = 20 DK ÝÇÝNDE ÝSTEK OLURSA SÜRE RESETLENÝR.
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60); // LOGIN SÜRESÝNÝ EXPIRETIMESPAN ALTINDA DEÐÝÞEBÝLÝRÝZ. DEFAULT 20 MIN OLARAK GELÝR.
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,
                    Name = ".ShopApp.Security.Cookie",
                    SameSite = SameSiteMode.Strict

                };
            });     

            // appsettings.json içinden config ile alýndý. ctor _configuration
            services.AddScoped<IEmailSender, SmtpEmailSender>(i =>
            new SmtpEmailSender(
            Configuration["EmailSender:Host"],
            Configuration.GetValue<int>("EmailSender:Port"),
            Configuration.GetValue<bool>("EmailSender:EnableSSL"),
            Configuration["EmailSender:UserName"],
            Configuration["EmailSender:Password"]
            ));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<ICategoryService, CategoryManager>();
            //services.AddScoped<IProductService, ProductManager>();
            //services.AddScoped<ICartService, CartManager>();
            //services.AddScoped<IOrderService, OrderManager>();
            services.LoadMyServices();

            //services.AddScoped<IOrderRepository, EfCoreOrderRepository>();
            //services.AddScoped<ICartRepository, EfCoreCartRepository>();
            //services.AddScoped<IProductRepository, EfCoreProductRepository>();
            //services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                //SeedDb.Seed();
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization(); 


            // localhost/home/index
            // localhost/category/list

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "orders",
                    pattern: "orders",
                    defaults: new { controller = "Order", action = "GetOrders" }
                    );

                endpoints.MapControllerRoute(
                    name: "checkout",
                    pattern: "checkout",
                    defaults: new { controller = "Cart", action = "Checkout" }
                    );

                endpoints.MapControllerRoute(
                    name: "cart",
                    pattern: "cart",
                    defaults: new { controller = "Cart", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminusers",
                    pattern: "admin/user/list",
                    defaults: new { controller = "admin", action = "UserList" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminuseredit",
                    pattern: "admin/user/{id?}",
                    defaults: new { controller = "admin", action = "UserEdit" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminroles",
                    pattern: "admin/role/list",
                    defaults: new { controller = "admin", action = "RoleList" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminrolecreate",
                    pattern: "admin/role/create",
                    defaults: new { controller = "admin", action = "RoleCreate" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminroleedit",
                    pattern: "admin/role/{id?}",
                    defaults: new { controller = "admin", action = "RoleEdit" }
                    );


                endpoints.MapControllerRoute(
                    name: "adminproducts",
                    pattern: "admin/products",
                    defaults: new { controller = "admin", action = "productlist"}
                    );

                endpoints.MapControllerRoute(
                    name: "adminproductcreate",
                    pattern: "admin/products/create",
                    defaults: new { controller = "admin", action = "productcreate" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminproductedit",
                    pattern: "admin/products/{id?}",
                    defaults: new { controller = "admin", action = "ProductEdit" }
                    );

                endpoints.MapControllerRoute(
                    name: "admincategories",
                    pattern: "admin/categories",
                    defaults: new { controller = "admin", action = "categorylist" }
                    );

                endpoints.MapControllerRoute(
                    name: "admincategorycreate",
                    pattern: "admin/categories/create",
                    defaults: new { controller = "admin", action = "categorycreate" }
                    );

                endpoints.MapControllerRoute(
                    name: "admincategoryedit",
                    pattern: "admin/categories/{id?}",
                    defaults: new { controller = "admin", action = "categoryedit" }
                    );

                endpoints.MapControllerRoute(
                    name: "search",
                    pattern: "search",
                    defaults: new { controller = "shop", action = "search" }
                    );

                endpoints.MapControllerRoute(
                    name: "products",
                    pattern: "products/{category?}",
                    defaults: new { controller = "shop", action = "list" }
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}" // - CONTROLLER TANIMLAMASI
                     );
                
            });

            SeedIdentity.Seed(userManager, roleManager, configuration).Wait();
        }
    }
}
