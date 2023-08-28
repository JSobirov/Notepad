using Microsoft.EntityFrameworkCore;
using MyDailyPlan.Domain.Entities;

namespace MyDailyPlan.DAL.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Plan> Planes { get; set; }
}
