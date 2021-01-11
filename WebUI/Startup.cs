using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebUI.Filters;

namespace WebUI
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
            services.AddScoped<ITbl_AdService, Tbl_AdManager>();
            services.AddScoped<ITbl_AdDal, EfTbl_AdDal>();
            services.AddScoped<ITbl_AdRoleService, Tbl_AdRoleManager>();
            services.AddScoped<ITbl_AdRoleDal, EfTbl_AdRoleDal>();
            services.AddScoped<ITbl_CategoryService, Tbl_CategoryManager>();
            services.AddScoped<ITbl_CategoryDal, EfTbl_CategoryDal>();
            services.AddScoped<ITbl_CityService, Tbl_CityManager>();
            services.AddScoped<ITbl_CityDal, EfTbl_CityDal>();
            services.AddScoped<IView_AdInfoService, View_AdInfoManager>();
            services.AddScoped<IView_AdInfoDal, EfView_AdInfoDal>();
            services.AddScoped<IView_MessageService, View_MessageManager>();
            services.AddScoped<IView_MessageDal, EfView_MessageDal>();
            services.AddScoped<ITbl_MessageService, Tbl_MessageManager>();
            services.AddScoped<ITbl_MessageDal, EfTbl_MessageDal>();


            services.AddScoped<ITbl_ListService, Tbl_ListManager>();
            services.AddScoped<ITbl_ListDal, EfTbl_ListDal>();
            services.AddScoped<ITbl_MemberService, Tbl_MemberManager>();
            services.AddScoped<ITbl_MemberDal, EfTbl_MemberDal>();
            services.AddScoped<ITbl_RequestService, Tbl_RequestManager>();
            services.AddScoped<ITbl_RequestDal, EfTbl_RequestDal>();
            services.AddScoped<ITbl_RequestStateService, Tbl_RequestStateManager>();
            services.AddScoped<ITbl_RequestStateDal, EfTbl_RequestStateDal>();
            services.AddScoped<IView_AdGeneralInfoService, View_AdGeneralInfoManager>();
            services.AddScoped<IView_AdGeneralInfoDal, EfView_AdGeneralInfoDal>();


            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<LoginFilter>();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
                options.Cookie.HttpOnly = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();
            app.UseStatusCodePages();
            app.UseMvc();
        }
    }
}
