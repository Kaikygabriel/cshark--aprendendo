using LoginMvc.Data;
using LoginMvc.Models;
using LoginMvc.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<Usuario>();
builder.Services.AddScoped<ServiceRepositoryLogin>();

builder.Services.AddDbContext<LoginMvcDbContext>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("Login"),
        new MySqlServerVersion(new Version(8, 0, 42)),
        builder => builder.MigrationsAssembly("LoginMvc")
    );
});

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
    pattern: "{controller=Usuario}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
