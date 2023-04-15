using Microsoft.EntityFrameworkCore;
using VuelosCRUD.Models;

var builder = WebApplication.CreateBuilder(args);

// Conexión con la db
builder.Services.AddDbContext<VuelosDbContext>(
  opciones => opciones.UseSqlServer(builder.Configuration.GetConnectionString("DbConectionString")
));

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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Vuelos}/{action=Index}/{id?}");

app.Run();
