using GerenciadorDeAlunoComCursoMvc.Data;
using GerenciadorDeAlunoComCursoMvc.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped < ServiceRepositoryCurso>();
builder.Services.AddScoped<SeedingServiceCurso>();

builder.Services.AddDbContext<CursoDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("GerenciadorDeAlunoComCurso"),
        new MySqlServerVersion(new Version(8, 0, 42)),
        builder => builder.MigrationsAssembly("GerenciadorDeAlunoComCursoMvc")
    )
);


var app = builder.Build();

using (var scope = app.Services.CreateAsyncScope())
{
    var service = scope.ServiceProvider;
    var seeding = service.GetRequiredService<SeedingServiceCurso>();
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
