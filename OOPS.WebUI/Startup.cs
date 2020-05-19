using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.BLL.Concreate;
using OOPS.BLL.Concreate.StaticConcreate;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DAL;
using OOPS.MapConfig.ConfigProfile;
using OOPS.WebUI.CustomHandler;
using OOPS.WebUI.Models;
using OOPS.WebUI.Validators;

namespace OOPS.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            MapperConfig.RegisterMappers();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            var optionsBuilder = new DbContextOptionsBuilder<OOPSEntites>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("OOPSEntites"));
            optionsBuilder.EnableSensitiveDataLogging();

            services.AddSingleton<DbContext>(new OOPSEntites(optionsBuilder.Options));

            using (var context = new OOPSEntites(optionsBuilder.Options))
            {
                context.Database.EnsureCreated();
                context.Database.Migrate();
            }


            services.AddAuthentication("CookieAuthentication")
              .AddCookie("CookieAuthentication", config =>
              {
                  config.Cookie.Name = "UserLoginCookie"; // Name of cookie     
                  config.LoginPath = "/Login"; // Path for the redirect to user login page    
                  config.AccessDeniedPath = "/AccessDenied";
              });

            services.AddAuthorization(config =>
            {
                config.AddPolicy("UserPolicy", policyBuilder =>
                {
                    policyBuilder.UserRequireCustomClaim(ClaimTypes.Email);
                    policyBuilder.UserRequireCustomClaim(ClaimTypes.DateOfBirth);
                });
            });

            services.AddScoped<IAuthorizationHandler, PoliciesAuthorizationHandler>();
            services.AddScoped<IAuthorizationHandler, RolesAuthorizationHandler>();


            services.AddSingleton<IUnitofWork, UnitofWork>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IRoleService, RoleService>();
            services.AddSingleton<IEmployeeService, EmployeeService>();
            services.AddSingleton<IAccessTypeService, AccessTypeService>();
            services.AddSingleton<IBankAccountTypeService, BankAccountTypeService>();
            services.AddSingleton<IBloodGroupService, BloodGroupService>();
            services.AddSingleton<ICityService, CityService>();
            services.AddSingleton<IContractTypeService, ContractTypeService>();
            services.AddSingleton<ICountryService, CountryService>();
            services.AddSingleton<IDebitCategoryService, DebitCategoryService>();
            services.AddSingleton<IDisabilitySituationService, DisabilitySituationService>();
            services.AddSingleton<IDistrictService, DistrictService>();
            services.AddSingleton<IEducationLevelService, EducationLevelService>();
            services.AddSingleton<IEducationStatusService, EducationStatusService>();
            services.AddSingleton<IEmploymentTypeService, EmploymentTypeService>();
            services.AddSingleton<IGenderService, GenderService>();
            services.AddSingleton<IMaritalStatusService, MaritalStatusService>();
            services.AddSingleton<IPermitTypeService, PermitTypeService>();
            services.AddSingleton<IVisaTypeService, VisaTypeService>();

            services.AddControllersWithViews().AddFluentValidation();
            services.AddTransient<IValidator<RegisterViewModel>, RegisterValidator>();
            services.AddTransient<IValidator<UserLoginViewModel>, UserLoginValidator>();
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

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Dashboard",
                    pattern: "Dashboard",
                    defaults: new { controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                     name: "Login",
                     pattern: "Login",
                     defaults: new { controller = "Login", action = "UserLogin" });

                endpoints.MapControllerRoute(
                    name: "AccessDenied",
                    pattern: "AccessDenied",
                    defaults: new { controller = "Login", action = "UserAccessDenied" });

                endpoints.MapControllerRoute(
                     name: "Logout",
                     pattern: "Logout",
                     defaults: new { controller = "Login", action = "Logout" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=UserLogin}/{id?}");
            });

        }
    }
}
