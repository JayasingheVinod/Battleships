using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Boards.GenerateEmptyBoard;
using Application.Boards.SaveBoard;
using Application.Common.Commands.ConvertFieldToPoint;
using Application.Common.Commands.GenerateBoardWithShips;
using Application.Ships.GenerateShips;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebUI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IEmptyBoardGenerator, EmptyBoardGenerator>();
            services.AddTransient<IShipsGenerator, ShipsGenerator>();
            services.AddTransient<IFieldToPointConverter, FieldToPointConverter>();
            services.AddTransient<IBoardWithShipsGenerator, BoardWithShipsGenerator>();

            services.AddSingleton<IBoardSaver, BoardSaver>();

            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/build"; });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
                app.UseHttpsRedirection();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
