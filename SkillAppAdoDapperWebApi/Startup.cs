using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Interfaces;
using DAL.Interfaces.ISQLRepositories;
using DAL.Repositories.SQLRepositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DAL.Servises;
using DAL.Interfaces.IServices;

using DAL.Mapper;
using AutoMapper;

namespace WEBAPI
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
            services.AddControllers();

            services.AddTransient<ISQLCustomerRepository, SQLCustomerRepository>();
            services.AddTransient<ISQLOrderRepository, SQLOrderRepository>();
            services.AddTransient<ISQLTOYDetRepository, SQLTOYDetRepository>();
            services.AddTransient<ISQLToyRepository, SQLToyRepository>();
            services.AddTransient<ISQLVendorRepository, SQLVendorRepository>();
            services.AddTransient<ISQLVENDORDetRepository, SQLVENDORDetRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddSwaggerGen();

            services.AddDbContext<Context>(options =>
            {
                string connectionString = Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            });

            services.AddTransient<ICustomerServices, CustomerServices>();
            services.AddTransient<IOrderServices, OrderServices>();
            services.AddTransient<ITOYDetServices, TOYDetServices>();
            services.AddTransient<IToyServices, ToyServices>();
            services.AddTransient<IVENDORDetServices, VENDORDetServices>();
            services.AddTransient<IVendorServices, VendorServices>();


            services.AddControllers();

            services.AddTransient<IConnectionFactory, ConnectionFactory>();

 
            services.AddSingleton<IConfiguration>(Configuration);

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper(); 

            services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())

            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", " ");
            });
            app.UseHttpsRedirection();

         
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
