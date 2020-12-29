using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beauty_Salon.Domain;
using Beauty_Salon.Domain.Repositories.Abstract;
using Beauty_Salon.Domain.Repositories.EntityFramework;
using Beauty_Salon.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Beauty_Salon
{
    public class Startup
    {
        public IConfiguration Configuration { get;}
        public Startup(IConfiguration configuration) => Configuration = configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //���������� ������ �� appsettings.json
            Configuration.Bind("Project", new Config());
            //���������� ����� ���������� ���������� � �������� ��������
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();
            //���������� �������� ��
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
            //����������� identity �������
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "BeautySalonAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });
            services.AddControllersWithViews()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) 
                app.UseDeveloperExceptionPage();

                app.UseStaticFiles();
                //���������� ������� �������������
                app.UseRouting();
            //���������� �������������� � �����������
                app.UseCookiePolicy();
                app.UseAuthentication();
                app.UseAuthorization();
            //������������ ������ ��������(���������)
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
