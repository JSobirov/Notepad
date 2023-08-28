using MyDailyPlan.DAL.Contexts;
using MyDailyPlan.Service4.Mappers;
using MyDailyPlan.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using MyDailyPlan.DAL.IRepositories;
using MyDailyPlan.Service4.Services;
using MyDailyPlan.Service4.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Services
builder.Services.AddScoped<IPlanService, PlanService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddDbContext<AppDbContext>(options =>
{ options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase")); });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
