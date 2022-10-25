//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.HttpsPolicy;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
//using Ocelot.Middleware;
//using Ocelot.DependencyInjection;


using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;


namespace OcelotAPIGateway.API
{
    //public class Startup
    //{
    //    //public Startup(IConfiguration configuration)
    //    //{
    //    //    Configuration = configuration;
    //    //}

    //    // public IConfiguration Configuration { get; }

    //    public readonly IConfiguration _configuration;

    //    public Startup(IConfiguration configuration)
    //    {
    //        _configuration = configuration;
    //    }



    //    // This method gets called by the runtime. Use this method to add services to the container.
    //    public void ConfigureServices(IServiceCollection services)
    //    {
    //        services.AddOcelot(_configuration);
    //        //services.AddControllers();

    //    }

    //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //    {


    //        //if (env.IsDevelopment())
    //        //{
    //        //    app.UseDeveloperExceptionPage();
    //        //}

    //        app.UseHttpsRedirection();

    //        app.UseOcelot().Wait();

    //        //app.UseRouting();

    //        //app.UseAuthorization();

    //        app.UseEndpoints(endpoints =>
    //        {
    //            endpoints.MapControllers();
    //        });
    //    }
    //}


    public sealed class Startup
    {
        public readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot(_configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            app.UseHttpsRedirection();

            app.UseOcelot().Wait();
        }
    }

}
