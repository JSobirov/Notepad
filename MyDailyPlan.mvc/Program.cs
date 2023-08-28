using Microsoft.EntityFrameworkCore;
using MyDailyPlan.DAL.Contexts;
using MyDailyPlan.DAL.IRepositories;
using MyDailyPlan.DAL.Repositories;
using MyDailyPlan.mvc.Extensions;
using MyDailyPlan.Service4.Interfaces;
using MyDailyPlan.Service4.Mappers;
using MyDailyPlan.Service4.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddServices();


builder.Services.AddDbContext<AppDbContext>(options =>
{ options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase")); });


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Plans}/{action=Index}/{id?}");

app.Run();
