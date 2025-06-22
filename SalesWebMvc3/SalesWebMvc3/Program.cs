using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc3.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SalesWebMvc3.Services;
using SalesWebMvc3.Models.ViewModels;

namespace SalesWebMvc3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<SalesWebMvc3Context>(options =>
            options.UseMySql(
                builder.Configuration.GetConnectionString("SalesWebMvc3Context"),
                new MySqlServerVersion(new Version(8, 0, 42)),
                builder => builder.MigrationsAssembly("SalesWebMvc3")
                )
            );


            builder.Services.AddScoped<SeedingService>();
            builder.Services.AddScoped<SallerService>();
            builder.Services.AddScoped<DepartamentService>();
            builder.Services.AddScoped<SallerFormViewModel>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            // Chamada ao serviço de seeding
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var seedingService = services.GetRequiredService<SeedingService>();
                seedingService.Seed();
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
