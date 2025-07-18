using GerenciadorDeTarefasMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore;
using GerenciadorDeTarefasMvc.Models;
using GerenciadorDeTarefasMvc.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TaskContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("GerenciadorDeTarefasMvc"),
        new MySqlServerVersion(new Version(8, 0, 42)),
        builder => builder.MigrationsAssembly("GerenciadorDeTarefasMvc")
        )
);

builder.Services.AddScoped<TaskItem>();
builder.Services.AddScoped<ServiceDataTask>();
builder.Services.AddScoped<SeedingTaskItem>();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;
    var seeding = service.GetRequiredService<SeedingTaskItem>();
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
