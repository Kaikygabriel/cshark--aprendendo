using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc3.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

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

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
