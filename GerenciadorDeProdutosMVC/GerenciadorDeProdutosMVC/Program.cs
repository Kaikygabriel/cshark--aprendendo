using GerenciadorDeProdutosMVC.Data;
using GerenciadorDeProdutosMVC.Services;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeProdutosMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ProductsContext>(options =>
              options.UseMySql(
                  builder.Configuration.GetConnectionString("ProductsContext"),
                  new MySqlServerVersion(new Version(8,0,42)),
                  options => options.MigrationsAssembly("GerenciadorDeProdutosMVC")
                  ));

            builder.Services.AddScoped<ServiceProductsRepository>();
            builder.Services.AddScoped<SeedingProducts>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var seeding = services.GetRequiredService<SeedingProducts>();
                seeding.Seed();
            }

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
